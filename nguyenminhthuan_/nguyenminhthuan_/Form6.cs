using System;
using System.Collections;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
private void Form6_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            comboBox1.DataSource = lst;
            comboBox1.DisplayMember = "name";
        }
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();
            Faculty f = new Faculty();
            f.id = "K01";
            f.name = "Công nghệ thông tin";
            f.quanlity = 1200;
            lst.Add(f);

            f = new Faculty();
            f.id = "K02";
            f.name = "Quản trị kinh doanh";
            f.quanlity = 4200;
            lst.Add(f);

            f = new Faculty();
            f.id = "K03";
            f.name = "Kế toán tài chính";
            f.quanlity = 5200;
            lst.Add(f);
            return lst;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.ValueMember = "name";
            string name = comboBox1.SelectedValue.ToString();
            txt_Display.Text = "Bạn đã chọn khoa có tên: " + name;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.ValueMember = "id";
            string id = comboBox1.SelectedValue.ToString();
            txt_Display.Text = "Bạn đã chọn khoa có mã: " + id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_Display.Clear();
        }
    }
    public class Faculty {
    public string id { get; set; }
        public string name { get; set; }
        public int quanlity { get; set; }
    }
}
