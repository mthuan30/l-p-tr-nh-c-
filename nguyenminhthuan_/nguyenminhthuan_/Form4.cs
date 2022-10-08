using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nguyenminhthuan_
{
    public partial class Form4 : Form
    {
        decimal workingMemory = 0;
        string opr = "";
        public Form4()
        {
            InitializeComponent();
        }

        private void btn_click(object sender, EventArgs e)
        {
            if ((txtRS.Text == "0"))
                txtRS.Text = "";


            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!txtRS.Text.Contains("."))
                    txtRS.Text = txtRS.Text + num.Text;
            }
            else
                txtRS.Text = txtRS.Text + num.Text;
        }

        private void btnopr_click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if ((char.IsDigit(bt.Text, 0) & bt.Text.Length == 1) || bt.Text == ".")
            {
                txtRS.Text += bt.Text;
            }
            else if (bt.Text == "*" || bt.Text == "+")
            {
                opr = bt.Text;
                workingMemory = decimal.Parse(txtRS.Text);
                txtRS.Clear();
            }
            else if (bt.Text == "=")
            {
                decimal secondval = decimal.Parse(txtRS.Text);
                switch (opr)
                {
                    case "+":
                        {
                            txtRS.Text = (workingMemory + secondval).ToString();
                            break;
                        }
                    case "*":
                        {
                            txtRS.Text = (workingMemory * secondval).ToString();
                            break;
                        }
                }
            }
        }
    }
}
