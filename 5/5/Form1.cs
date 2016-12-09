using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calc x = new Calc();

            x.X = float.Parse(textBox1.Text);
            x.Y = float.Parse(textBox2.Text);
            switch(comboBox1.Text)
            {
                case "+":
                    label2.Text = x.add().ToString();
                    break;
                case "-":
                    label2.Text = x.Pull().ToString();;
                    break;
                case "*":
                    label2.Text = x.Mult().ToString();
                    break;
                case "/":
                    label2.Text = x.Div().ToString();
                    break;
                default:
                    label2.Text = "演算子を選択してください";
                    break;
            }
            
        }
    }
}
