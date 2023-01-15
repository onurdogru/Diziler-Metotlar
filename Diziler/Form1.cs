using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Metotla ilgili bilgiler (Küp veren soru)
        //Metotumuz aşağıdadır #1
        int Kup (int sayi)
        {
            int sonuc = sayi * sayi * sayi;
            return sonuc;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //sytax yapısı : değişkentürü [] diziadı = {};

            string[] kisiler = { "Ali", "Ahmet", "Mehmet", "Aslı", "Ayşe", "Demet", "Hakan" };
            label1.Text = kisiler[4];


            int[] sayilar = { 4, 5, 6, 7, 8, 9, 10, 11, 12, 15, 25, 18 };
            label2.Text = sayilar[5].ToString();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            string[] sehirler = { "Ankara", "İstanbul", "İzmir", "Antalya" };

            for (int i=0; i< sehirler.Length; i++) //şehirler dizisinin sonuna kadar anlamındadır lenght
            {
                listBox1.Items.Add(sehirler[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SADECE ÇİFT SAYILARI EKLEME
            int[] sayilar2 = { 4, 2, 3, 1, 5, 6, 7, 9 };

            for (int i=0; i< sayilar2.Length; i++)
            {
                if (sayilar2[i] % 2 == 0)
                {
                    listBox2.Items.Add(sayilar2[i]);
                }
                
            }
        }


        //Metot #2
        private void button4_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt16(textBox1.Text);
            label3.Text = Kup(s).ToString();

        }
    }
}
