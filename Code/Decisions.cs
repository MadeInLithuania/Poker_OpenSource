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

        public bool Couché, Couché_1, Couché_2, Couché_3, Couché_4, Couché_5, Couché_6, Couché_7, Couché_8;
        public bool Misé = false;

        int _Mise1, _Mise2, _Mise3, _Mise4, _Mise5, _Mise6, _Mise7, _Mise8;

        public string strCheck = "Check";
        public string strCoucher = "Couché";
        public string strMise = "Mise :";
        public string strRelance = "Relance";
        public string strSuivre = "Suivre";

        void ChargerBoutons()
        {
            TourJoueur = true;
            btnCheck.Visible = true;
            btnCoucher.Visible = true;
            btnMiser.Visible = true;
            btnRelancer.Visible = true;
            btnSuivre.Visible = true;
        }

        public void btnCoucher_Click(object sender, EventArgs e)
        {
            if (TourJoueur)
            {
                Couche = true;
                Coucher();
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

            else if(_Mise > ArgentJoueur)
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
                Round();
                TourAdv1 = true;
                WhoIsPlaying();
                Round();
                HideButtons();
                btnAnnuler.Visible = false;
                textBoxmise.Visible = false;
                btnValider.Visible = false;
            }
        }

        private async void btnMiser_Click(object sender, EventArgs e)
        {
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
            btnCheck.Visible = false;
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
                    if (!Misé)
                    {
                        await Task.Delay(100);
                        ArgentJoueur -= _Mise;
                        total += _Mise;
                        labelArgentJoueur.Text = TXArgent + ArgentJoueur;
                        labelTotal.Text = TXArgent + total;
                        labelJoueur.BackColor = Color.Transparent;
                        lblActJoueur.Text = strMise + _Mise;
                        mises.Add(_Mise);
                        Misé = true;
                        TourAdv1 = true;
                        TourJoueur = false;
                        WhoIsPlaying();

                    }

                    else
                    {
                        Random rdMise = new Random();
                        int rd = rdMise.Next(1, 4);

                        switch (rd)
                        {
                            case 1: // Couché
                                Coucher();
                            break;

                            case 2:
                                Suivre();
                            break;

                        }

                    }
                }

                else
                {

                }
            }

            else if (TourAdv1)
            {
                if (!Couché_1)
                {
                    if (!Misé)
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
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }

            else if (TourAdv2)
            {
                if (!Couché_2)
                {
                    if (!Misé)
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
                    }
                    else 
                    { 

                    }
                }
                else
                {

                }
            }

            else if (TourAdv3)
            {
                if (!Couché_3)
                {
                    if (!Misé)
                    {
                        await Task.Delay(100);
                        int ArgMax3 = ArgentAdv3 / 10;
                        Random rd3 = new Random();
                        _Mise3 = rd3.Next(10, ArgMax3);
                        ArgentAdv3 -= _Mise2;
                        total += _Mise3;
                        lblArgentAdversaire3.Text = TXArgent + ArgentAdv3;
                        labelTotal.Text = TXArgent + total;
                        lblAdv3.BackColor = Color.Transparent;
                        lblActAdv3.Text = strMise + _Mise3;
                        mises.Add(_Mise3);
                        TourAdv3 = false;
                        TourAdv4 = true;
                        WhoIsPlaying();
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }

            else if (TourAdv4)
            {
                if (!Couché_4)
                {
                    if (!Misé)
                    {
                        await Task.Delay(100);
                        int ArgMax4 = ArgentAdv4 / 10;
                        Random rd4 = new Random();
                        _Mise4 = rd4.Next(10, ArgMax4);
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
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }

            else if (TourAdv5)
            {
                if (!Couché_5)
                {
                    if (!Misé)
                    {
                        await Task.Delay(100);
                        int ArgMax5 = ArgentAdv5 / 10;
                        Random rd5 = new Random();
                        _Mise5 = rd5.Next(10, ArgMax5);
                        ArgentAdv5 -= _Mise5;
                        total += _Mise5;
                        lblArgentAdversaire5.Text = TXArgent + ArgentAdv5;
                        labelTotal.Text = TXArgent + total;
                        lblAdv5.BackColor = Color.Transparent;
                        lblActAdv5.Text = strMise + _Mise5;
                        mises.Add(_Mise5);
                        TourAdv5 = false;
                        TourAdv6 = true;
                        WhoIsPlaying();
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }

            else if (TourAdv6)
            {
                if (!Couché_6)
                {
                    if (!Misé)
                    {
                        await Task.Delay(100);
                        int ArgMax6 = ArgentAdv6 / 10;
                        Random rd6 = new Random();
                        _Mise6 = rd6.Next(10, ArgMax6);
                        ArgentAdv6 -= _Mise6;
                        total += _Mise6;
                        lblArgentAdversaire6.Text = TXArgent + ArgentAdv6;
                        labelTotal.Text = TXArgent + total;
                        lblAdv6.BackColor = Color.Transparent;
                        lblActAdv6.Text = strMise + _Mise6;
                        mises.Add(_Mise6);
                        TourAdv6 = false;
                        TourAdv7 = true;
                        WhoIsPlaying();
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }

            else if (TourAdv7)
            {
                if (!Couché_7)
                {
                    if (!Misé)
                    {
                        await Task.Delay(100);
                        int ArgMax7 = ArgentAdv7 / 10;
                        Random rd7 = new Random();
                        _Mise7 = rd7.Next(10, ArgMax7);
                        ArgentAdv7 -= _Mise7;
                        total += _Mise7;
                        lblArgentAdversaire7.Text = TXArgent + ArgentAdv7;
                        labelTotal.Text = TXArgent + total;
                        lblAdv7.BackColor = Color.Transparent;
                        lblActAdv7.Text = strMise + _Mise7;
                        mises.Add(_Mise7);
                        TourAdv7 = false;
                        TourAdv8 = true;
                        WhoIsPlaying();
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }

            else if (TourAdv8)
            {
                if (!Couché_8)
                {
                    if (!Misé)
                    {
                        await Task.Delay(100);
                        int ArgMax8 = ArgentAdv8 / 10;
                        Random rd8 = new Random();
                        _Mise8 = rd8.Next(10, ArgMax8);
                        ArgentAdv8 -= _Mise8;
                        total += _Mise8;
                        lblArgentAdversaire8.Text = TXArgent + ArgentAdv8;
                        labelTotal.Text = TXArgent + total;
                        lblAdv3.BackColor = Color.Transparent;
                        lblActAdv8.Text = strMise + _Mise8;
                        mises.Add(_Mise8);
                        TourAdv8 = false;
                        TourJoueur = true;
                        WhoIsPlaying();
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }

        }

        public void Coucher()
        {
            if (Couché)
            {
                if (TourJoueur)
                {
                    pictureBoxJoueur1.Image = null;
                    pictureBoxJoueur2.Image = null;
                    lblActJoueur.Text = strCoucher;
                    Couché = true;
                    labelJoueur.BackColor = Color.Transparent;
                    TourJoueur = false;
                    TourAdv1 = true;
                    WhoIsPlaying();
                }

                else if (TourAdv1)
                {
                    pictureBoxAdv1_1.Image = null;
                    pictureBoxAdv1_2.Image = null;
                    lblActAdv1.Text = strCoucher;
                    Couché_1 = true;
                    lblAdv1.BackColor = Color.Transparent;
                    TourAdv1 = false;
                    TourAdv2 = true;
                }
             
            }
            else return;
        }

        public async void Suivre()
        {
            await Task.Delay(500);
            if (TourAdv1)
            {
                if (!Couché)
                {
                    TourJoueur = false;
                    TourAdv1 = true;
                    Round();
                    int max = mises.Max();
                    ArgentAdv1 -= max;
                    lblArgentAdversaire1.Text = TXArgent + ArgentAdv1;
                    //mises.Clear();
                    lblActAdv1.Text = strSuivre;
                    lblAdv1.BackColor = Color.Transparent;
                    TourAdv1 = false;
                    TourAdv2 = true;
                    WhoIsPlaying();
                }
            }

            else if (TourAdv2)
            {
                if (!Couché)
                {
                    Round();
                    int max = mises.Max();
                    ArgentAdv2 -= max;
                    lblArgentAdversaire2.Text = TXArgent + ArgentAdv2;
                    //mises.Clear();
                    lblActAdv2.Text = strSuivre;
                    lblAdv2.BackColor = Color.Transparent;
                    TourAdv2 = false;
                    TourAdv3 = true;
                    WhoIsPlaying();
                }
            }

            else if (TourAdv3)
            {
                if (!Couché)
                {
                    Round();
                    int max = mises.Max();
                    ArgentAdv3 -= max;
                    lblArgentAdversaire3.Text = TXArgent + ArgentAdv3;
                    //mises.Clear();
                    lblActAdv3.Text = strSuivre;
                    lblAdv3.BackColor = Color.Transparent;
                    TourAdv3 = false;
                    TourAdv4 = true;
                    WhoIsPlaying();
                }
            }

            else if (TourAdv4)
            {
                if (!Couché)
                {
                    Round();
                    int max = mises.Max();
                    ArgentAdv4 -= max;
                    lblArgentAdversaire4.Text = TXArgent + ArgentAdv4;
                    //mises.Clear();
                    lblActAdv4.Text = strSuivre;
                    lblAdv4.BackColor = Color.Transparent;
                    TourAdv4 = false;
                    TourAdv5 = true;
                    WhoIsPlaying();
                }
            }

            else if (TourAdv5)
            {
                if (!Couché)
                {
                    Round();
                    int max = mises.Max();
                    ArgentAdv5 -= max;
                    lblArgentAdversaire5.Text = TXArgent + ArgentAdv5;
                    //mises.Clear();
                    lblActAdv5.Text = strSuivre;
                    lblAdv5.BackColor = Color.Transparent;
                    TourAdv5 = false;
                    TourAdv6 = true;
                    WhoIsPlaying();
                }
            }

            else if (TourAdv6)
            {
                if (!Couché)
                {
                    Round();
                    int max = mises.Max();
                    ArgentAdv6 -= max;
                    lblArgentAdversaire6.Text = TXArgent + ArgentAdv6;
                    //mises.Clear();
                    lblActAdv6.Text = strSuivre;
                    lblAdv6.BackColor = Color.Transparent;
                    TourAdv6 = false;
                    TourAdv7 = true;
                    WhoIsPlaying();
                }
            }

            else if (TourAdv7)
            {
                if (!Couché)
                {
                    Round();
                    int max = mises.Max();
                    ArgentAdv7 -= max;
                    lblArgentAdversaire7.Text = TXArgent + ArgentAdv7;
                    //mises.Clear();
                    lblActAdv7.Text = strSuivre;
                    lblAdv7.BackColor = Color.Transparent;
                    TourAdv7 = false;
                    TourAdv7 = true;
                    WhoIsPlaying();
                }
            }

            else if (TourAdv8)
            {
                if (!Couché)
                {
                    Round();
                    int max = mises.Max();
                    ArgentAdv8 -= max;
                    lblArgentAdversaire6.Text = TXArgent + ArgentAdv8;
                    //mises.Clear();
                    lblActAdv8.Text = strSuivre;
                    lblAdv8.BackColor = Color.Transparent;
                    TourAdv8 = false;
                    TourJoueur = true;
                    WhoIsPlaying();
                }
            }

        }
    }
}