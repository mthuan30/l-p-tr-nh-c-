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
    public partial class Form3 : Form
    {
        decimal memory = 0;
        decimal workingMemory = 0;
        string opr = "";
        string result ="";
        
        public Form3()
        {
            InitializeComponent();
        }

      

        private void btn_click(object sender, EventArgs e)
        {
            if ((txtRS.Text == "0"))
            {
                txtRS.Text = "";
                result = "";
                
            }
            

            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!txtRS.Text.Contains("."))
                {
                    txtRS.Text = txtRS.Text + num.Text;
                    result = result + num.Text;

                }
            }
            else
            {
                txtRS.Text = txtRS.Text + num.Text;
                result = result + num.Text;

            }
        }

        private void btndoidau_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtRS.Text) * (-1);
            txtRS.Text = System.Convert.ToString(a);
            result = txtRS.Text;
        }

        private void btn_oprclick(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if((char.IsDigit(bt.Text,0)& bt.Text.Length == 1) || bt.Text == ".")
            {
                txtRS.Text += bt.Text;
                result += bt.Text;
            }
            else if (bt.Text == "*" || bt.Text == "/" || bt.Text == "+" || bt.Text == "-")
            {
                opr = bt.Text;
                txtRS.Text += bt.Text;
                workingMemory = decimal.Parse(result);
                result = "";
            }
            else if (bt.Text == "=")
            {
                
                
                decimal secondval = decimal.Parse(result);
                switch (opr)
                {
                    case "+":
                        {
                            
                            txtRS.Text = (workingMemory + secondval).ToString();
                            result = txtRS.Text;
                            break;
                        }
                    case "-":
                        {
                            txtRS.Text = (workingMemory - secondval).ToString();
                            result = txtRS.Text;
                            break;
                        }
                    case "*":
                        {
                            txtRS.Text = (workingMemory * secondval).ToString();
                            break;
                        }
                    case "/":
                        {
                            txtRS.Text = (workingMemory / secondval).ToString();
                            result = txtRS.Text;
                            break;
                        }
                }
            }
            else if(bt.Text== "√")
            {
                decimal currval = decimal.Parse(txtRS.Text);
                currval = (decimal)Math.Sqrt((double)currval);
                txtRS.Text = currval.ToString();
                result = txtRS.Text;
            }
            else if (bt.Text == "%")
            {
                decimal currval = decimal.Parse(txtRS.Text);
                currval = currval / 100;
                txtRS.Text = currval.ToString();
                result = txtRS.Text;
            }
            else if (bt.Text == "1/x")
            {
                decimal currval = decimal.Parse(txtRS.Text);
                currval = 1/currval;
                txtRS.Text = currval.ToString();
                result = txtRS.Text;
            }
            else if (bt.Text == "backspace")
            {
                if (txtRS.TextLength != 0)
                {
                    txtRS.Text = txtRS.Text.Remove(txtRS.TextLength - 1);
                    result = txtRS.Text;
                }
            }
            else if (bt.Text == "MC")
            {
                memory = 0;
            }
            else if (bt.Text == "MR")
            {
                txtRS.Text = memory.ToString();
                result = txtRS.Text;
            }
            else if (bt.Text == "MS")
            {
                memory = decimal.Parse(txtRS.Text);
                txtRS.Clear();
            }
            else if (bt.Text == "M+")
            {
                memory += decimal.Parse(txtRS.Text);
            }
            else if (bt.Text == "M-")
            {
                memory -= decimal.Parse(txtRS.Text);
            }
            else if (bt.Text == "C")
            {
                workingMemory = 0;
                opr = "";
                txtRS.Clear();
                result = txtRS.Text;
            }
            else if (bt.Text == "CE")
            {   
                txtRS.Clear();
                result = txtRS.Text;
            }
        }

        private void txtRS_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
