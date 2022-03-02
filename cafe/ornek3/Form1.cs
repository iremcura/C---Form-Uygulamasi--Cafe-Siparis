using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void cayArtiButon_Click(object sender, EventArgs e)
        {
            
            int caySayisi = Convert.ToInt32(caySayisiLabel.Text);
            caySayisi++; 
            caySayisiLabel.Text = Convert.ToString(caySayisi); 
        }

        private void cayEksiButon_Click(object sender, EventArgs e)
        {
            int caySayisi = Convert.ToInt32(caySayisiLabel.Text); 

            if (caySayisi > 0) 
            {
                caySayisi--;
                caySayisiLabel.Text = Convert.ToString(caySayisi);

            }
        }

        private void kahveArtiButon_Click(object sender, EventArgs e)
        {
            int kahveSayisi = Convert.ToInt32(kahveSayisiLabel.Text);
            kahveSayisi++; 
            kahveSayisiLabel.Text = Convert.ToString(kahveSayisi);

        }

        private void kahveEksiButon_Click(object sender, EventArgs e)
        {
            int kahveSayisi = Convert.ToInt32(kahveSayisiLabel.Text); 
           
            if (kahveSayisi > 0)
            {
                kahveSayisi--; 
                kahveSayisiLabel.Text = Convert.ToString(kahveSayisi);

            }
        }

        private void kolaArtiButon_Click(object sender, EventArgs e)
        {
            int kolaSayisi = Convert.ToInt32(kolaSayisiLabel.Text); 
            kolaSayisi++; 
            kolaSayisiLabel.Text = Convert.ToString(kolaSayisi);

        }

        private void kolaEksiButon_Click(object sender, EventArgs e)
        {
            int kolaSayisi = Convert.ToInt32(kolaSayisiLabel.Text); 
            
            if (kolaSayisi > 0)
            {

                kolaSayisi--; 
                kolaSayisiLabel.Text = Convert.ToString(kolaSayisi);

            }
        }

        private void sifirlaButon_Click(object sender, EventArgs e)
        {
           
            caySayisiLabel.Text = "0"; 
            kahveSayisiLabel.Text = "0";
            kolaSayisiLabel.Text = "0";

        }

        private void siparisiTamamlaButon_Click(object sender, EventArgs e)
        { 
            
            MessageBox.Show("SİPARİŞ ÖZETİ:"  +  caySayisiLabel.Text +   "ÇAY,"   +    kahveSayisiLabel.Text   +   "KAHVE,"   +   kolaSayisiLabel.Text   +   "KOLA");

        }

        private void cikisButon_Click(object sender, EventArgs e)
        {
            
            Close(); 

        }
    }
}
