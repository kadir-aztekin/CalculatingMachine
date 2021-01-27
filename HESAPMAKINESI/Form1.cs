using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HESAPMAKINESI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hosgeldiniz ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı1 = 0, sayı2 = 0, sonuc = 0;
            Console.WriteLine("Bir sayı giriniz:");
            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayı1 + sayı2;
            label4.Text = Convert.ToString(sonuc);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayı1 = 0, sayı2 = 0, sonuc = 0;
            Console.WriteLine("Bir sayı giriniz:");
            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayı1 - sayı2;
            label4.Text = Convert.ToString(sonuc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayı1 = 0, sayı2 = 0, sonuc = 0;
            Console.WriteLine("Bir sayı giriniz:");
            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayı1 * sayı2;
            label4.Text = Convert.ToString(sonuc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayı1 = 0, sayı2 = 0, sonuc = 0;
            Console.WriteLine("Bir sayı giriniz:");
            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayı1 / sayı2;
            label4.Text = Convert.ToString(sonuc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Görüsmek Üzere ");
            this.Close();

        }
    }
}
