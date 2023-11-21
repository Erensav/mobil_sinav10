using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mobil_sinav2
{
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }        

        public Odeme(List<string> veriler)
        {
            InitializeComponent();
            

            foreach (string veri in veriler)
            {
                listBox1.Items.Add(veri);
            }
        }

        private void Odeme_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            label1.Text = (Form1.toplam.ToString());
            listBox2.Items.Add($"MASA-1 : {Form1.toplam}");
            listBox2.Items.Add($"MASA-2 : {Form1.toplam22}");
            listBox2.Items.Add($"MASA-2 : {Form1.toplam33}");
            listBox2.Items.Add($"MASA-2 : {Form1.toplam44}");
            listBox2.Items.Add($"MASA-2 : {Form1.toplam55}");

            DateTime suankiZaman = DateTime.Now;
            string tarih = suankiZaman.ToShortDateString();
            string saat = suankiZaman.ToShortTimeString();

            label2.Text= "Odeme alinan tarih "+tarih+" - "+ saat;
            listBox1.Items.Clear();
            MessageBox.Show("Odemeniz Basari Ile Alinmistir Tesekkur Ederiz");

        }

    }
}
