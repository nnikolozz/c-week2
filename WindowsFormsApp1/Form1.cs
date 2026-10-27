using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double k, x, y;

      
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            x=double.Parse(textBox3.Text);
            if (comboBox1.SelectedItem.ToString() == "USD")
            {
                k = x / 2.7;
                label2.Text = k.ToString();
            }
            else if (comboBox1.SelectedItem.ToString() == "EU") 
            { 
            label2.Text= (x/2.9).ToString();
            }
            else if (comboBox1.SelectedItem.ToString() == "TYR")
            {
                label2.Text = (x / 0.04).ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double.TryParse(textBox3.Text, out x);
            if (comboBox1.SelectedItem.ToString() == "USD")
            {
                k = x / 2.7;
                label2.Text = k.ToString();
            }
            else if (comboBox1.SelectedItem.ToString() == "EU")
            {
                label2.Text = (x / 2.9).ToString();
            }
            else if (comboBox1.SelectedItem.ToString() == "TYR")
            {
                label2.Text = (x / 0.04).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox3.Text, out x);
            string cb1=comboBox1.SelectedItem.ToString();
            string cb2 = comboBox2.SelectedItem.ToString();
            if (cb1 == "GEL") 
            {
                if (cb2 == "USD")
                {
                    label2.Text = (x / 2.7).ToString();
                }
                else if (cb2 == "EU")
                {
                    label2.Text = (x / 3.1).ToString();
                }
                else if (cb2 == "TYR")
                {
                    label2.Text = (x / 0.04).ToString();
                }
                else
                {
                    label2.Text =x.ToString();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (comboBox3.SelectedItem.ToString() == "samkutxedi")
                {
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                }
                else if (comboBox3.SelectedItem.ToString() == "wre") 
                {
                    textBox4.Visible = true;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                }
                else 
                {
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = false;
                }
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                if (comboBox3.SelectedItem.ToString() == "samkutxedi")
                {
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = false;
                }
                else if (comboBox3.SelectedItem.ToString() == "wre")
                {
                    textBox4.Visible = true;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                }
                else
                {
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = false;
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            radioButton1.Checked=false;
            radioButton2.Checked=false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem.ToString() == "samkutxedi" && radioButton1.Checked)
            {
                double.TryParse(textBox4.Text, out k);
                double.TryParse(textBox5.Text, out x);
                double.TryParse(textBox6.Text, out y);
                label3.Text = (k + x + y).ToString();

            }
            else if (comboBox3.SelectedItem.ToString() == "samkutxedi" && radioButton2.Checked)
            {
                double.TryParse(textBox4.Text, out k);
                double.TryParse(textBox5.Text, out x);

                label3.Text = ((k * x) / 2).ToString();

            }
            else if (comboBox3.SelectedItem.ToString() == "wre" && radioButton1.Checked)
            {
                double.TryParse(textBox4.Text, out k);


                label3.Text = (2 * k * Math.PI).ToString();

            }
            else if (comboBox3.SelectedItem.ToString() == "wre" && radioButton2.Checked)
            {
                double.TryParse(textBox4.Text, out k);


                label3.Text = (Math.Pow(k, 2) * Math.PI).ToString();
            }
            else if (comboBox3.SelectedItem.ToString() == "martkutxedi" && radioButton1.Checked)
            {
                double.TryParse(textBox4.Text, out k);
                double.TryParse(textBox5.Text, out x);

                label3.Text = (2*(k+x)).ToString();

            }
            else if (comboBox3.SelectedItem.ToString() == "martkutxedi" && radioButton2.Checked)
            {
                double.TryParse(textBox4.Text, out k);
                double.TryParse(textBox5.Text, out x);

                label3.Text = (k * x).ToString();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            x=double.Parse(textBox1.Text);
            double.TryParse(textBox2.Text, out y);
            if (y > 0 && x - y > 0 && 2 * y - 5 * x != 0 && x * y / (2 * y - 5 * x) >= 0)
            {
                k = (Math.Pow(x, 2) + Math.Pow(y, 1.0 / 4)) / Math.Sqrt(x - y) + Math.Sqrt(x * y / (2 * y - 5 * x));
                label1.Text = k.ToString();
            }
            else
            {
                MessageBox.Show("ragac");
            }
        }
    }
}
