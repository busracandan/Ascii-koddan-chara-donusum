using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                try
                {

                    char deger1 = Convert.ToChar(textBox1.Text); // harften ascıı kod için

                    MessageBox.Show(((int)deger1).ToString()); //değere dönduren kısım

                }

                catch
                {

                    MessageBox.Show("Lütfen harf girişi yapınız !");

                }

            }

            if (radioButton2.Checked)
            {

                try
                {

                    int deger2 = Convert.ToInt32(textBox1.Text); // değerden harfe dönuşum için
                     MessageBox.Show(((char)deger2).ToString()); // karakter dönduren kısım


                }

                catch
                {

                    MessageBox.Show("Lütfen sayı girişi yapınız !");

                }

            }

        }

       // private void radioButton1_CheckedChanged(object sender, EventArgs e)
        //{

            //label1.Text = "ASCII kodtan to Harfe çevirilen harf";

        //}

        //private void radioButton2_CheckedChanged(object sender, EventArgs e)
        //{

            //label1.Text = "Harften ASCII koda çevirilen değer";

        //}

    }

}
