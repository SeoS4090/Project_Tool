using MessagePack;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Project_Tool
{
    public partial class Maptool : Form
    {
        Main main;
        public Maptool(Main main)
        {
            InitializeComponent();
            this.main = main;
        }
        protected override void OnClosed(EventArgs e)
        {
            var result = MessageBox.Show("프로그램을 종료 하시겠습니까?", "Notice", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                base.OnClosed(e);
                main.Close();
            }
            else if (result == DialogResult.No)
            {
                main.Show();
                base.Hide();
            }
        }

        private void Btn_Apply_Click(object sender, EventArgs e)
        {
            MapGrid.Controls.Clear();

            var width = Convert.ToInt32(TextBox_Width.Text);
            var height = Convert.ToInt32(TextBox_Height.Text);

            MapGrid.Columns.Clear();

            object[] param = new object[width];

            for (int x = 0; x < width; x++)
            {
                MapGrid.Columns.Add($"Name_{x}", $"{x}");
                param[x] = "1";
            }

            for (int y = 0; y < height; y++)
            {
                MapGrid.Rows.Add(param);
            }

            foreach(DataGridViewColumn Column in MapGrid.Columns)
            {
                Column.Width = 30;
                Column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void Maptool_Load(object sender, EventArgs e)
        {
            var path = Application.StartupPath.Replace("bin", "MapData").Replace("Debug", "Block_Info.txt");
            var Block_Info = File.ReadAllText(path);
            Text_Block_Info.Text = Block_Info;


            var enumlist = Enum.GetNames(typeof( MapData.Define_Block.Block_Type)).ToList();
            
            foreach (var enumname in enumlist)
                Combo_Block.Items.Add(enumname);

        }

        private void Btn_CreateMap_Click(object sender, EventArgs e)
        {
            bool b_Check_Stage = false;
            bool b_Check_Scores = false;
            bool b_Check_ClearCount = false;

            try
            {

                var Stage = Convert.ToInt32(Text_Box_Stage.Text);
                b_Check_Stage = true;

                var ClearCount = Convert.ToInt32(Text_Box_ClearCount.Text);
                b_Check_ClearCount = true;


                List<int> scores = new List<int>();
                var Text_score = Text_Box_Score.Text.Trim().Split(',');


                foreach(var score in Text_score)
                {
                    scores.Add(Convert.ToInt32(score.Trim()));
                }

                if(scores.Count < 3)
                {
                    MessageBox.Show("스코어 개수가 부족 합니다.");
                    return;
                }
                b_Check_Scores = scores.Count > 0;


                if (MapGrid.GetCellCount(DataGridViewElementStates.Visible) <= 0)
                {
                    MessageBox.Show("맵을 만들어 주세요");
                    return;
                }


                if(checkedListBox1.Items.Count <= 0)
                {
                    MessageBox.Show("클리어 조건을 설정해 주세요");
                    return;
                }


                MSP_Game_Stage stage = new MSP_Game_Stage();
                stage.DataKey = $"Map_Stage_{Stage}";
                stage.Scores = scores;

                stage.GameType_Name = new List<string>();
                stage.GameType_Count = new List<int>();
                foreach (var Condition in winList)
                {
                    stage.GameType_Name.Add(Condition.Key);
                    stage.GameType_Count.Add(Condition.Value.Item1);
                }
                stage.Width = Convert.ToInt32(TextBox_Width.Text);
                stage.Height = Convert.ToInt32(TextBox_Height.Text);
                stage.Map = new List<int>();
                for (int y = 0; y < MapGrid.Rows.Count; y++)
                {
                    for(int x = 0; x < MapGrid.Rows[y].Cells.Count; x++)
                    {
                        int type = -1;
                        try { type = Convert.ToInt32(MapGrid.Rows[y].Cells[x].Value); }
                        catch
                        { 
                            MessageBox.Show($"맵 정보가 잘못 됬습니다, : {x} , {y}");
                            return;
                        }

                        stage.Map.Add(type);
                    }
                }


                SaveFile(stage);
            }
            catch 
            {
                if (b_Check_Stage == false)
                {
                    MessageBox.Show("스테이지를 설정 해 주세요");
                    return;
                }
                if (b_Check_Scores == false)
                {
                    MessageBox.Show("스코어를 설정 해 주세요");
                    return;
                }

                if (b_Check_ClearCount == false)
                {
                    MessageBox.Show("클리어 까지 남은 턴을 설정 해 주세요");
                    return;
                }
                

                return;
            }
        }

        //         Block    Count ListBoxIndex
        Dictionary<string, (int, int)> winList = new Dictionary<string, (int, int)>();

        private void Win_Add_Click(object sender, EventArgs e)
        {

            try
            {
                Convert.ToInt32(TextBox_Win.Text);
            }
            catch
            {
                return;
            }

            if (winList.ContainsKey(Combo_Block.Text))
            {
                checkedListBox1.Items.RemoveAt(winList[Combo_Block.Text].Item2);
                winList[Combo_Block.Text] = (Convert.ToInt32(TextBox_Win.Text), checkedListBox1.Items.Count);
            }
            else
            {
                int count = Convert.ToInt32(TextBox_Win.Text);
                int index = checkedListBox1.Items.Count;


                winList.Add( Combo_Block.Text, (count,index ));
            }

            checkedListBox1.Items.Add($"{Combo_Block.Text} x {TextBox_Win.Text}");

            Combo_Block.Text = "";
            TextBox_Win.Text = "";
        }

        private void Win_Delete_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems)
            { 
                foreach (var winItem in winList)
                {
                    if ($"{winItem.Key} x {winItem.Value.Item1}".Equals(item.ToString()))
                    {
                        winList.Remove(winItem.Key);
                        break;
                    }
                }
            }


            List<object> RemoveList = new List<object>();


            foreach (var item in checkedListBox1.CheckedItems)
            {
                RemoveList.Add(item);
            }

            foreach(var removeitem in RemoveList)
            {
                checkedListBox1.Items.Remove(removeitem);
            }
            
        }

        public void SaveFile(MSP_Game_Stage stage)
        {
            if (stage.DataKey == null)
                return;

            var bytes = MessagePackSerializer.Serialize(stage);

            if (Directory.Exists($"{Application.StartupPath}/MapData") == false)
                Directory.CreateDirectory($"{Application.StartupPath}/MapData");

            File.WriteAllBytes($"{Application.StartupPath}/MapData/{stage.DataKey}.bytes", bytes);


            Process.Start($"{Application.StartupPath}/MapData");
        }

        private void Btn_LoadMap_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.InitialDirectory = $"{Application.StartupPath}/MapData";
            dialog.Filter = "mapdata *bytes | *bytes";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                var bytes = File.ReadAllBytes(dialog.FileName);
                MSP_Game_Stage data = MessagePackSerializer.Deserialize<MSP_Game_Stage>(bytes);


                MessageBox.Show("Complete Load");
                
            }

        }

    }
}
