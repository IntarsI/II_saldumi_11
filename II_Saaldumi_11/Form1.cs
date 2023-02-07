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
        double kg1 = 0;
        double kg2 = 0;
        double kg3 = 0;
        double kg4 = 0;
        double kg5 = 0;
        double nauda1 = 0;
        double nauda2 = 0;
        double nauda3 = 0;
        double nauda4 = 0;
        double nauda5 = 0;
        double atlikums;
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
            //cena = (sk2 + sk3 + sk4 + sk5 + sk6) / skaits; 
            //double rezultats = sk1 / cena;//aprekinam rezultatu

            
            kg1 = Convert.ToDouble(textBox1.Text);//definejam ievadito skaitli
                kg2 = Convert.ToDouble(textBox2.Text);//definejam ievadito skaitli
                kg3 = Convert.ToDouble(textBox3.Text);//definejam ievadito skaitli
                kg4 = Convert.ToDouble(textBox4.Text);//definejam ievadito skaitli
                kg5 = Convert.ToDouble(textBox5.Text);//definejam ievadito skaitli
                nauda3 = sk6 * kg5;
                nauda4 = sk5 * kg4;
                nauda5 = sk4 * kg3;
                nauda2 = sk2 * kg2;
                nauda1 = sk3 * kg1;

            atlikums = sk1 - nauda1 - nauda2 - nauda3 - nauda4 - nauda5;
            masaslaukums.Text = atlikums.ToString();//izvadam rezultatu
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
