using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Arttirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi;

        private void Form1_Load(object sender, EventArgs e)
        {
            sayi = Int32.Parse(textBox1.Text);
        }
        //parametre olarak textbox nesnesi alan bir metodun tanımlanması:
        //public void Deneme(TextBox t1)
        //{ }
        public void ArttirmaMetodu(TextBox t1)
        {
            sayi = sayi + 1;
            t1.Text = sayi.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ArttirmaMetodu(textBox1);
        }

        public void AzaltmaMetodu(TextBox t1)
        {
            sayi = sayi - 1;
            t1.Text = sayi.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AzaltmaMetodu(textBox1);
            //parametre olarak textbox alan bir metodun çağırılması:
            //Deneme(textBox1);
            button2.ForeColor = Color.Red;
        }
        public void SifirlamaMetodu(TextBox t1)
        {
            sayi = 0;
            t1.Text = sayi.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SifirlamaMetodu(textBox1);
        }

        public void KapatmaMetodu()
        {
            //Close(); bu formu kapatır.....
            Application.Exit(); //bu programı komple kapatır....
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            KapatmaMetodu();
        }

       
    }
}
