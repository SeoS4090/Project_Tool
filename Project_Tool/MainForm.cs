using MessagePack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Tool
{
    public partial class Main : Form
    {
        public ExcelToData excltoData;

        public Main()
        {
            InitializeComponent();
        }

        private void ExcelToData_Click(object sender, EventArgs e)
        {
            excltoData = new ExcelToData(this);
            excltoData.Show();
            this.Hide();
        }

        private void MSP_Test_Btn_Click(object sender, EventArgs e)
        {
        }
    }
}
