using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_winform
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DateTime tn = DateTime.Now;
            label6.Text = tn.ToString("dd/MM/yyyy");
            label7.Text = tn.ToString("hh:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text =(DateTime.Now.Hour < 10 ? "0" + DateTime.Now.Hour.ToString() : DateTime.Now.Hour.ToString()) + ":" + (DateTime.Now.Minute < 10 ? "0" + DateTime.Now.Minute.ToString() : DateTime.Now.Minute.ToString()) + ":" + (DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second.ToString() : DateTime.Now.Second.ToString());
        }

        private void hanghoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form1 = new Hanghoa();
            form1.Show();
        }

        private void nhanvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form3 = new Nhanvien();
            form3.Show();
        }

        private void khachhangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form4 = new Khachhang();
            form4.Show();
        }

        private void nhacungcapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form5=new Nhacungcap();
            form5.Show();
        }




      

       





    }
}
