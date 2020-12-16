using MessagePack;
using Newtonsoft.Json;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Tool
{
    public partial class ExcelToData : Form
    {

        #region Initalize
        Main main;
        public ExcelToData(Main mainform)
        {
            InitializeComponent();
            main = mainform;

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
        }

        protected override void OnClosed(EventArgs e)
        {

            var result = MessageBox.Show("프로그램을 종료 하시겠습니까?","Notice",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
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

        void Log(string log)
        {
            LogBox.Text += $"{log}\n";
        }

        #endregion

        //        SheetName           DataKey             Column  Value
        Dictionary<string , Dictionary<string, Dictionary<string, object>>> Dic_Data;


        private void LoadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    FilePath.Text = openFileDialog.FileName;
                    Log($"{openFileDialog.SafeFileName} 파일 열기");


                    try
                    { 
                        byte[] bin = File.ReadAllBytes(FilePath.Text);

                        using (MemoryStream stream = new MemoryStream(bin))
                        using (ExcelPackage excelPackage = new ExcelPackage(stream))
                        {

                            Dic_Data = new Dictionary<string, Dictionary<string, Dictionary<string, object>>>();

                            foreach (var sheet in excelPackage.Workbook.Worksheets)
                            {
                                if (sheet.Name.StartsWith("Tool_"))
                                    continue;

                                Log($"Loading {sheet.Name}");


                                Dic_Data.Add(sheet.Name, new Dictionary<string, Dictionary<string, object>>());

                                //loop all rows  1 : Column Name , 2: Typ
                                for (int y = 3; y <= sheet.Dimension.End.Row; y++)
                                {
                                    string DataKey = sheet.Cells[y, 1].Value as string;

                                    if (DataKey == "IGNORE")
                                        continue;

                                    Dic_Data[sheet.Name].Add(DataKey, new Dictionary<string, object>());

                                    //loop all columns in a row 1 : DataKey
                                    for (int x = 2; x <= sheet.Dimension.End.Column; x++)
                                    {
                                        string ColumnName = sheet.Cells[1, x].Value as string;

                                        if (ColumnName == "IGNORE")
                                            continue;

                                        var value = sheet.Cells[y, x].Value;

                                        Dic_Data[sheet.Name][DataKey].Add(ColumnName, $"{value}");
                                    }
                                }

                                Log($"Complete Load {sheet.Name}");
                            }
                        }
                    }
                    catch (Exception Ex)
                    {
                        Log($"파일 읽기 실패");

                        Log(Ex.Message);
                    }

                    
                }
               else Log($"파일 취소");
            }
        }

        private void LogClear_Click(object sender, EventArgs e)
        {
            LogBox.Clear();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(Dic_Data.Count <= 0)
            {
                Log("파일을 읽어 주세요");
                return;
            }


            string folderPath = $"{Application.StartupPath}/DataBaseFiles";

            if (Directory.Exists(folderPath) == false)
                Directory.CreateDirectory(folderPath);

            foreach (var sheetData in Dic_Data)
            {
                var MSP_Dictionary_Data = new Dictionary<string, object> ();

                foreach (var beforeMSP in sheetData.Value)
                {
                    var mspData = GetMSPData(sheetData.Key ,beforeMSP);
                    MSP_Dictionary_Data.Add(beforeMSP.Key, mspData);
                }

                var Data = MessagePackSerializer.Serialize(MSP_Dictionary_Data);

                File.WriteAllBytes($"{folderPath}/{sheetData.Key}.bytes", Data);
            }

            Dic_Data.Clear();
            FilePath.Clear();
            Process.Start(folderPath);
        }

        private object GetMSPData(string sheetName, KeyValuePair<string, Dictionary<string, object>> Keyvalue)
        {
            object result = null;

            if (sheetName.Equals("Shop") == true)
                result = new MSP_Shop(Keyvalue);

            if (sheetName.Equals("Game_Base") == true)
                result = new MSP_Game_Base(Keyvalue);


            return result;
        }
    }
}
