using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace nguyenminhthuan_
{
    public partial class Form2 : Form
    {   
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_cong_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txt_x.Text);
            int y = int.Parse(txt_y.Text);
            int kq = x + y;
            txt_ketqua.Text += x.ToString() + "+" + y.ToString() + "=" + kq.ToString() + "\r\n";
        }

        private void btn_nhan_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txt_x.Text);
            int y = int.Parse(txt_y.Text);
            int kq = x * y;
            txt_ketqua.Text += x.ToString() + "*"+y.ToString() +"="+ kq.ToString() + "\r\n";
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("C:/Users/HP/Desktop/nguyenminhthuan_/Calculator.txt", true);
            sw.Write(txt_ketqua.Text);
            sw.Close();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
          
        }
    }
}
