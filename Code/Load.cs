using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public partial class Play : Form
    {
        #region Valeurs
        int DefArgent = 1000;
        int ArgentJoueur, ArgentAdv1, ArgentAdv2, ArgentAdv3, ArgentAdv4, ArgentAdv5, ArgentAdv6, ArgentAdv7, ArgentAdv8;
        public string TXArgent = "Argent :";
        int ante = 100;
        int total;
        public bool Partie, check;
        #endregion

        void ArgentMin()
        {
            #region édition bal
            if (Partie == true)
            {
                ArgentJoueur -= ante;
                total += ante;
                ArgentAdv1 -= ante;
                total += ante;
                ArgentAdv2 -= ante;
                total += ante;
                ArgentAdv3 -= ante;
                total += ante;
                ArgentAdv4 -= ante;
                total += ante;
                ArgentAdv5 -= ante;
                total += ante;
                ArgentAdv6 -= ante;
                total += ante;
                ArgentAdv7 -= ante;
                total += ante;
                ArgentAdv8 -= ante;
                total += ante;

                labelTotal.Text = TXTotal + total;
                labelArgentJoueur.Text = TXArgent + ArgentJoueur;
                lblArgentAdversaire1.Text = TXArgent + ArgentAdv1;
                lblArgentAdversaire2.Text = TXArgent + ArgentAdv2;
                lblArgentAdversaire3.Text = TXArgent + ArgentAdv3;
                lblArgentAdversaire4.Text = TXArgent + ArgentAdv4;
                lblArgentAdversaire5.Text = TXArgent + ArgentAdv5;
                lblArgentAdversaire6.Text = TXArgent + ArgentAdv6;
                lblArgentAdversaire7.Text = TXArgent + ArgentAdv7;
                lblArgentAdversaire8.Text = TXArgent + ArgentAdv8;


                MoveJetons();
            }
            #endregion
        }

        void ChargerArgent()
        {
            #region Initialisation argent
            ArgentJoueur = DefArgent;
            ArgentAdv1 = DefArgent;
            ArgentAdv2 = DefArgent;
            ArgentAdv3 = DefArgent;
            ArgentAdv4 = DefArgent;
            ArgentAdv5 = DefArgent;
            ArgentAdv6 = DefArgent;
            ArgentAdv7 = DefArgent;
            ArgentAdv8 = DefArgent;
            #endregion

            lblArgentAdversaire1.Text = TXArgent + ArgentAdv1;
            lblArgentAdversaire2.Text = TXArgent + ArgentAdv2;
            lblArgentAdversaire3.Text = TXArgent + ArgentAdv3;
            lblArgentAdversaire4.Text = TXArgent + ArgentAdv4;
            lblArgentAdversaire5.Text = TXArgent + ArgentAdv5;
            lblArgentAdversaire6.Text = TXArgent + ArgentAdv6;
            lblArgentAdversaire7.Text = TXArgent + ArgentAdv7;
            lblArgentAdversaire8.Text = TXArgent + ArgentAdv8;
            labelArgentJoueur.Text = TXArgent + ArgentJoueur;
        }

        void ChargerCartes()
        {
            DistrCards();
        }

        void LoadVars()
        {
            Couché = false; Couché_1 = false; Couché_2 = false; Couché_3 = false; Couché_4 = false; Couché_5 = false; Couché_6 = false; Couché_7 = false; Couché_8 = false;
        }
    }
}

