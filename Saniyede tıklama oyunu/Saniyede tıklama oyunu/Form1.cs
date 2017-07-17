using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int sayı = 3;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Tıkla";
            timer1.Enabled = true;
            sayı = 3;
            
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            sayı--;
            label1.Text = sayı.ToString();
            if (sayı == 0)
            {
                timer1.Stop();
                label1.Text = "yenildin";
                button1.Enabled = false;
                button2.Visible = true;
                button1.Text = "yenildin";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            button2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayı = 5;
            button1.Enabled = true;
            button2.Visible = false;
            button1.Text = "Başlat";
        }
    }
}
