using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Automation;
using System.Windows.Forms;
using System.Windows.Media;

namespace Poker
{
    public partial class Play : Form
    {
        bool Distrib, SecondDistr;
        #region Bools Regions
        bool distj1 = false, distj2 = false, dist1_1 = false, dist2_1 = false, dist3_1 = false, dist4_1 = false, dist5_1 = false, dist6_1 = false, dist7_1 = false, dist8_1 = false;
        #endregion
        int delay = 100;
        void DistrCards()
        {
            //var _dist = new System.Windows.Media.MediaPlayer();
            //_dist.Open(new System.Uri(Environment.CurrentDirectory + "\\sfx\\cardSlide8.wav"));

            //_dist.Play();
        }


        public async void moveCards_Tick(object sender, EventArgs e)
        {
          
      
            if (Partie)
            {
                Distrib = true;
                int y = 30;
                int x = 16;

                pictureBoxDist.Top -= y;
                pictureBoxDist.Left += x;

                #region Joueur
                if (pictureBoxDist.Top <= 28 && pictureBoxDist.Left >= 346)
                {
                    distj1 = true;
                    moveCards.Stop();
                    pictureBoxDist.Location = pictureBoxDeck.Location;
                    GenCartesAdv();
                    await Task.Delay(delay);
                    moveCardsAdv1_1.Enabled = true;
                    label2.Visible = true;
                    distj1 = false;
                }
                #endregion
            }

        }


        public async void  moveCardsAdv1_1_Tick(object sender, EventArgs e)
        {
            if (Partie)
            {
                Distrib = true;
                int y1 = 30;
                int x1 = 73;

                pictureBoxd1_1.Top -= y1;
                pictureBoxd1_1.Left += x1;

                #region Adversaire1
                if (pictureBoxd1_1.Top <= 28 && pictureBoxd1_1.Left >= 653)
                {
                    dist1_1 = true;
                    moveCardsAdv1_1.Stop();
                    pictureBoxd1_1.Location = pictureBoxDeck.Location;
                    GenCartesAdv();
                    dist1_1 = false;
                    await Task.Delay(delay);
                    moveCardsAdv2_1.Enabled = true;
                }
                #endregion
            }
        }

        public async void moveCardsAdv2_1_Tick(object sender, EventArgs e)
        {
            if (Partie)
            {
                Distrib = true;
                int y2 = 23;
                int x2 = 100;

                pictureBoxd2_1.Top -= y2;
                pictureBoxd2_1.Left += x2;

                #region Adversaire1
                if (pictureBoxd2_1.Top <= 87 && pictureBoxd2_1.Left >= 849)
                {
                    dist2_1 = true;
                    moveCardsAdv2_1.Stop();
                    pictureBoxd2_1.Location = pictureBoxDeck.Location;
                    GenCartesAdv();
                    dist2_1 = false;
                    await Task.Delay(delay);
                    moveCardsAdv3_1.Enabled = true;
                }
                #endregion
            }

        }
        public async void moveCardsAdv3_1_Tick(object sender, EventArgs e)
        {
            if (Partie)
            {
                Distrib = true;
                int y3 = 23;
                int x3 = 100;

                pictureBoxd3_1.Top += y3;
                pictureBoxd3_1.Left += x3;

                #region Adversaire3
                if (pictureBoxd3_1.Top >= 120 && pictureBoxd3_1.Left >= 900)
                {
                    dist3_1 = true;
                    moveCardsAdv3_1.Stop();
                    pictureBoxd3_1.Location = pictureBoxDeck.Location;
                    GenCartesAdv();
                    dist3_1 = false;
                    await Task.Delay(delay);
                    moveCardsAdv4_1.Enabled = true;
                }
                #endregion
            }
        }

        public async void moveCardsAdv4_1_Tick(object sender, EventArgs e)
        {
            if (Partie)
            {
                Distrib = true;
                int y4 = 43;
                int x4 = 100;

                pictureBoxd4_1.Top += y4;
                pictureBoxd4_1.Left += x4;

                #region Adversaire 4
                if (pictureBoxd4_1.Top >= 520 && pictureBoxd4_1.Left >= 800)
                {
                    dist4_1 = true;
                    moveCardsAdv4_1.Stop();
                    pictureBoxd4_1.Location = pictureBoxDeck.Location;
                    GenCartesAdv();
                    dist4_1 = false;
                    await Task.Delay(delay);
                    moveCardsAdv5_1.Enabled = true;             
                }
                #endregion
            }
        }
        public async void moveCardsAdv5_1_Tick(object sender, EventArgs e)
        {
            if (Partie)
            {
                Distrib = true;
                int y5 = 48;
                int x5 = 60;

                pictureBoxd5_1.Top += y5;
                pictureBoxd5_1.Left += x5;

                #region Adversaire 5
                if (pictureBoxd5_1.Top >= 560 && pictureBoxd5_1.Left >= 400)
                {
                    dist5_1 = true;
                    moveCardsAdv5_1.Stop();
                    pictureBoxd5_1.Location = pictureBoxDeck.Location;
                    GenCartesAdv();
                    dist5_1 = false;
                    await Task.Delay(delay);
                    moveCardsAdv6_1.Enabled = true;
                }
                #endregion
            }
        }

        public async void moveCardsAdv6_1_Tick(object sender, EventArgs e)
        {
            if (Partie)
            {
                Distrib = true;
                int y6 = 48;
                int x6 = 13;

                pictureBoxd6_1.Top += y6;
                pictureBoxd6_1.Left += x6;

                #region Adversaire 6
                if (pictureBoxd6_1.Top >= 560 && pictureBoxd6_1.Left >= 90)
                {
                    dist6_1 = true;
                    moveCardsAdv6_1.Stop();
                    pictureBoxd6_1.Location = pictureBoxDeck.Location;
                    GenCartesAdv();
                    dist6_1 = false;
                    await Task.Delay(delay);
                    moveCardsAdv7_1.Enabled = true;               
                }
                #endregion
            }
        }
        public async void moveCardsAdv7_1_Tick(object sender, EventArgs e)
        {
            if (Partie)
            {
                Distrib = true;
                int y7 = 48;
                int x7 = 40;

                pictureBoxd7_1.Top += y7;
                pictureBoxd7_1.Left -= x7;

                #region Adversaire 7
                if (pictureBoxd7_1.Top >= 500 && pictureBoxd7_1.Left <= 160)
                {
                    dist7_1 = true;
                    moveCardsAdv7_1.Stop();
                    pictureBoxd7_1.Location = pictureBoxDeck.Location;
                    GenCartesAdv();
                    dist7_1 = false;
                    await Task.Delay(delay);
                    moveCardsAdv8_1.Enabled = true;
                }
                #endregion
            }
        }

        public async void moveCardsAdv8_1_Tick(object sender, EventArgs e)
        {
            if (Partie)
            {
                Distrib = true;
                int y8 = 15;
                int x8 = 40;

                pictureBoxd8_1.Top -= y8;
                pictureBoxd8_1.Left -= x8;

                #region Adversaire 8
                if (pictureBoxd8_1.Top <= 140 && pictureBoxd8_1.Left <= 800)
                {
                    dist8_1 = true;
                    moveCardsAdv8_1.Stop();
                    pictureBoxd8_1.Location = pictureBoxDeck.Location;
                    GenCartesAdv();
                    dist8_1 = false;
                    await Task.Delay(delay);
                    moveCards_2.Enabled = true;
                    
                }
                #endregion
            }
        }

        public async void moveCards_2_Tick(object sender, EventArgs e)
        { 
            if (Partie)
            {
                Distrib = true;
                int y_2 = 30;
                int x_2 = 20;

                pictureBoxdj_2.Top -= y_2;
                pictureBoxdj_2.Left += x_2;

                #region Joueur
                if (pictureBoxdj_2.Top <= 28 && pictureBoxdj_2.Left >= 366)
                {
                    distj1 = true;
                    SecondDistr = true;
                    moveCards_2.Stop();
                    pictureBoxdj_2.Location = pictureBoxDeck.Location;
                    GenCartesAdv();
                    SecondDistr = false;
                    await Task.Delay(delay);
                    moveCardsAdv1_2.Enabled = true;
                    distj1 = false;
                }
                #endregion
            }
        }

        public async void moveCardsAdv1_2_Tick(object sender, EventArgs e)
        {
            if (Partie)
            {
                Distrib = true;
                int y1_2 = 30;
                int x1_2 = 73;

                pictureBoxd1_2.Top -= y1_2;
                pictureBoxd1_2.Left += x1_2;

                #region Adversaire1
                if (pictureBoxd1_2.Top <= 28 && pictureBoxd1_2.Left >= 673)
                {
                    dist1_1 = true;
                    SecondDistr = true;
                    moveCardsAdv1_2.Stop();
                    pictureBoxd1_2.Location = pictureBoxDeck.Location;
                    GenCartesAdv();
                    SecondDistr = false;
                    await Task.Delay(delay);
                    moveCardsAdv2_2.Enabled = true;
                    dist1_1 = false;
                }
                #endregion
            }
        }
        public async void moveCardsAdv2_2_Tick(object sender, EventArgs e)
        {

            if (Partie)
            {
                Distrib = true;
                int y2_2 = 23;
                int x2_2 = 100;

                pictureBoxd2_2.Top -= y2_2;
                pictureBoxd2_2.Left += x2_2;

                #region Adversaire1
                if (pictureBoxd2_2.Top <= 87 && pictureBoxd2_2.Left >= 869)
                {
                    dist2_1 = true;
                    SecondDistr = true;
                    moveCardsAdv2_2.Stop();
                    pictureBoxd2_2.Location = pictureBoxDeck.Location;
                    GenCartesAdv();
                    SecondDistr = false;
                    await Task.Delay(delay);
                    moveCardsAdv3_2.Enabled = true;
                    dist2_1 = false;
                }
                #endregion
            }
        }

        public async void moveCardsAdv3_2_Tick(object sender, EventArgs e)
        {
            if (Partie)
            {
                Distrib = true;
                int y3_2 = 23;
                int x3_2 = 100;

                pictureBoxd3_2.Top += y3_2;
                pictureBoxd3_2.Left += x3_2;

                #region Adversaire3
                if (pictureBoxd3_2.Top >= 120 && pictureBoxd3_2.Left >= 920)
                {
                    dist3_1 = true;
                    SecondDistr = true;
                    moveCardsAdv3_2.Stop();
                    pictureBoxd3_2.Location = pictureBoxDeck.Location;
                    GenCartesAdv();
                    SecondDistr = false;
                    await Task.Delay(delay);
                    moveCardsAdv4_2.Enabled = true;
                    dist3_1 = false;
                }
                #endregion
            }
        }
        public async void moveCardsAdv4_2_Tick(object sender, EventArgs e)
        {
            if (Partie)
            {
                Distrib = true;
                int y4_2 = 43;
                int x4_2 = 100;

                pictureBoxd4_2.Top += y4_2;
                pictureBoxd4_2.Left += x4_2;

                #region Adversaire 4
                if (pictureBoxd4_2.Top >= 520 && pictureBoxd4_2.Left >= 820)
                {
                    dist4_1 = true;
                    SecondDistr = true;
                    moveCardsAdv4_2.Stop();
                    pictureBoxd4_2.Location = pictureBoxDeck.Location;
                    GenCartesAdv();
                    SecondDistr = false;
                    await Task.Delay(delay);
                    moveCardsAdv5_2.Enabled = true;
                    dist4_1 = false;
                }
                #endregion
            }
        }

        public async void moveCardsAdv5_2_Tick(object sender, EventArgs e)
        {
            if (Partie)
            {
                Distrib = true;
                int y5_2 = 48;
                int x5_2 = 60;

                pictureBoxd5_2.Top += y5_2;
                pictureBoxd5_2.Left += x5_2;

                #region Adversaire 5
                if (pictureBoxd5_2.Top >= 560 && pictureBoxd5_2.Left >= 420)
                {
                    dist5_1 = true;
                    SecondDistr = true;
                    moveCardsAdv5_2.Stop();
                    pictureBoxd5_2.Location = pictureBoxDeck.Location;
                    GenCartesAdv();
                    dist5_1 = false;
                    SecondDistr = false;
                    await Task.Delay(delay);
                    moveCardsAdv6_2.Enabled = true;
                }
                #endregion
            }
        }

        public async void moveCardsAdv6_2_Tick(object sender, EventArgs e)
        {
            if (Partie)
            {
                Distrib = true;
                int y6_2 = 48;
                int x6_2 = 20;

                pictureBoxd6_2.Top += y6_2;
                pictureBoxd6_2.Left += x6_2;

                #region Adversaire 6
                if (pictureBoxd6_2.Top >= 560 && pictureBoxd6_2.Left >= 110)
                {
                    dist6_1 = true;
                    SecondDistr = true;
                    moveCardsAdv6_2.Stop();
                    pictureBoxd6_2.Location = pictureBoxDeck.Location;
                    GenCartesAdv();
                    dist6_1 = false;
                    SecondDistr = false;
                    await Task.Delay(delay);
                    moveCardsAdv7_2.Enabled = true;
                }
                #endregion
            }
        }

        public async void moveCardsAdv7_2_Tick(object sender, EventArgs e)
        {
            if (Partie)
            {
                Distrib = true;
                int y7_2 = 40;
                int x7_2 = 20;

                pictureBoxd7_2.Top += y7_2;
                pictureBoxd7_2.Left -= x7_2;

                #region Adversaire 7
                if (pictureBoxd7_2.Top >= 480 && pictureBoxd7_2.Left <= 180)
                {
                    dist7_1 = true;
                    SecondDistr = true;
                    moveCardsAdv7_2.Stop();
                    pictureBoxd7_2.Location = pictureBoxDeck.Location;
                    GenCartesAdv();
                    dist7_1 = false;
                    SecondDistr = false;
                    await Task.Delay(delay);
                    moveCardsAdv8_2.Enabled = true;
                }
                #endregion
            }
        }

        public async void moveCardsAdv8_2_Tick(object sender, EventArgs e)
        {
            if (Partie)
            {
                Distrib = true;
                int y8_2 = 15;
                int x8_2 = 40;

                pictureBoxd8_2.Top -= y8_2;
                pictureBoxd8_2.Left -= x8_2;

                #region Adversaire 8
                if (pictureBoxd8_2.Top <= 180 && pictureBoxd8_2.Left <= 900)
                {
                    dist8_1 = true;
                    SecondDistr = true;
                    moveCardsAdv8_2.Stop();
                    pictureBoxd8_2.Location = pictureBoxDeck.Location;
                    GenCartesAdv();
                    await Task.Delay(delay);
                    SecondDistr = false;
                    Distrib = false;
                    dist8_1 = false;
                    Decision = true;
                    label2.Visible = false;
                    await Task.Delay(delay + 200);
                    ChargerBoutons();
                    WhoIsPlaying();
                }
                #endregion
            }
        }
    }
}

/*
            pictureBoxAdv1_1.Image = Poker.Properties.Resources.deck_3;
            pictureBoxAdv1_2.Image = Poker.Properties.Resources.deck_3;
            pictureBoxAdv2_1.Image = Poker.Properties.Resources.deck_3;
            pictureBoxAdv2_2.Image = Poker.Properties.Resources.deck_3;
            pictureBoxAdv3_1.Image = Poker.Properties.Resources.deck_3;
            pictureBoxAdv3_2.Image = Poker.Properties.Resources.deck_3;
            pictureBoxAdv4_1.Image = Poker.Properties.Resources.deck_3;
            pictureBoxAdv4_2.Image = Poker.Properties.Resources.deck_3;
            pictureBoxAdv5_1.Image = Poker.Properties.Resources.deck_3;
            pictureBoxAdv5_2.Image = Poker.Properties.Resources.deck_3;
            pictureBoxAdv6_1.Image = Poker.Properties.Resources.deck_3;
            pictureBoxAdv6_2.Image = Poker.Properties.Resources.deck_3;
            pictureBoxAdv7_1.Image = Poker.Properties.Resources.deck_3;
            pictureBoxAdv7_2.Image = Poker.Properties.Resources.deck_3;
            pictureBoxAdv8_1.Image = Poker.Properties.Resources.deck_3;
            pictureBoxAdv8_2.Image = Poker.Properties.Resources.deck_3;

    */