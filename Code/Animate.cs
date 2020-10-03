using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public partial class Play : Form
    {

        private void moveJetons1_Tick(object sender, EventArgs e)
        {
            if (Partie)
            {
                #region Adversaire 8

                int xadv8 = 20;
                int yadv8 = 3;
                pictureBoxdistAdv8.Top += yadv8;
                pictureBoxdistAdv8.Left += xadv8;

                if (pictureBoxdistAdv8.Left >= 270 && pictureBoxdistAdv8.Top >= 25)
                {
                    moveBtmRight.Stop();
                    moveCards.Start();
                }

                #endregion
            }
        }

        private void moveJetons_Tick(object sender, EventArgs e)
        {
            if (Partie)
            {
                #region Joueur
                int y = 10;
                pictureBoxdistJoueur.Top += y;
                if(pictureBoxdistJoueur.Top >= 150)
                {
                    moveJetons.Stop();
                }
                #endregion

                #region Adversaire 1
                int yadv1 = 10;
                pictureBoxdistAdv1.Top += yadv1;
                if (pictureBoxdistAdv1.Top >= 150)
                {
                    moveJetons.Stop();
                }
                #endregion

                #region Adversaire 2
                int yadv2 = 10;
                int xadv2 = 10;
                pictureBoxdistAdv2.Top += yadv2;
                pictureBoxdistAdv2.Left -= xadv2;

                if (pictureBoxdistAdv2.Top >= 220 && pictureBoxdistAdv2.Left >= 120)
                {
                    moveJetons.Stop();
                }
                #endregion


                #region Adversaire 3

                int yadv3 = 15;
                int xadv3 = 20;
                pictureBoxdistAdv3.Top -= yadv3;
                pictureBoxdistAdv3.Left -= xadv3;

                if (pictureBoxdistAdv3.Left >= 240 && pictureBoxdistAdv3.Top <= 400)
                {
                    moveTopLeft.Stop();
                }
                #endregion


            }

        }

        private void moveTopLeft_Tick(object sender, EventArgs e)
        {
            if (Partie)
            {
                #region Adversaire 7
                int yadv7 = 19;
                int xadv7 = 40;
                pictureBoxdistAdv7.Top -= yadv7; //536 - 15 
                pictureBoxdistAdv7.Left += xadv7; //65 + 15  

                if (pictureBoxdistAdv7.Left >= 700 && pictureBoxdistAdv7.Top <= 400)
                {
                    moveTopLeft.Stop();
                }
                #endregion

            }
        }

        private void moveTop_Tick(object sender, EventArgs e)
        {
            
            if (Partie)
            {
                #region Adversaire 4

                int yadv4 = 15;

                pictureBoxdistAdv4.Top -= yadv4;

                if (pictureBoxdistAdv4.Top <= 450)
                {
                    moveTop.Stop();
                }

                #endregion

                #region Adversaire 5

                int yadv5 = 15;

                pictureBoxdistAdv5.Top -= yadv5;

                if (pictureBoxdistAdv5.Top <= 450)
                {
                    moveTop.Stop();
                }

                #endregion

                #region Adversaire 6

                int yadv6 = 15;

                pictureBoxdistAdv6.Top -= yadv6;

                if (pictureBoxdistAdv6.Top <= 450)
                {
                    moveTop.Stop();
                }

                #endregion
            }
        }

        void MoveJetons()
        {
            if (Partie)
            {
                pictureBoxdistJoueur.Visible = true;
                pictureBoxdistAdv1.Visible = true;
                pictureBoxdistAdv2.Visible = true;
                pictureBoxdistAdv3.Visible = true;
                pictureBoxdistAdv4.Visible = true;
                pictureBoxdistAdv5.Visible = true;
                pictureBoxdistAdv6.Visible = true;
                pictureBoxdistAdv7.Visible = true;
                pictureBoxdistAdv8.Visible = true;

                moveJetons.Enabled = true;
                moveTopLeft.Enabled = true;
                moveTop.Enabled = true;
                moveBtmRight.Enabled = true;
                
 
                moveJetons.Start();
                moveTopLeft.Start();
                moveTop.Start();
                moveBtmRight.Start();
            }

            else return;
        }

        void CartesTable()
        {
            switch (Tours)
            {
                case 1:
                    #region Flop 1
                    int flops = CarteAleatoire();
                    Cartes carteFlop_1 = jeu[flops];
                    CartesUtilisees.Add(flops);

                    while (CartesUtilisees.Contains(flops))
                    {
                        flops = CarteAleatoire();
                    }
                    flops = 1 * flops;

                    ListeCartes.Add(carteFlop_1);

                    Timer timer_flop_1 = new Timer();
                    timer_flop_1.Interval = 500;
                    timer_flop_1.Enabled = false;
                    #endregion

                    #region Flop 2
                    flops = CarteAleatoire();
                    Cartes carteFlop_2 = jeu[flops];
                    CartesUtilisees.Add(flops);

                    while (CartesUtilisees.Contains(flops))
                    {
                        flops = CarteAleatoire();
                    }
                    flops = 1 * flops;

                    ListeCartes.Add(carteFlop_2);

                    Timer timer_flop_2 = new Timer();
                    timer_flop_2.Interval = 500;
                    timer_flop_2.Enabled = false;
                    #endregion

                    #region Flop 3
                    flops = CarteAleatoire();
                    Cartes carteFlop_3 = jeu[flops];
                    CartesUtilisees.Add(flops);

                    while (CartesUtilisees.Contains(flops))
                    {
                        flops = CarteAleatoire();
                    }
                    flops = 1 * flops;

                    ListeCartes.Add(carteFlop_3);

                    Timer timer_flop_3 = new Timer();
                    timer_flop_3.Interval = 500;
                    timer_flop_3.Enabled = false;
                    #endregion

                    switch (Partie)
                    {
                        case true:
                            /*int x = 5;
                            pictureBoxdistJoueur.Left += x;
                            if (pictureBoxdistJoueur.Left >= 200)*/
                            {
                                timer_flop_1.Stop();
                            }
                            break;

                        case false:
                            Console.WriteLine("Tentative d'animation : " + timer_flop_1.ToString());
                            break;
                    }
                    
                    pictureBoxFlop1.ImageLocation = carteFlop_1.Image;
                    pictureBoxFlop2.ImageLocation = carteFlop_2.Image;
                    pictureBoxFlop3.ImageLocation = carteFlop_3.Image;

                    //non révelés
                    pictureBoxTurn.Image = Properties.Resources.deck_3;
                    pictureBoxRiver.Image = Properties.Resources.deck_3; 
                    break;

                case 2:
                    int turns = CarteAleatoire();
                    Cartes carteTurn = jeu[turns];
                    CartesUtilisees.Add(turns);

                    while (CartesUtilisees.Contains(turns))
                    {
                        turns = CarteAleatoire();
                    }
                    turns = 1 * turns;

                    ListeCartes.Add(carteTurn);

                    pictureBoxTurn.ImageLocation = carteTurn.Image;
                    break;

                case 3:
                    int rivers = CarteAleatoire();
                    Cartes carteriver = jeu[rivers];
                    CartesUtilisees.Add(rivers);

                    while (CartesUtilisees.Contains(rivers))
                    {
                        rivers = CarteAleatoire();
                    }
                    rivers = 1 * rivers;

                    ListeCartes.Add(carteriver);

                    pictureBoxRiver.ImageLocation = carteriver.Image;
                    break;
            }
        }
    }
}
    