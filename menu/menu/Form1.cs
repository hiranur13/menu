using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dosyaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor= Color.Red;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor=Color.Green;
        }

        private void yazıRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog Renk = new ColorDialog();
            Renk.ShowDialog();
            textBox1.ForeColor = Renk.Color;
            richTextBox1.ForeColor = Renk.Color;

        }

        private void öğrenciKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.ShowDialog();
        }

        private void kİtapEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.ShowDialog();
        }

        private void randevuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Randevu randevu = new Randevu();
            randevu.ShowDialog();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu video studeodan yapılmış bir formdur.");
        }

        private void neİşeYararToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu form Ahmet hocanın isteğiyle yapılmıştır.");
        }


        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog Font = new FontDialog();
            Font.ShowDialog();
            textBox1.Font = Font.Font;
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open=new OpenFileDialog();
            open.Filter = "Dosyalar |*.sln";
            open.Title = "Dosya";
            open.ShowDialog();
        }
    }
}
