using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiocoTris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Image Cerchio = Image.FromFile(@"immagine/cerchio.png");//nomina cerchio in cui riprendo il file .png
        Image Croce = Image.FromFile(@"immagine/croce.png");//nomina croce in cui riprendo il file .png
        int giocatore = 0;

        private void btinizia_Click(object sender, EventArgs e)
        {//azzeramento
            cambia();
            pictureBox10.BackgroundImage = null;
            pictureBox2.BackgroundImage = null;
            pictureBox3.BackgroundImage = null;
            pictureBox4.BackgroundImage = null;
            pictureBox5.BackgroundImage = null;
            pictureBox6.BackgroundImage = null;
            pictureBox7.BackgroundImage = null;
            pictureBox8.BackgroundImage = null;
            pictureBox9.BackgroundImage = null;
            pictureBox10.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
        }
        private void cambia()//cambio giocatore
        {
            giocatore++;
            if (giocatore == 3) giocatore = 1;
            lbgiocatore.Text = "Giocatore " + giocatore.ToString();
        }
        private void controllo()
        {
            //se il cerchio vince orizzontale
            if(pictureBox5.BackgroundImage == Cerchio && pictureBox2.BackgroundImage == Cerchio && pictureBox8.BackgroundImage == Cerchio)
            {
                MessageBox.Show("Ha vinto il cerchio");
            }
            else if(pictureBox3.BackgroundImage == Cerchio && pictureBox6.BackgroundImage == Cerchio && pictureBox9.BackgroundImage == Cerchio)
            {
                MessageBox.Show("Ha vinto il cerchio");
            }
            else if (pictureBox4.BackgroundImage == Cerchio && pictureBox7.BackgroundImage == Cerchio && pictureBox10.BackgroundImage == Cerchio)
            {
                MessageBox.Show("Ha vinto il cerchio");
            }
            //se il cerchio vince verticale
            else if (pictureBox2.BackgroundImage == Cerchio && pictureBox3.BackgroundImage == Cerchio && pictureBox4.BackgroundImage == Cerchio)
            {
                MessageBox.Show("Ha vinto il cerchio");
            }
            else if (pictureBox5.BackgroundImage == Cerchio && pictureBox6.BackgroundImage == Cerchio && pictureBox7.BackgroundImage == Cerchio)
            {
                MessageBox.Show("Ha vinto il cerchio");
            }
            else if (pictureBox8.BackgroundImage == Cerchio && pictureBox9.BackgroundImage == Cerchio && pictureBox10.BackgroundImage == Cerchio)
            {
                MessageBox.Show("Ha vinto il cerchio");
            }
            //se il cerchio vince obliquo
            else if (pictureBox2.BackgroundImage == Cerchio && pictureBox6.BackgroundImage == Cerchio && pictureBox10.BackgroundImage == Cerchio)
            {
                MessageBox.Show("Ha vinto il cerchio");
            }
            else if (pictureBox4.BackgroundImage == Cerchio && pictureBox6.BackgroundImage == Cerchio && pictureBox8.BackgroundImage == Cerchio)
            {
                MessageBox.Show("Ha vinto il cerchio");
            }
            //se il croce vince orizzontale
            if (pictureBox5.BackgroundImage == Croce && pictureBox2.BackgroundImage == Croce && pictureBox8.BackgroundImage == Croce)
            {
                MessageBox.Show("Ha vinto la croce");
            }
            else if (pictureBox3.BackgroundImage == Croce && pictureBox6.BackgroundImage == Croce && pictureBox9.BackgroundImage == Croce)
            {
                MessageBox.Show("Ha vinto la croce");
            }
            else if (pictureBox4.BackgroundImage == Croce && pictureBox7.BackgroundImage == Croce && pictureBox10.BackgroundImage == Croce)
            {
                MessageBox.Show("Ha vinto la croce");
            }
            //se il croce vince verticale
            else if (pictureBox2.BackgroundImage == Croce && pictureBox3.BackgroundImage == Croce && pictureBox4.BackgroundImage == Croce)
            {
                MessageBox.Show("Ha vinto la croce");
            }
            else if (pictureBox5.BackgroundImage == Croce && pictureBox6.BackgroundImage == Croce && pictureBox7.BackgroundImage == Croce)
            {
                MessageBox.Show("Ha vinto la croce");
            }
            else if (pictureBox8.BackgroundImage == Croce && pictureBox9.BackgroundImage == Croce && pictureBox10.BackgroundImage == Croce)
            {
                MessageBox.Show("Ha vinto la croce");
            }
            //se il croce vince obliquo
            else if (pictureBox2.BackgroundImage == Croce && pictureBox6.BackgroundImage == Croce && pictureBox10.BackgroundImage == Croce)
            {
                MessageBox.Show("Ha vinto la croce");
            }
            else if (pictureBox4.BackgroundImage == Croce && pictureBox6.BackgroundImage == Croce && pictureBox8.BackgroundImage == Croce)
            {
                MessageBox.Show("Ha vinto la croce");
            }
            //se nessuno viince
            else if(pictureBox2.Enabled==false && pictureBox3.Enabled == false && pictureBox4.Enabled == false && pictureBox5.Enabled == false && pictureBox6.Enabled == false && pictureBox7.Enabled == false && pictureBox8.Enabled == false && pictureBox9.Enabled == false && pictureBox10.Enabled == false)
            {
                MessageBox.Show("Non ha vinto nessuno");
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var a = (PictureBox)sender;//la funzione è stata ampliata poi nella parte grafica
            if (giocatore == 1)
            {
                a.BackgroundImage = Cerchio;//richiama l'immagine cerchio
                a.Enabled = false;//non si può più premere
                
            }
            else
            {
                a.BackgroundImage = Croce;//richiama l'immagine croce
                a.Enabled = false;//non si può più premere

            }
            controllo();
            cambia();
        }     
    }
}
