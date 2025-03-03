using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai17_Tinhlaisuat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double sotien = double.Parse(txtVon.Text);
            double laisuat = double.Parse(txtlaisuat.Text.Replace("%", "")) / 100;
            int nam = Convert.ToInt32(txtnam.Text);
            double tienlai = 0;
            lstkq.Items.Clear();
            for (int i = 1; 1 <= nam; i++)
            {
                tienlai = sotien * laisuat;
                lstkq.Items.Add("Năm" + i + ":vốn=" + string.Format("{0:N0}", sotien)+"-tiền lãi:" + string.Format("{0:N0}", tienlai));
                sotien += tienlai;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtVon.Text = "10000000";
            txtlaisuat.Text = "7%";
            txtnam.Text = "10";
        }
    }
}



