using Poker.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public partial class Play : Form
    {
        public bool Couche = false;
        public bool Mise = false;
        public bool Check = false;
        public bool Decision;

        public bool Couché = false, Couché_1 = false, Couché_2, Couché_3, Couché_4, Couché_5, Couché_6, Couché_7, Couché_8;
        public bool __Mise = false;

        int ArgRest1;
        int max1, max2, max3, max4, max5, max6, max7, max8;
        int _Mise1, _Mise2, _Mise3, _Mise4, _Mise5, _Mise6, _Mise7, _Mise8;

        public string strCheck = "Check";
        public string strCoucher = "Couché";
        public string strMise = "Mise :";
        public string strRelance = "Relance";
        public string strSuivre = "Suivre";

        void ChargerBoutons()
        {
            TourJoueur = true;
            btnCoucher.Visible = true;
            btnMiser.Visible = true;
            btnRelancer.Visible = true;
            btnSuivre.Visible = true;
        }

        public void btnCoucher_Click(object sender, EventArgs e)
        {
            if (TourJoueur)
            {
                Couché = true;
                CoucherJoueur();
                HideButtons();
                TourJoueur = false;
                TourAdv1 = true;
                labelJoueur.BackColor = Color.Transparent;
                WhoIsPlaying();
                Round();
            }

        }

        private async void btnValider_Click(object sender, EventArgs e)
        {
            int.TryParse(textBoxmise.Text, out _Mise);
            if (!int.TryParse(textBoxmise.Text, out _Mise))
            {
                MessageBox.Show("Veuillez mettre une valeur valide.",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textBoxmise.Text = " ";
            }
            else if (_Mise > ArgentJoueur)
            {
                MessageBox.Show("Vous ne pouvez pas mettre autant.",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                await Task.Delay(500);
                Mise_();
                TourJoueur = true;
                WhoIsPlaying();
                HideButtons();
                btnAnnuler.Visible = false;
                textBoxmise.Visible = false;
                btnValider.Visible = false;
            }
        }

        private async void btnMiser_Click(object sender, EventArgs e)
        {
            __Mise = false;
            Mise = true;
            if (Mise)
            {
                await Task.Delay(500);
                textBoxmise.Visible = true;
                HideButtons();
                btnValider.Visible = true;
                btnAnnuler.Visible = true;
            }
            else return;
        }

        private async void btnSuivre_Click(object sender, EventArgs e)
        {
            await Task.Delay(1000);
            Suivre();
        }

        private async void btnAnnuler_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            btnAnnuler.Visible = false;
            btnValider.Visible = false;
            textBoxmise.Visible = false;
            ChargerBoutons();
        }

        public async void HideButtons()
        {
            await Task.Delay(50);
            btnCoucher.Visible = false;
            btnMiser.Visible = false;
            btnRelancer.Visible = false;
            btnSuivre.Visible = false;
        }

        public async void Mise_()
        {
            await Task.Delay(800);
            if (TourJoueur)
            {
                if (!Couché)
                {
                    if (__Mise == false)
                    {
                        ArgentJoueur -= _Mise;
                        total += _Mise;
                        labelArgentJoueur.Text = TXArgent + ArgentJoueur;
                        labelTotal.Text = TXArgent + total;
                        labelJoueur.BackColor = Color.Transparent;
                        lblActJoueur.Text = strMise + _Mise;
                        mises.Add(_Mise);
                        __Mise = true;
                        TourAdv1 = true;
                        TourJoueur = false;
                        WhoIsPlaying();
                        ConditionsTours();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            else if (TourAdv1)
            {
                if (Couché_1 == false)
                {
                    if (__Mise == false)
                    {
                        await Task.Delay(100);
                        int ArgMax1 = ArgentAdv1 / 10;
                        Random rd1 = new Random();
                        _Mise1 = rd1.Next(10, ArgMax1);
                        ArgentAdv1 -= _Mise1;
                        total += _Mise1;
                        lblArgentAdversaire1.Text = TXArgent + ArgentAdv1;
                        labelTotal.Text = TXArgent + total;
                        lblAdv1.BackColor = Color.Transparent;
                        lblActAdv1.Text = strMise + _Mise1;
                        mises.Add(_Mise1);
                        TourAdv1 = false;
                        TourAdv2 = true;
                        WhoIsPlaying();
                        RandDecisions();
                    }
                    else
                    {
                        //Probs();
                    }
                }
                else
                {

                }
            }
            else if (TourAdv2)
            {
                if (Couché_2 == false)
                {
                    if (__Mise == false)
                    {
                        await Task.Delay(100);
                        int ArgMax2 = ArgentAdv2 / 10;
                        Random rd2 = new Random();
                        _Mise2 = rd2.Next(10, ArgMax2);
                        ArgentAdv2 -= _Mise2;
                        total += _Mise2;
                        lblArgentAdversaire2.Text = TXArgent + ArgentAdv2;
                        labelTotal.Text = TXArgent + total;
                        lblAdv2.BackColor = Color.Transparent;
                        lblActAdv2.Text = strMise + _Mise2;
                        mises.Add(_Mise2);
                        TourAdv2 = false;
                        TourAdv3 = true;
                        WhoIsPlaying();
                        RandDecisions();
                    }
                    else
                    {
                        //Probs();
                    }
                }
                else
                {

                }
            }
            else if (TourAdv3)
            {
                if (Couché_3 == false)
                {
                    if (__Mise == false)
                    {
                        await Task.Delay(100);
                        int ArgMax3 = ArgentAdv3 / 10;
                        Random rd3 = new Random();
                        _Mise3 = rd3.Next(10, ArgMax3);
                        ArgentAdv3 -= _Mise3;
                        total += _Mise3;
                        lblArgentAdversaire3.Text = TXArgent + ArgentAdv3;
                        labelTotal.Text = TXArgent + total;
                        lblAdv3.BackColor = Color.Transparent;
                        lblActAdv3.Text = strMise + _Mise3;
                        mises.Add(_Mise3);
                        TourAdv3 = false;
                        TourAdv4 = true;
                        WhoIsPlaying();
                        RandDecisions();
                    }
                    else
                    {
                        //Probs();
                    }
                }
                else
                {

                }
            }
            else if (TourAdv4)
            {
                if (Couché_4 == false)
                {
                    if (__Mise == false)
                    {
                        await Task.Delay(100);
                        int ArgMax4 = ArgentAdv4 / 10;
                        Random rd4 = new Random();
                        _Mise3 = rd4.Next(10, ArgMax4);
                        ArgentAdv4 -= _Mise4;
                        total += _Mise4;
                        lblArgentAdversaire4.Text = TXArgent + ArgentAdv4;
                        labelTotal.Text = TXArgent + total;
                        lblAdv4.BackColor = Color.Transparent;
                        lblActAdv4.Text = strMise + _Mise4;
                        mises.Add(_Mise4);
                        TourAdv4 = false;
                        TourAdv5 = true;
                        WhoIsPlaying();
                        RandDecisions();
                    }
                    else
                    {
                        //Probs();
                    }
                }
                else
                {

                }
            }
        }

        public void CoucherJoueur()
        {
            pictureBoxJoueur1.Image = null;
            pictureBoxJoueur2.Image = null;
            lblActJoueur.Text = strCoucher;
            Couché = true;
            labelJoueur.BackColor = Color.Transparent;
            TourJoueur = false;
            TourAdv1 = true;
        }

        public void Coucher()
        {
            if (TourAdv1)
            {
                pictureBoxAdv1_1.Image = null;
                pictureBoxAdv1_2.Image = null;
                lblActAdv1.Text = strCoucher;
                Couché_1 = true;
                lblAdv1.BackColor = Color.Transparent;
                TourAdv1 = false;
                TourAdv2 = true;
                WhoIsPlaying();
                //RandDecisions();
            }
            else if (TourAdv2)
            {
                pictureBoxAdv2_1.Image = null;
                pictureBoxAdv2_2.Image = null;
                lblActAdv2.Text = strCoucher;
                Couché_2 = true;
                lblAdv2.BackColor = Color.Transparent;
                TourAdv2 = false;
                TourAdv3 = true;
                WhoIsPlaying();
                //RandDecisions();
            }
            else if (TourAdv3)
            {
                pictureBoxAdv3_1.Image = null;
                pictureBoxAdv3_2.Image = null;
                lblActAdv3.Text = strCoucher;
                Couché_3 = true;
                lblAdv3.BackColor = Color.Transparent;
                TourAdv3 = false;
                TourAdv4 = true;
                WhoIsPlaying();
            }
            else if (TourAdv4)
            {
                pictureBoxAdv4_1.Image = null;
                pictureBoxAdv4_2.Image = null;
                lblActAdv4.Text = strCoucher;
                Couché_4 = true;
                lblAdv4.BackColor = Color.Transparent;
                TourAdv4 = false;
                TourAdv5 = true;
                WhoIsPlaying();
            }
            else if (TourAdv5)
            {
                pictureBoxAdv5_1.Image = null;
                pictureBoxAdv5_2.Image = null;
                lblActAdv5.Text = strCoucher;
                Couché_5 = true;
                lblAdv5.BackColor = Color.Transparent;
                TourAdv5 = false;
                TourAdv6 = true;
                WhoIsPlaying();
            }
            else if (TourAdv6)
            {
                pictureBoxAdv6_1.Image = null;
                pictureBoxAdv6_2.Image = null;
                lblActAdv6.Text = strCoucher;
                Couché_6 = true;
                lblAdv6.BackColor = Color.Transparent;
                TourAdv6 = false;
                TourAdv7 = true;
                WhoIsPlaying();
            }
            else if (TourAdv7)
            {
                pictureBoxAdv7_1.Image = null;
                pictureBoxAdv7_2.Image = null;
                lblActAdv7.Text = strCoucher;
                Couché_7 = true;
                lblAdv7.BackColor = Color.Transparent;
                TourAdv7 = false;
                TourAdv8 = true;
                WhoIsPlaying();
            }
            else if (TourAdv8)
            {
                pictureBoxAdv8_1.Image = null;
                pictureBoxAdv8_2.Image = null;
                lblActAdv8.Text = strCoucher;
                Couché_8 = true;
                lblAdv8.BackColor = Color.Transparent;
                TourAdv8 = false;
                TourJoueur = true;
                WhoIsPlaying();
            }
            else return;
        }

        public async void Suivre()
        {
            await Task.Delay(500);
            if (TourAdv1)
            {
                if (Couché_1 == false)
                {
                    int max = mises.Max();
                    ArgentAdv1 -= max;
                    //ArgRest1 = max;
                    lblArgentAdversaire1.Text = TXArgent + ArgentAdv1;
                    labelTotal.Text = TXTotal + (total + max);
                    //mises.Clear();
                    lblActAdv1.Text = strSuivre;
                    lblAdv1.BackColor = Color.Transparent;
                    TourAdv1 = false;
                    TourAdv2 = true;
                    WhoIsPlaying();
                    Probs();
                }
                else
                {
                    return;
                }
            }
            else if (TourAdv2)
            {
                if (Couché_2 == false)
                {
                    max2 = mises.Max();
                    ArgentAdv2 -= max2;
                    lblArgentAdversaire2.Text = TXArgent + ArgentAdv2;
                    labelTotal.Text = TXTotal + (total + max2 + max2);
                    //mises.Clear();
                    lblActAdv2.Text = strSuivre;
                    lblAdv2.BackColor = Color.Transparent;
                    TourAdv2 = false;
                    TourAdv3 = true;
                    WhoIsPlaying();
                    Probs();
                }
                else
                {
                    return;
                }
            }

            else if (TourAdv3)
            {
                if (Couché_3 == false)
                {
                    max3 = mises.Max();
                    ArgentAdv3 -= max3;
                    lblArgentAdversaire3.Text = TXArgent + ArgentAdv3;
                    labelTotal.Text = TXTotal + (total + max2 + max3);
                    //mises.Clear();
                    lblActAdv3.Text = strSuivre;
                    lblAdv3.BackColor = Color.Transparent;
                    TourAdv3 = false;
                    TourAdv4 = true;
                    WhoIsPlaying();
                    Probs();
                }
                else
                {
                    return;
                }
            }

            else if (TourAdv4)
            {
                if (Couché_4 == false)
                {
                    max4 = mises.Max();
                    ArgentAdv4 -= max4;
                    lblArgentAdversaire4.Text = TXArgent + ArgentAdv4;
                    labelTotal.Text = TXTotal + (total + max2 + max3 + max4);
                    //mises.Clear();
                    lblActAdv4.Text = strSuivre;
                    lblAdv4.BackColor = Color.Transparent;
                    TourAdv4 = false;
                    TourAdv5 = true;
                    WhoIsPlaying();
                    Probs();
                }
                else
                {
                    return;
                }
            }
        }

        void Probs() //quand suivi
        {
            Random rdMise = new Random();
            int rd = rdMise.Next(1, 7);

            switch (rd)
            {
                case 1: // Couché
                    Coucher();
                    break;

                case 2:
                    Suivre();
                    break;

                case 3:
                    Suivre();
                    break;

                case 4:
                    Suivre();
                    break;

                case 5:
                    Suivre();
                    break;

                case 6:
                    Suivre();
                    break;

                case 7:
                    Suivre();
                    break;

            }
        }
        /* // MISE
         * ==========
         *  
         */
    }
}