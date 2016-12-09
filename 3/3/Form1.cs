using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        int kotae;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            label1.Text = rnd.Next(100).ToString();

            label3.Text = rnd.Next(100).ToString();

            switch (rnd.Next(3))
            {
                case 0:
                    label2.Text = "+";
                    kotae = (Convert.ToInt32(label1.Text)) + (Convert.ToInt32(label3.Text));
                    break;

                case 1:
                    label2.Text = "-";
                    kotae = (Convert.ToInt32(label1.Text)) - (Convert.ToInt32(label3.Text));
                    break;

                case 2:
                    label2.Text = "*";
                    kotae = (Convert.ToInt32(label1.Text)) * (Convert.ToInt32(label3.Text));
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(textBox1.Text) == kotae)
            {
                label5.Text = "正解";
            }
            else
            {
                label5.Text = "不正解";
            }
        }
    }
}
