using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Odev_3
{
    public partial class Ortalama_Tablosu : Form
    {
        public Ortalama_Tablosu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public int KısaYol(TextBox t1,TextBox t6,TextBox t11,TextBox t16,TextBox t21)
        {
            int ortayol =0;
            textBox27.Text = ortayol.ToString();
            try
            {
                int yazılı1 = Int32.Parse(t1.Text);
                int yazılı2 = Int32.Parse(t6.Text);
                int yazılı3 = Int32.Parse(t11.Text);
                int sozlu1 = Int32.Parse(t16.Text);
                int sozlu2 = Int32.Parse(t21.Text);

                ortayol =((yazılı1 + yazılı2 + yazılı3 + sozlu1 + sozlu2) / 5);
            }
            catch (Exception hata1)
            {
                MessageBox.Show("HATALI  İŞLEM ");
                MessageBox.Show(hata1.Message);
            }
            return ortayol;
        }
        private void Hesaplama_Bır_Click(object sender, EventArgs e)
        {
            textBox27.Text = KısaYol(textBox1, textBox6, textBox11, textBox16, textBox21).ToString();
        }

        //-------------------------------------------------------------------------------------------

        public int KısaYol2(TextBox t2, TextBox t7, TextBox t12, TextBox t17, TextBox t22)
        {
            int ortayol = 0;
            textBox28.Text = ortayol.ToString();
            try
            {
                int yazılı1 = Int32.Parse(t2.Text);
                int yazılı2 = Int32.Parse(t7.Text);
                int yazılı3 = Int32.Parse(t12.Text);
                int sozlu1 = Int32.Parse(t17.Text);
                int sozlu2 = Int32.Parse(t22.Text);

                ortayol = ((yazılı1 + yazılı2 + yazılı3 + sozlu1 + sozlu2) / 5);
            }
            catch (Exception hata1)
            {
                MessageBox.Show("HATALI  İŞLEM ");
                MessageBox.Show(hata1.Message);
            }
            return ortayol;
         }
        private void Hesaplama_Ikı_Click(object sender, EventArgs e)
        {
            textBox28.Text = KısaYol2(textBox2, textBox7, textBox12, textBox17, textBox22).ToString();
        }

        //--------------------------------------------------------------------------------------------

        public int KısaYol3(TextBox t3, TextBox t8, TextBox t13, TextBox t18, TextBox t23)
        {
            int ortayol = 0;
            textBox29.Text = ortayol.ToString();
            try
            {
                int yazılı1 = Int32.Parse(t3.Text);
                int yazılı2 = Int32.Parse(t8.Text);
                int yazılı3 = Int32.Parse(t13.Text);
                int sozlu1 = Int32.Parse(t18.Text);
                int sozlu2 = Int32.Parse(t23.Text);

                ortayol = ((yazılı1 + yazılı2 + yazılı3 + sozlu1 + sozlu2) / 5);
            }
            catch (Exception hata1)
            {
                MessageBox.Show("HATALI İŞLEM ");
                MessageBox.Show(hata1.Message);
            }
            return ortayol;
        }
        private void Hesaplama_uc_Click(object sender, EventArgs e)
        {
            textBox29.Text = KısaYol3(textBox3, textBox8, textBox13, textBox18, textBox23).ToString();
        }

        //--------------------------------------------------------------------------------------------

        public int KısaYol4(TextBox t4, TextBox t9, TextBox t14, TextBox t19, TextBox t24)
        {
            int ortayol = 0;
            textBox30.Text = ortayol.ToString();
            try
            {
                int yazılı1 = Int32.Parse(t4.Text);
                int yazılı2 = Int32.Parse(t9.Text);
                int yazılı3 = Int32.Parse(t14.Text);
                int sozlu1 = Int32.Parse(t19.Text);
                int sozlu2 = Int32.Parse(t24.Text);

                ortayol = ((yazılı1 + yazılı2 + yazılı3 + sozlu1 + sozlu2) / 5);

            }
            catch (Exception hata1)
            {
                MessageBox.Show("HATALI İŞLEM ");
                MessageBox.Show(hata1.Message);
            }
            return ortayol;
        }
        private void Hesaplama_Dort_Click(object sender, EventArgs e)
        {
            textBox30.Text = KısaYol4(textBox4, textBox9, textBox14, textBox19, textBox24).ToString();
        }

        //--------------------------------------------------------------------------------------------

        public int KısaYol5(TextBox t5, TextBox t10, TextBox t15, TextBox t20, TextBox t25)
        {
            int ortayol = 0;
            textBox31.Text = ortayol.ToString();
            try
            {
                int yazılı1 = Int32.Parse(t5.Text);
                int yazılı2 = Int32.Parse(t10.Text);
                int yazılı3 = Int32.Parse(t15.Text);
                int sozlu1 = Int32.Parse(t20.Text);
                int sozlu2 = Int32.Parse(t25.Text);

                ortayol = ((yazılı1 + yazılı2 + yazılı3 + sozlu1 + sozlu2) / 5);
            }
            catch (Exception hata1)
            {
                MessageBox.Show("HATALI İŞLEM ");
                MessageBox.Show(hata1.Message);
            }
            return ortayol;
        }
        private void Hesaplama_Bes_Click(object sender, EventArgs e)
        {
            textBox31.Text = KısaYol5(textBox5, textBox10, textBox15, textBox20, textBox25).ToString();
        }

        //---------------------------------------------------------------------------------------------

        public int OrtBulma(TextBox t27, TextBox t28, TextBox t29, TextBox t30, TextBox t31)
        {
            int ortayol = 0;
            textBox26.Text = ortayol.ToString();
            try
            {
                int ort1 = Int32.Parse(t27.Text);
                int ort2 = Int32.Parse(t28.Text);
                int ort3 = Int32.Parse(t29.Text);
                int ort4 = Int32.Parse(t30.Text);
                int ort5 = Int32.Parse(t31.Text);

                int ortsonuc;
                textBox26.Text = ((ort1 + ort2 + ort3 + ort4 + ort5) / 5).ToString();
                ortsonuc = Int32.Parse(textBox26.Text);

                if ((ortsonuc >= 0) && (ortsonuc <= 24))
                {
                    textBox26.Text = ortsonuc + "(0)";
                }
                else if ((ortsonuc >= 25) && (ortsonuc <= 44))
                {
                    textBox26.Text = ortsonuc + "(1)";
                }
                else if ((ortsonuc >= 45) && (ortsonuc <= 54))
                {
                    textBox26.Text = ortsonuc + "(2)";
                }
                else if ((ortsonuc >= 55) && (ortsonuc <= 69))
                {
                    textBox26.Text = ortsonuc + "(3)";
                }
                else if ((ortsonuc >= 70) && (ortsonuc <= 84))
                {
                    textBox26.Text = ortsonuc + "(4)";
                }
                else if ((ortsonuc >= 85) && (ortsonuc <= 100))
                {
                    textBox26.Text = ortsonuc + "(5)";
                }
            }
            catch (Exception hata1)
            {
                MessageBox.Show("HATALI İŞLEM ");
                MessageBox.Show(hata1.Message);
            }
            finally
            {
                MessageBox.Show(" İYİ  DERSLER  =)");
            }
            return ortayol;
         }
        private void Ortalama_Hesaplama_Click(object sender, EventArgs e)
        {
            textBox26.Text = OrtBulma(textBox27, textBox28, textBox29, textBox30, textBox31).ToString();            
        }


        //---------------------------------------------SON----------------------------------------------

               
	         
	         
	         
		 
	         
            
            
         


        }

        

        
    }
}
