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
            if(Partie == true)
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

        void ChargerPrenoms()
        {
            var Noms = new List<string> { 
            "Asha",
            "Aliza",
            "Tolga ",
            "Chenai ",
            "Alton ",
            "Remi ",
            "Liucijus",
            "Tadas",
            "Haroon ",
            "Kadeem ",
            "Sebastian ",
            "Gavin ",
            "Kohen ",
            "Jennifer ",
            "Lilly ",
            "Franklin ",
            "Mohsin ",
            "Susie ",
            "Theodore ",
            "Ebonie ","Amaya ", "Morwenna ",
            "Annie","Louisa ","Linda ","Cassie","Lachlan "};

            #region Noms
            var NomsUtilises = new List<string> { };
            Random nameRand1 = new Random();
            int randN1 = nameRand1.Next(Noms.Count);
            NomsUtilises.Add(Noms[randN1]);
            while (NomsUtilises.Contains(Noms[randN1]))
            {
                nameRand1 = new Random();
                randN1 = nameRand1.Next(Noms.Count);
            }
            lblAdv1.Text = Noms[randN1];

            Random nameRand2 = new Random();
            int randN2 = nameRand2.Next(Noms.Count);
            NomsUtilises.Add(Noms[randN2]);
            while (NomsUtilises.Contains(Noms[randN2]))
            {
                nameRand2 = new Random();
                randN2 = nameRand2.Next(Noms.Count);
            }
            lblAdv2.Text = Noms[randN2];

            Random nameRand3 = new Random();
            int randN3 = nameRand3.Next(Noms.Count);
            NomsUtilises.Add(Noms[randN3]);
            while (NomsUtilises.Contains(Noms[randN3]))
            {
                nameRand3 = new Random();
                randN3 = nameRand3.Next(Noms.Count);
            }
            lblAdv3.Text = Noms[randN3];

            Random nameRand4 = new Random();
            int randN4 = nameRand4.Next(Noms.Count);
            NomsUtilises.Add(Noms[randN4]);
            while (NomsUtilises.Contains(Noms[randN4]))
            {
                nameRand4 = new Random();
                randN4 = nameRand4.Next(Noms.Count);
            }
            lblAdv4.Text = Noms[randN4];

            Random nameRand5 = new Random();
            int randN5 = nameRand5.Next(Noms.Count);
            NomsUtilises.Add(Noms[randN5]);
            while (NomsUtilises.Contains(Noms[randN5]))
            {
                nameRand5 = new Random();
                randN5 = nameRand5.Next(Noms.Count);
            }
            lblAdv5.Text = Noms[randN5];

            Random nameRand6 = new Random();
            int randN6 = nameRand6.Next(Noms.Count);
            NomsUtilises.Add(Noms[randN6]);
            while (NomsUtilises.Contains(Noms[randN6]))
            {
                nameRand6 = new Random();
                randN6 = nameRand6.Next(Noms.Count);
            }
            lblAdv6.Text = Noms[randN6];

            Random nameRand7 = new Random();
            int randN7 = nameRand7.Next(Noms.Count);
            NomsUtilises.Add(Noms[randN7]);
            while (NomsUtilises.Contains(Noms[randN7]))
            {
                nameRand7 = new Random();
                randN7 = nameRand7.Next(Noms.Count);
            }
            lblAdv7.Text = Noms[randN7];

            Random nameRand8 = new Random();
            int randN8 = nameRand8.Next(Noms.Count);
            NomsUtilises.Add(Noms[randN8]);
            while (NomsUtilises.Contains(Noms[randN8]))
            {
                nameRand8 = new Random();
                randN8 = nameRand8.Next(Noms.Count);
            }
            lblAdv8.Text = Noms[randN8];

        }
        #endregion

    }
}

