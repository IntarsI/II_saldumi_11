using System;
using System.Collections.Generic;
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
    {
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
            double sk1 = Convert.ToDouble(naudaslaukums.Text);
            double sk2 = 9.88;
            double rezultats = sk1 / sk2;
            masaslaukums.Text = rezultats.ToString();
        }
    }
}
