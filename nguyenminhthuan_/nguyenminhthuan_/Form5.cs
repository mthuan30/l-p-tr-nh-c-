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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            txt_Display.Text = "Bạn đã chọn khoa thứ: " + index.ToString();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item = comboBox1.SelectedItem.ToString();
            txt_Display.Text = "Bạn là sinh viên khoa: " + item;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_Display.Clear();
        }
    }
}
