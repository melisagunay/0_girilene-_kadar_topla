using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8___0_girilene_kadar_topla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int number, topla =  0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            number =  Convert.ToInt32(textBox1.Text);
            if(number != 0)
            {
                topla += number;
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Toplam = " + topla.ToString());
            }

        }
    }
}
