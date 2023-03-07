using System;using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
           
           sk1 = Convert.ToDouble(naudaslaukums.Text);
            
            if (textBox1.Text== "")
            { kg1 = 0; }
            else
            {
            kg1 = Convert.ToDouble(textBox1.Text);

            }
            if (textBox2.Text == "")
            { kg2 = 0; }
            else
            {
kg2 = Convert.ToDouble(textBox2.Text);
            }
            if (textBox3.Text == "")
            { kg3 = 0; }
            else
            {
 kg3 = Convert.ToDouble(textBox3.Text);
            }
            if (textBox4.Text == "")
            { kg4 = 0; }
            else
            {
                kg4 = Convert.ToDouble(textBox4.Text);
            }
            if (textBox5.Text == "")
            { kg5 = 0; }
            else
            {
                kg5 = Convert.ToDouble(textBox5.Text);

            }
            double rez = aprekini(sk6, kg5, nauda3);
            double rez1 = aprekini1(sk5, kg4, nauda4);
            double rez2 = aprekini2(sk4, kg3, nauda5);
            double rez3 = aprekini3(sk2, kg2, nauda2);
            double rez4 = aprekini4(sk3, kg1, nauda1);
            textBox6.Text = rez4.ToString();
            textBox7.Text = rez3.ToString();
            textBox8.Text = rez2.ToString();
            textBox9.Text = rez1.ToString();
            textBox10.Text = rez.ToString();
            atlikums = sk1 - rez4 - rez3 - rez - rez1 - rez2;
            if (atlikums < 0)
            {
                MessageBox.Show("Par maz naudas");
            }
            masaslaukums.Text = atlikums.ToString();//izvadam rezultatu
           string vards = textBox11.Text;
          string nosaukums = vards + "_" + DateTime.Now.ToString("ddMMyyyy") + "_ceks.txt";
StreamWriter faila_rakstitajs = new StreamWriter (nosaukums);
            faila_rakstitajs.WriteLine("Iedots ");
            faila_rakstitajs.WriteLine(sk1);
            if (rez != 0)
            {
    faila_rakstitajs.WriteLine("Likiera konfektes Pergale " + kg5 + "kg");
            faila_rakstitajs.WriteLine(rez + "Eur");

            }
        if(rez1 != 0)
            {             faila_rakstitajs.WriteLine("Rudzupuke " + kg4 + "kg");
            faila_rakstitajs.WriteLine(rez1 + "Eur");

            }
            if (rez2 != 0)
            {
 faila_rakstitajs.WriteLine("Barbele " + kg3 + "kg");
            faila_rakstitajs.WriteLine(rez2 + "Eur");
            }
            if (rez3 != 0)
            {
 faila_rakstitajs.WriteLine("Serenade " + kg2 + "kg");
            faila_rakstitajs.WriteLine(rez3 + "Eur");

            }
            if (rez4 != 0)
            {
 faila_rakstitajs.WriteLine("Vesma " + kg1 + "kg");
            faila_rakstitajs.WriteLine(rez4 + "Eur");

            }


               
            faila_rakstitajs.WriteLine("Izdots ");
            faila_rakstitajs.WriteLine(atlikums + "Eur");
            faila_rakstitajs.Close();

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

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
         
        }
       static double  aprekini(double sk6, double kg5, double nauda3)
        {
            nauda3 = sk6 * kg5;
            return nauda3;
             
        }
        static double aprekini1(double sk5, double kg4, double nauda4)
        {
            nauda4 = sk5 * kg4;
            return nauda4;

        }
        static double aprekini2(double sk4, double kg3, double nauda5)
        {
            nauda5 = sk4 * kg3;
            return nauda5;

        }
        static double aprekini3(double sk2, double kg2, double nauda2)
        {
            nauda2 = sk2 * kg2;
            return nauda2;

        }
        static double aprekini4(double sk3, double kg1, double nauda1)
        {
            nauda1 = sk3 * kg1;
            return nauda1;

        }
    }
}
