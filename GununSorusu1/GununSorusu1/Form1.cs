using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GununSorusu1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 
        
        int sayi=0;
        private void Form1_Load(object sender, EventArgs e)
        {
            //sayi = Int32.Parse(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            //sayi = sayi + 1;
            //textBox1.Text = sayi.ToString();
            button1.ForeColor = Color.Violet;

           
            tıklama(textBox1);
                    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sayi = sayi - 1;
            //textBox2.Text = sayi.ToString();
            button2.ForeColor = Color.DarkBlue;


            tıklamaıkı(textBox2);

        }
        public void tıklama(TextBox t1)
        {

            sayi = sayi + 1;
            t1.Text = sayi.ToString();
 
        }
        public void tıklamaıkı(TextBox t2)
        {
            sayi = sayi - 1;
            t2.Text = sayi.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayi = 0;
            textBox1.Text = sayi.ToString();
            textBox2.Text = sayi.ToString();
            button4.ForeColor = Color.Green;
        }


        
    }
}
