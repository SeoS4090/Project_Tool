
namespace Project_Tool
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExcelToData = new System.Windows.Forms.Button();
            this.Btn_MapTool = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExcelToData
            // 
            this.ExcelToData.Location = new System.Drawing.Point(14, 15);
            this.ExcelToData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExcelToData.Name = "ExcelToData";
            this.ExcelToData.Size = new System.Drawing.Size(114, 31);
            this.ExcelToData.TabIndex = 0;
            this.ExcelToData.Text = "Excel->Data";
            this.ExcelToData.UseVisualStyleBackColor = true;
            this.ExcelToData.Click += new System.EventHandler(this.ExcelToData_Click);
            // 
            // Btn_MapTool
            // 
            this.Btn_MapTool.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_MapTool.Location = new System.Drawing.Point(139, 15);
            this.Btn_MapTool.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_MapTool.Name = "Btn_MapTool";
            this.Btn_MapTool.Size = new System.Drawing.Size(114, 31);
            this.Btn_MapTool.TabIndex = 1;
            this.Btn_MapTool.Text = "Map Tool";
            this.Btn_MapTool.UseVisualStyleBackColor = true;
            this.Btn_MapTool.Click += new System.EventHandler(this.Map_Tool_Btn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 64);
            this.Controls.Add(this.Btn_MapTool);
            this.Controls.Add(this.ExcelToData);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Project Tool";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExcelToData;
        private System.Windows.Forms.Button Btn_MapTool;
    }
}

