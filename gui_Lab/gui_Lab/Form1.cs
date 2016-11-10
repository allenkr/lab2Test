using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = Total_Bill_Box.Text;
            double ip;
            double.TryParse(input,out ip);
            double tip;
            double.TryParse(Tip_Amount.Text, out tip);
            tip = tip * .01;
            tip = tip * ip;
            double total;
            double.TryParse(input, out total);
            Tip_Total.Text = (total + tip).ToString();
        }
    }
}
