using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int OrtalamaBul(TextBox sinav1, TextBox sinav2, TextBox sinav3, TextBox sozlu1, TextBox sozlu2)
        {
            int ortMat = 0;

            try
            {
                int snv1 = int.Parse(sinav1.Text);
                int snv2 = int.Parse(sinav2.Text);
                int snv3 = int.Parse(sinav3.Text);
                int soz1 = int.Parse(sozlu1.Text);
                int soz2 = int.Parse(sozlu2.Text);

                if ((snv1 <= 100 && snv1 >= 0) && (snv2 <= 100 && snv2 >= 0) && (snv3 <= 100 && snv3 >= 0) && (soz1 <= 100 && soz1 >= 0) && (soz2 <= 100 && soz2 >= 0))
                {
                    ortMat = (snv1 + snv2 + snv3 + soz1 + soz2) / 5;
                }
                else
                {
                    MessageBox.Show("notları 0-100 aralığında giriniz..");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı giriş");
                //textBox1.Clear();
                //textBox2.Clear();
                //textBox3.Clear();
                //textBox4.Clear();
                //textBox5.Clear();
                //textBox6.Clear();
            }

            return ortMat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox6.Text = OrtalamaBul(textBox1, textBox2, textBox3, textBox4, textBox5).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int snv1 = int.Parse(textBox7.Text);
                int snv2 = int.Parse(textBox8.Text);
                int snv3 = int.Parse(textBox9.Text);
                int soz1 = int.Parse(textBox10.Text);
                int soz2 = int.Parse(textBox11.Text);

                int ortMat = 0;

                if ((snv1 <= 100 && snv1 >= 0) && (snv2 <= 100 && snv2 >= 0) && (snv3 <= 100 && snv3 >= 0) && (soz1 <= 100 && soz1 >= 0) && (soz2 <= 100 && soz2 >= 0))
                {
                    ortMat = (snv1 + snv2 + snv3 + soz1 + soz2) / 5;
                }
                else
                {
                    MessageBox.Show("notları 0-100 aralığında giriniz..");
                }

                textBox12.Text = ortMat.ToString();


            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı giriş");
                //textBox7.Clear();
                //textBox8.Clear();
                //textBox9.Clear();
                //textBox10.Clear();
                //textBox11.Clear();
                //textBox12.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int not1 = int.Parse(textBox6.Text);
            int not2 = int.Parse(textBox12.Text);
            int not3 = int.Parse(textBox19.Text);
            int not4 = int.Parse(textBox13.Text);

            textBox25.Text = ((not1 + not2 + not3 + not4) / 4).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
