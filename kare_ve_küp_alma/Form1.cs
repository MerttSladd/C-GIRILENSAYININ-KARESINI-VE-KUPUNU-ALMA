using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kare_ve_küp_alma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi, küp, kare;
            sayi = Convert.ToInt32(textBox1.Text);

            if (comboBox1.SelectedIndex == 0)
            {
                küp = sayi * sayi * sayi;
                listBox1.Items.Add(küp);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                kare = sayi * sayi;
                listBox1.Items.Add(kare);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("küp");
            comboBox1.Items.Add("kare");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
