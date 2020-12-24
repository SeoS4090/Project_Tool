namespace Project_Tool
{
    partial class Maptool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LB_width = new System.Windows.Forms.Label();
            this.TextBox_Width = new System.Windows.Forms.TextBox();
            this.TextBox_Height = new System.Windows.Forms.TextBox();
            this.LB_Height = new System.Windows.Forms.Label();
            this.Btn_Apply = new System.Windows.Forms.Button();
            this.btn_CreateMap = new System.Windows.Forms.Button();
            this.Text_Box_Score = new System.Windows.Forms.TextBox();
            this.LB_Map = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MapGrid = new System.Windows.Forms.DataGridView();
            this.Text_Block_Info = new System.Windows.Forms.RichTextBox();
            this.Combo_Block = new System.Windows.Forms.ComboBox();
            this.Win_Add = new System.Windows.Forms.Button();
            this.TextBox_Win = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Win_Delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Text_Box_Stage = new System.Windows.Forms.TextBox();
            this.LB_Score = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Text_Box_ClearCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MapGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_width
            // 
            this.LB_width.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_width.AutoSize = true;
            this.LB_width.Location = new System.Drawing.Point(13, 10);
            this.LB_width.Name = "LB_width";
            this.LB_width.Size = new System.Drawing.Size(80, 40);
            this.LB_width.TabIndex = 0;
            this.LB_width.Text = "Width";
            this.LB_width.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox_Width
            // 
            this.TextBox_Width.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Width.Location = new System.Drawing.Point(99, 13);
            this.TextBox_Width.Name = "TextBox_Width";
            this.TextBox_Width.Size = new System.Drawing.Size(80, 25);
            this.TextBox_Width.TabIndex = 0;
            // 
            // TextBox_Height
            // 
            this.TextBox_Height.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Height.Location = new System.Drawing.Point(271, 13);
            this.TextBox_Height.Name = "TextBox_Height";
            this.TextBox_Height.Size = new System.Drawing.Size(80, 25);
            this.TextBox_Height.TabIndex = 1;
            // 
            // LB_Height
            // 
            this.LB_Height.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_Height.AutoSize = true;
            this.LB_Height.Location = new System.Drawing.Point(185, 10);
            this.LB_Height.Name = "LB_Height";
            this.LB_Height.Size = new System.Drawing.Size(80, 40);
            this.LB_Height.TabIndex = 2;
            this.LB_Height.Text = "Height";
            this.LB_Height.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Apply
            // 
            this.Btn_Apply.Location = new System.Drawing.Point(357, 13);
            this.Btn_Apply.Name = "Btn_Apply";
            this.Btn_Apply.Size = new System.Drawing.Size(75, 25);
            this.Btn_Apply.TabIndex = 2;
            this.Btn_Apply.Text = "Apply";
            this.Btn_Apply.UseVisualStyleBackColor = true;
            this.Btn_Apply.Click += new System.EventHandler(this.Btn_Apply_Click);
            // 
            // btn_CreateMap
            // 
            this.btn_CreateMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CreateMap.Location = new System.Drawing.Point(531, 13);
            this.btn_CreateMap.Name = "btn_CreateMap";
            this.btn_CreateMap.Size = new System.Drawing.Size(85, 25);
            this.btn_CreateMap.TabIndex = 6;
            this.btn_CreateMap.Text = "Save Map";
            this.btn_CreateMap.UseVisualStyleBackColor = true;
            this.btn_CreateMap.Click += new System.EventHandler(this.Btn_CreateMap_Click);
            // 
            // Text_Box_Score
            // 
            this.Text_Box_Score.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_Box_Score.Location = new System.Drawing.Point(271, 53);
            this.Text_Box_Score.Name = "Text_Box_Score";
            this.Text_Box_Score.Size = new System.Drawing.Size(80, 25);
            this.Text_Box_Score.TabIndex = 4;
            // 
            // LB_Map
            // 
            this.LB_Map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_Map.AutoSize = true;
            this.LB_Map.Location = new System.Drawing.Point(13, 50);
            this.LB_Map.Name = "LB_Map";
            this.LB_Map.Size = new System.Drawing.Size(80, 40);
            this.LB_Map.TabIndex = 7;
            this.LB_Map.Text = "Stage";
            this.LB_Map.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MapGrid
            // 
            this.MapGrid.AllowUserToAddRows = false;
            this.MapGrid.AllowUserToResizeRows = false;
            this.MapGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MapGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MapGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MapGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MapGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.MapGrid.Location = new System.Drawing.Point(12, 118);
            this.MapGrid.Name = "MapGrid";
            this.MapGrid.RowHeadersVisible = false;
            this.MapGrid.RowHeadersWidth = 51;
            this.MapGrid.RowTemplate.Height = 27;
            this.MapGrid.Size = new System.Drawing.Size(432, 515);
            this.MapGrid.TabIndex = 5;
            // 
            // Text_Block_Info
            // 
            this.Text_Block_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_Block_Info.Enabled = false;
            this.Text_Block_Info.Location = new System.Drawing.Point(457, 347);
            this.Text_Block_Info.Name = "Text_Block_Info";
            this.Text_Block_Info.Size = new System.Drawing.Size(184, 286);
            this.Text_Block_Info.TabIndex = 10;
            this.Text_Block_Info.Text = "";
            // 
            // Combo_Block
            // 
            this.Combo_Block.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Combo_Block.FormattingEnabled = true;
            this.Combo_Block.Location = new System.Drawing.Point(457, 228);
            this.Combo_Block.Name = "Combo_Block";
            this.Combo_Block.Size = new System.Drawing.Size(184, 23);
            this.Combo_Block.TabIndex = 11;
            // 
            // Win_Add
            // 
            this.Win_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Win_Add.Location = new System.Drawing.Point(457, 289);
            this.Win_Add.Name = "Win_Add";
            this.Win_Add.Size = new System.Drawing.Size(184, 23);
            this.Win_Add.TabIndex = 12;
            this.Win_Add.Text = "Add";
            this.Win_Add.UseVisualStyleBackColor = true;
            this.Win_Add.Click += new System.EventHandler(this.Win_Add_Click);
            // 
            // TextBox_Win
            // 
            this.TextBox_Win.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Win.Location = new System.Drawing.Point(457, 258);
            this.TextBox_Win.Name = "TextBox_Win";
            this.TextBox_Win.Size = new System.Drawing.Size(184, 25);
            this.TextBox_Win.TabIndex = 13;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(457, 118);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(184, 104);
            this.checkedListBox1.TabIndex = 14;
            // 
            // Win_Delete
            // 
            this.Win_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Win_Delete.Location = new System.Drawing.Point(457, 318);
            this.Win_Delete.Name = "Win_Delete";
            this.Win_Delete.Size = new System.Drawing.Size(184, 23);
            this.Win_Delete.TabIndex = 15;
            this.Win_Delete.Text = "Delete";
            this.Win_Delete.UseVisualStyleBackColor = true;
            this.Win_Delete.Click += new System.EventHandler(this.Win_Delete_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(443, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 25);
            this.button1.TabIndex = 16;
            this.button1.Text = "Load Map";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn_LoadMap_Click);
            // 
            // Text_Box_Stage
            // 
            this.Text_Box_Stage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_Box_Stage.Location = new System.Drawing.Point(99, 53);
            this.Text_Box_Stage.Name = "Text_Box_Stage";
            this.Text_Box_Stage.Size = new System.Drawing.Size(80, 25);
            this.Text_Box_Stage.TabIndex = 3;
            // 
            // LB_Score
            // 
            this.LB_Score.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_Score.AutoSize = true;
            this.LB_Score.Location = new System.Drawing.Point(185, 50);
            this.LB_Score.Name = "LB_Score";
            this.LB_Score.Size = new System.Drawing.Size(80, 40);
            this.LB_Score.TabIndex = 17;
            this.LB_Score.Text = "Scores";
            this.LB_Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.LB_width, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextBox_Width, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.LB_Score, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Text_Box_Stage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LB_Map, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LB_Height, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextBox_Height, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Text_Box_Score, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_CreateMap, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Apply, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.Text_Box_ClearCount, 5, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(629, 100);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 40);
            this.label1.TabIndex = 17;
            this.label1.Text = "Clear Count";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Text_Box_ClearCount
            // 
            this.Text_Box_ClearCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_Box_ClearCount.Location = new System.Drawing.Point(443, 53);
            this.Text_Box_ClearCount.Name = "Text_Box_ClearCount";
            this.Text_Box_ClearCount.Size = new System.Drawing.Size(80, 25);
            this.Text_Box_ClearCount.TabIndex = 4;
            // 
            // Maptool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 645);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Win_Delete);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.TextBox_Win);
            this.Controls.Add(this.Win_Add);
            this.Controls.Add(this.Combo_Block);
            this.Controls.Add(this.Text_Block_Info);
            this.Controls.Add(this.MapGrid);
            this.MinimumSize = new System.Drawing.Size(18, 500);
            this.Name = "Maptool";
            this.Text = "Maptool";
            this.Load += new System.EventHandler(this.Maptool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MapGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_width;
        private System.Windows.Forms.TextBox TextBox_Width;
        private System.Windows.Forms.TextBox TextBox_Height;
        private System.Windows.Forms.Label LB_Height;
        private System.Windows.Forms.Button Btn_Apply;
        private System.Windows.Forms.Button btn_CreateMap;
        private System.Windows.Forms.TextBox Text_Box_Score;
        private System.Windows.Forms.Label LB_Map;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView MapGrid;
        private System.Windows.Forms.RichTextBox Text_Block_Info;
        private System.Windows.Forms.ComboBox Combo_Block;
        private System.Windows.Forms.Button Win_Add;
        private System.Windows.Forms.TextBox TextBox_Win;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button Win_Delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Text_Box_Stage;
        private System.Windows.Forms.Label LB_Score;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Text_Box_ClearCount;
    }
}