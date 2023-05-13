using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC_tema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_CalcIMC(object sender, EventArgs e)
        {
            try
            {
                float greutate;
                float inaltime;
                float IMC;

                greutate = float.Parse(textBox1.Text);
                inaltime = float.Parse(textBox2.Text);
                if (greutate < 0 || inaltime < 0)
                {
                    MessageBox.Show("Introduceti numere pozitive");
                }

                else
                {
                    IMC = greutate / (inaltime * inaltime);
                    textBox3.Text = IMC.ToString();
                    if (IMC < 18.5) { label5.Text = "Subponderal"; }
                    else if (IMC >= 18.5 && IMC < 25) { label5.Text = "Greutate normala"; }
                    else if (IMC >= 25 && IMC < 30) { label5.Text = "Exces de greutate"; }
                    else { label5.Text = "Obez"; }
                }
            }catch (Exception) { MessageBox.Show("Invalid"); }
;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = " ";
            label5.Text = " ";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
