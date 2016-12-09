using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "四角形":
                    Box box = new Box();
                    box.width = float.Parse(textBox1.Text.ToString());
                    box.high = float.Parse(textBox2.Text.ToString());
                    label5.Text = box.Periphery().ToString();
                    label6.Text = box.Area().ToString();
                    break;

                case "直角二等辺三角形":
                    Triangle tri = new Triangle();
                    tri.width = float.Parse(textBox1.Text.ToString());
                    tri.high = float.Parse(textBox2.Text.ToString());
                    label5.Text = tri.Periphery().ToString();
                    label6.Text = tri.Area().ToString();
                    break;

                case "円":
                    Circle cir = new Circle();
                    cir.line = float.Parse(textBox1.Text.ToString());
                    label5.Text = cir.Periphery().ToString();
                    label6.Text = cir.Area().ToString();
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.Text)
            {
                case "四角形":
                    label2.Text = "底辺の長さ";
                    label3.Text = "高さ";
                    break;

                case "直角二等辺三角形":
                    label2.Text = "底辺の長さ";
                    label3.Text = "高さ";
                    break;

                case "円":
                    label2.Text = "半径";
                    label3.Text = "未使用";
                    break;
            }
        }
    }
}
