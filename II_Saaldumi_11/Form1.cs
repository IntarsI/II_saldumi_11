using System;using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace II_Saaldumi_11
{
    public partial class Form1 : Form
    { double sk1;
        double sk2=0;
        double sk3=0;
        double sk4=0;
        double sk5=0;
        double sk6=0;
        int skaits=0;
        double cena;
        public Form1()
        {
            InitializeComponent();
        }

        private void naudaslaukums_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void masaslaukums_TextChanged(object sender, EventArgs e)
        {

        }

        private void poga_Click(object sender, EventArgs e)
        {
           
           sk1 = Convert.ToDouble(naudaslaukums.Text);//definejam ievadito skaitli
            cena = (sk2 + sk3 + sk4 + sk5 + sk6) / skaits; 
            double rezultats = sk1 / cena;//aprekinam rezultatu
            masaslaukums.Text = rezultats.ToString();//izvadam rezultatu
        }

        private void Nosaukums_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                sk2 = 15.49;
                skaits = skaits + 1;
            }

        }

        private void Vesma_CheckedChanged(object sender, EventArgs e)
        {
            if (Vesma.Checked == true)
            {
                sk3 = 7.56;
                skaits = skaits + 1;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                sk6 = 21.69;
                skaits = skaits + 1;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                sk5 = 14.99;
                skaits = skaits + 1;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                sk4 = 5.76;
                skaits = skaits + 1;
            }
        }
    }
}
