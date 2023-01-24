using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOGame
{
    public partial class frmXO : Form
    {
        public frmXO()
        {
            InitializeComponent();
        }

        public frmXO(string igrac1, string igrac2) : this()
        {

            Igrac1 = igrac1;
            Igrac2 = igrac2;
        }

        private void frmXO_Load(object sender, EventArgs e)
        {
            PrikaziNarednogIgraca();
        }

        private void PrikaziNarednogIgraca()
        {
            lblNaredniIgrac.Text = (brojac % 2 == 0) ? Igrac1 : Igrac2;
        }

        public int brojac { get; set; }
        public string Igrac1 { get; }
        public string Igrac2 { get; }

        private void button1_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void NapraviPotez(object sender)
        {
            if (sender is Button)
            {
                var dugmic = sender as Button;
                if (dugmic.Text == "") //checking if button has already been clicked
                {
                    if (brojac%2== 0)
                    {
                        dugmic.Text = "X";
                    }
                    else
                    {
                        dugmic.Text = "O";
                    }
                    brojac++;

                    PrikaziNarednogIgraca(); // switch the player

                    if (KrajIgre()) //checking if the game is finished
                    {
                        PostaviStatusDugmica(false); //enables further button clicks
                    }
                }
                
            }

        }

        private void PostaviStatusDugmica(bool status, bool resetText = false, bool resetColor = false)

        {
            foreach (var kontrola in this.Controls)
            {
                if (kontrola is Button)
                {
                    var dugmic = kontrola as Button;

                    if (dugmic!=btnNovaIgra)
                    {
                        dugmic.Enabled = status;

                        if (resetColor)
                        {
                            dugmic.UseVisualStyleBackColor = true;
                            brojac = 0;
                        }

                        dugmic.Text = resetText ? "" : dugmic.Text;
                    }

                   
                    
                }
            }
        }

        private void btnNovaIgra_Click(object sender, EventArgs e)
        {
            PostaviStatusDugmica(true, true, true);
        }

        private bool KrajIgre()
        {
            return ProvjeriRedove() || ProvjeriKolone() || ProvjeriDijagonale();
        }

        private bool ProvjeriDijagonale()
        {
            return ProvjeriPobjedu(button1, button5, button9) ||
              ProvjeriPobjedu(button3, button5, button7);
        }


        private bool ProvjeriKolone()
        {
            return ProvjeriPobjedu(button1, button4, button7) ||
              ProvjeriPobjedu(button2, button5, button8) ||
               ProvjeriPobjedu(button3, button6, button9);
        }

        private bool ProvjeriRedove()
        {
            return ProvjeriPobjedu(button1, button2, button3) ||
               ProvjeriPobjedu(button4, button5, button6) ||
                ProvjeriPobjedu(button7, button8, button9);
        }

        private bool ProvjeriPobjedu(Button button1, Button button2, Button button3)
        {
            if (button1.Text != "" && button1.Text == button2.Text && button2.Text == button3.Text)
            {
                button1.BackColor = button2.BackColor = button3.BackColor = Color.Red;
                return true;
            }
            return false;
        }

       
    }

}
