using Application_Nesnesi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Application_Nesnesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void çıkarken(object sender, EventArgs e)
        {
            MessageBox.Show("Programdan çıkılıyor");
        }

        int x = 0;
        private void boşta(object sender, EventArgs e)
        {
            label8.Text = x.ToString();
            x++;
        }

        private void hata(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message.ToString());
            //MessageBox.Show("Hata oluştu");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i;
            Form2 frm2 = new Form2();
            Form3 frm3 = new Form3();
            Form4 frm4 = new Form4();

            //frm2.Show();
            //frm3.Show();
            //frm4.Show();

            label1.Text = Application.StartupPath;
            label2.Text = Application.ExecutablePath;

            label3.Text = Application.ProductName;
            label4.Text = Application.ProductVersion;

            label5.Text = Application.CommonAppDataPath;
            label6.Text = Application.UserAppDataPath;
            label7.Text = Application.UserAppDataRegistry.ToString();

            Application.ApplicationExit += new EventHandler(çıkarken);
            Application.Idle += new EventHandler(boşta);
            Application.ThreadException += new ThreadExceptionEventHandler(hata);

            for (i = 0; i < Application.OpenForms.Count; i++)
                listBox1.Items.Add(Application.OpenForms[i].Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            long y;
            for (y = 0; y < 10000000000; y++) ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.UseWaitCursor = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.UseWaitCursor = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Form1 kapatılıyor");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Form1 kapatıldı");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text));
        }
    }
}


