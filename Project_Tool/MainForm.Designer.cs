
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
            this.MessagePack_Test_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExcelToData
            // 
            this.ExcelToData.Location = new System.Drawing.Point(12, 12);
            this.ExcelToData.Name = "ExcelToData";
            this.ExcelToData.Size = new System.Drawing.Size(100, 25);
            this.ExcelToData.TabIndex = 0;
            this.ExcelToData.Text = "Excel->Data";
            this.ExcelToData.UseVisualStyleBackColor = true;
            this.ExcelToData.Click += new System.EventHandler(this.ExcelToData_Click);
            // 
            // MessagePack_Test_Button
            // 
            this.MessagePack_Test_Button.Location = new System.Drawing.Point(122, 12);
            this.MessagePack_Test_Button.Name = "MessagePack_Test_Button";
            this.MessagePack_Test_Button.Size = new System.Drawing.Size(100, 25);
            this.MessagePack_Test_Button.TabIndex = 1;
            this.MessagePack_Test_Button.Text = "MSP Test";
            this.MessagePack_Test_Button.UseVisualStyleBackColor = true;
            this.MessagePack_Test_Button.Click += new System.EventHandler(this.MSP_Test_Btn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 51);
            this.Controls.Add(this.MessagePack_Test_Button);
            this.Controls.Add(this.ExcelToData);
            this.Name = "Main";
            this.Text = "Project Tool";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExcelToData;
        private System.Windows.Forms.Button MessagePack_Test_Button;
    }
}

