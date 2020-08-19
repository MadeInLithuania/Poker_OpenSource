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
    }
}
    