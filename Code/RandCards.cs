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
        #region Figures
        public static Symb Coeurs { get; private set; }
        public static Symb Trefles { get; private set; }
        public static Symb Carreaux { get; private set; }
        public static Symb Piques { get; private set; }
        #endregion

        #region Valeurs Définition

        #endregion

        Random random = new Random();

        List<int> CartesUtilisees = new List<int>();

        List<Cartes> ListeCartes = new List<Cartes>()
        {
            new Cartes() { Valeur  = 0, Image = "null" }
        };

        #region Arriere
        List<Cartes> arriere = new List<Cartes>()
        {
            new Cartes{Valeur = 0, Image = "C:\\Users\\User\\Desktop\\Dev\\C#\\BlackJack\\BlackJack\\img\\cartes\\gray_back.png" }
        };
        #endregion

        #region 52Cartes

        List<Cartes> jeu = new List<Cartes>()
        {
            #region Coeurs //Liste des cartes de coeur

            new Cartes() {ID = 1, Valeur  = Rank.Deux, Grade = Coeurs, Image = Environment.CurrentDirectory + "\\img\\2H.png"},
            new Cartes() {ID = 2, Valeur  = Rank.Trois, Grade = Coeurs, Image = Environment.CurrentDirectory + "\\img\\3H.png"},
            new Cartes() {ID = 3, Valeur  = Rank.Quatre, Grade = Coeurs, Image =Environment.CurrentDirectory + "\\img\\4H.png"},
            new Cartes() {ID = 4, Valeur  = Rank.Cinq, Grade = Coeurs, Image =Environment.CurrentDirectory + "\\img\\5H.png"},
            new Cartes() {ID = 5, Valeur  = Rank.Six, Grade = Coeurs, Nom = "6 de coeur", Image =Environment.CurrentDirectory + "\\img\\6H.png"},
            new Cartes() {ID = 6, Valeur  = Rank.Sept, Grade = Coeurs, Nom = "7 de coeur", Image =Environment.CurrentDirectory + "\\img\\7H.png"},
            new Cartes() {ID = 7, Valeur  = Rank.Huit, Grade = Coeurs, Nom = "8 de coeur", Image =Environment.CurrentDirectory + "\\img\\8H.png"},
            new Cartes() {ID = 8, Valeur  = Rank.Neuf, Grade = Coeurs, Nom = "9 de coeur", Image =Environment.CurrentDirectory + "\\img\\9H.png"},
            new Cartes() {ID = 9, Valeur  = Rank.Dix, Grade = Coeurs, Nom = "10 de coeur", Image =Environment.CurrentDirectory + "\\img\\10H.png"},
            new Cartes() {ID = 10, Valeur  = Rank.Valet, Grade = Coeurs, Nom = "Valet de coeur", Image = Environment.CurrentDirectory +"\\img\\JH.png" },
            new Cartes() {ID = 11, Valeur  = Rank.Reine, Grade = Coeurs, Nom = "Reine de coeur", Image = Environment.CurrentDirectory + "\\img\\QH.png" },
            new Cartes() {ID = 12, Valeur  = Rank.Roi, Grade = Coeurs, Nom = "Roi de coeur", Image = Environment.CurrentDirectory + "\\img\\KH.png" },
            new Cartes() {ID = 13, Valeur  = Rank.As, Grade = Coeurs, Nom = "As de coeur", Image = Environment.CurrentDirectory + "\\img\\AH.png" },

            #endregion

            #region Trefles //Liste des cartes de ID = 14,

            new Cartes() {ID = 14, Valeur  = Rank.Deux, Grade = Trefles, Nom = "2 de trèfle", Image  = Environment.CurrentDirectory + "\\img\\2C.png" },
            new Cartes() {ID = 15, Valeur  = Rank.Trois, Grade = Trefles, Nom = "3 de trèfle", Image = Environment.CurrentDirectory + "\\img\\3C.png" },
            new Cartes() {ID = 16, Valeur  = Rank.Quatre, Grade = Trefles, Nom = "4 de trèfle", Image = Environment.CurrentDirectory + "\\img\\4C.png" },
            new Cartes() {ID = 17, Valeur  = Rank.Cinq, Grade = Trefles, Nom = "5 de trèfle", Image = Environment.CurrentDirectory + "\\img\\5C.png" },
            new Cartes() {ID = 18, Valeur  = Rank.Six, Grade = Trefles, Nom = "6 de trèfle", Image = Environment.CurrentDirectory + "\\img\\6C.png" },
            new Cartes() {ID = 19, Valeur  = Rank.Sept, Grade = Trefles, Nom = "7 de trèfle", Image = Environment.CurrentDirectory + "\\img\\7C.png" },
            new Cartes() {ID = 20, Valeur  = Rank.Huit, Grade = Trefles, Nom = "8 de trèfle", Image = Environment.CurrentDirectory +"\\img\\8C.png" },
            new Cartes() {ID = 21, Valeur  = Rank.Neuf, Grade = Trefles, Nom = "9 de trèfle", Image = Environment.CurrentDirectory + "\\img\\9C.png" },
            new Cartes() {ID = 22, Valeur  = Rank.Dix, Grade = Trefles, Nom = "10 de trèfle", Image = Environment.CurrentDirectory + "\\img\\10C.png" },
            new Cartes() {ID = 23, Valeur  = Rank.Valet, Grade = Trefles, Nom = "Valet de trèfle", Image = Environment.CurrentDirectory + "\\img\\JC.png" },
            new Cartes() {ID = 24, Valeur  = Rank.Reine, Grade = Trefles, Nom = "Reine de trèfle", Image = Environment.CurrentDirectory + "\\img\\QC.png" },
            new Cartes() {ID = 25, Valeur  = Rank.Roi, Grade = Trefles, Nom = "Roi de trèfle", Image = Environment.CurrentDirectory + "\\img\\KC.png" },
            new Cartes() {ID = 26, Valeur  = Rank.As, Grade = Trefles, Nom = "As de trèfle", Image = Environment.CurrentDirectory + "\\img\\AC.png" },

            #endregion

            #region Carreaux //Liste des cartes de carreaux

            new Cartes() {ID = 27, Valeur  = Rank.Deux, Grade = Carreaux, Nom = "2 de carreaux", Image = Environment.CurrentDirectory + "\\img\\2D.png" },
            new Cartes() {ID = 28, Valeur  = Rank.Trois, Grade = Carreaux, Nom = "3 de carreaux", Image = Environment.CurrentDirectory + "\\img\\3D.png" },
            new Cartes() {ID = 29, Valeur  = Rank.Quatre, Grade = Carreaux, Nom = "4 de carreaux", Image = Environment.CurrentDirectory + "\\img\\4D.png" },
            new Cartes() {ID = 30, Valeur  = Rank.Cinq, Grade = Carreaux, Nom = "5 de carreaux", Image = Environment.CurrentDirectory + "\\img\\5D.png" },
            new Cartes() {ID = 31, Valeur  = Rank.Six, Grade = Carreaux, Nom = "6 de carreaux", Image = Environment.CurrentDirectory + "\\img\\6D.png" },
            new Cartes() {ID = 32, Valeur  = Rank.Sept, Grade = Carreaux, Nom = "7 de carreaux", Image = Environment.CurrentDirectory + "\\img\\7D.png" },
            new Cartes() {ID = 33, Valeur  = Rank.Huit, Grade = Carreaux, Nom = "8 de carreaux", Image = Environment.CurrentDirectory + "\\img\\8D.png" },
            new Cartes() {ID = 34, Valeur  = Rank.Neuf, Grade = Carreaux, Nom = "9 de carreaux", Image = Environment.CurrentDirectory + "\\img\\9D.png" },
            new Cartes() {ID = 35, Valeur  = Rank.Dix, Grade = Carreaux, Nom = "10 de carreaux", Image = Environment.CurrentDirectory + "\\img\\10D.png" },
            new Cartes() {ID = 36, Valeur  = Rank.Valet, Grade = Carreaux, Nom = "Valet de carreaux", Image = Environment.CurrentDirectory + "\\img\\JD.png" },
            new Cartes() {ID = 37, Valeur  = Rank.Reine, Grade = Carreaux, Nom = "Reine de carreaux", Image = Environment.CurrentDirectory + "\\img\\QD.png" },
            new Cartes() {ID = 38, Valeur  = Rank.Roi, Grade = Carreaux, Nom = "Roi de carreaux", Image = Environment.CurrentDirectory + "\\img\\KD.png" },
            new Cartes() {ID = 39, Valeur  = Rank.As, Grade = Carreaux, Nom = "As de carreaux", Image = Environment.CurrentDirectory + "\\img\\AD.png" },

            #endregion

            #region Piques //Liste des cartes de piques

            new Cartes() {ID = 40, Valeur  = Rank.Deux, Grade = Piques, Nom = "2 de piques", Image = Environment.CurrentDirectory + "\\img\\2S.png" },
            new Cartes() {ID = 41, Valeur  = Rank.Trois, Grade = Piques, Nom = "3 de piques", Image = Environment.CurrentDirectory + "\\img\\3S.png" },
            new Cartes() {ID = 42, Valeur  = Rank.Quatre, Grade = Piques, Nom = "4 de piques", Image = Environment.CurrentDirectory + "\\img\\4S.png" },
            new Cartes() {ID = 43, Valeur  = Rank.Cinq, Grade = Piques, Nom = "5 de piques", Image = Environment.CurrentDirectory + "\\img\\5S.png" },
            new Cartes() {ID = 44, Valeur  = Rank.Six, Grade = Piques, Nom = "6 de piques", Image = Environment.CurrentDirectory + "\\img\\6S.png" },
            new Cartes() {ID = 45, Valeur  = Rank.Sept, Grade = Piques, Nom = "7 de piques", Image = Environment.CurrentDirectory + "\\img\\7S.png" },
            new Cartes() {ID = 46, Valeur  = Rank.Huit, Grade = Piques, Nom = "8 de piques", Image = Environment.CurrentDirectory + "\\img\\8S.png" },
            new Cartes() {ID = 47, Valeur  = Rank.Neuf, Grade = Piques, Nom = "9 de piques", Image = Environment.CurrentDirectory + "\\img\\9S.png" },
            new Cartes() {ID = 48, Valeur  = Rank.Dix, Grade = Piques, Nom = "10 de piques", Image = Environment.CurrentDirectory + "\\img\\10S.png" },
            new Cartes() {ID = 49, Valeur  = Rank.Valet, Grade = Piques, Nom = "Valet de piques", Image = Environment.CurrentDirectory + "\\img\\JS.png" },
            new Cartes() {ID = 50, Valeur  = Rank.Reine, Grade = Piques, Nom = "Reine de piques", Image = Environment.CurrentDirectory + "\\img\\QS.png" },
            new Cartes() {ID = 51, Valeur  = Rank.Roi, Nom = "Roi de piques", Image = Environment.CurrentDirectory + "\\img\\KS.png" },
            new Cartes() {ID = 52, Valeur  = Rank.As, Nom = "As de piques", Image = Environment.CurrentDirectory + "\\img\\AD.png" },
            #endregion
        };
        #endregion

        private int CarteAleatoire()
        {
            int carteAlea;
            carteAlea = random.Next(0, jeu.Count); //génère entre 52 cartes
            return carteAlea;
        }


        public void GenCartesAdv()
        {
            int Carte = CarteAleatoire();
            Cartes carte = jeu[Carte];
            CartesUtilisees.Add(Carte);

            while (CartesUtilisees.Contains(Carte))
            {
                Carte = CarteAleatoire();
            }
            Carte = 1 * Carte;

            ListeCartes.Add(carte);

            if (Distrib && distj1)
            {
                if (SecondDistr == false)
                {
                    pictureBoxJoueur1.ImageLocation = carte.Image;
                }
                else
                {
                    Carte = CarteAleatoire();
                    CartesUtilisees.Add(Carte);
                    while (CartesUtilisees.Contains(Carte))
                    {
                        Carte = CarteAleatoire();
                    }
                    Carte = 1 * Carte;
                    ListeCartes.Add(carte);
                    pictureBoxJoueur2.ImageLocation = carte.Image;
                }
            }

            #region Adversaire 1
            Carte = CarteAleatoire();
            CartesUtilisees.Add(Carte);
            while (CartesUtilisees.Contains(Carte))
            {
                Carte = CarteAleatoire();
            }
            Carte = 1 * Carte;
            ListeCartes.Add(carte);

            if (Distrib && dist1_1)
            {
                if (SecondDistr == false)
                {
                    pictureBoxAdv1_1.ImageLocation = carte.Image;
                }
                else
                {
                    Carte = CarteAleatoire();
                    CartesUtilisees.Add(Carte);
                    while (CartesUtilisees.Contains(Carte))
                    {
                        Carte = CarteAleatoire();
                    }
                    Carte = 1 * Carte;
                    ListeCartes.Add(carte);
                    pictureBoxAdv1_2.ImageLocation = carte.Image;
                }
            }
            #endregion

            #region Adversaire 2
            Carte = CarteAleatoire();
            CartesUtilisees.Add(Carte);

            while (CartesUtilisees.Contains(Carte))
            {
                Carte = CarteAleatoire();
            }
            Carte = 1 * Carte;

            ListeCartes.Add(carte);

            if (Distrib && dist2_1)
            {
                if (SecondDistr == false)
                {
                    pictureBoxAdv2_1.ImageLocation = carte.Image;
                }
                else
                {
                    Carte = CarteAleatoire();
                    CartesUtilisees.Add(Carte);
                    while (CartesUtilisees.Contains(Carte))
                    {
                        Carte = CarteAleatoire();
                    }
                    Carte = 1 * Carte;
                    ListeCartes.Add(carte);
                    pictureBoxAdv2_2.ImageLocation = carte.Image;
                }
            }
            #endregion

            #region Adversaire 3
            Carte = CarteAleatoire();
            CartesUtilisees.Add(Carte);

            while (CartesUtilisees.Contains(Carte))
            {
                Carte = CarteAleatoire();
            }
            Carte = 1 * Carte;

            if (Distrib && dist3_1)
            {
                if (SecondDistr == false)
                {
                    pictureBoxAdv3_1.ImageLocation = carte.Image;
                }
                else
                {
                    CartesUtilisees.Add(Carte);
                    while (CartesUtilisees.Contains(Carte))
                    {
                        Carte = CarteAleatoire();
                    }
                    Carte = 1 * Carte;
                    ListeCartes.Add(carte);
                    pictureBoxAdv3_2.ImageLocation = carte.Image;
                }
            }
            #endregion

            #region Adversaire 4
            Carte = CarteAleatoire();
            CartesUtilisees.Add(Carte);

            while (CartesUtilisees.Contains(Carte))
            {
                Carte = CarteAleatoire();
            }
            Carte = 1 * Carte;
            ListeCartes.Add(carte);

            if (Distrib && dist4_1)
            {
                if (SecondDistr == false)
                {
                    pictureBoxAdv4_1.ImageLocation = carte.Image;
                }
                else
                {
                    Carte = CarteAleatoire();
                    CartesUtilisees.Add(Carte);
                    while (CartesUtilisees.Contains(Carte))
                    {
                        Carte = CarteAleatoire();
                    }
                    Carte = 1 * Carte;
                    ListeCartes.Add(carte);
                    pictureBoxAdv4_2.ImageLocation = carte.Image;
                }

            }
            #endregion

            #region Adversaire 5
            Carte = CarteAleatoire();
            CartesUtilisees.Add(Carte);

            while (CartesUtilisees.Contains(Carte))
            {
                Carte = CarteAleatoire();
            }
            Carte = 1 * Carte;
            ListeCartes.Add(carte);

            if (Distrib && dist5_1)
            {
                if (SecondDistr == false)
                {
                    pictureBoxAdv5_1.ImageLocation = carte.Image;
                }
                else
                {
                    Carte = CarteAleatoire();
                    CartesUtilisees.Add(Carte);
                    while (CartesUtilisees.Contains(Carte))
                    {
                        Carte = CarteAleatoire();
                    }
                    Carte = 1 * Carte;
                    ListeCartes.Add(carte);
                    pictureBoxAdv5_2.ImageLocation = carte.Image;
                }
            }
            #endregion

            #region Adversaire 6
            Carte = CarteAleatoire();
            CartesUtilisees.Add(Carte);

            while (CartesUtilisees.Contains(Carte))
            {
                Carte = CarteAleatoire();
            }
            Carte = 1 * Carte;

            ListeCartes.Add(carte);

            if (Distrib && dist6_1)
            {
                if (SecondDistr == false)
                {
                    pictureBoxAdv6_1.ImageLocation = carte.Image;
                }
                else
                {
                    Carte = CarteAleatoire();
                    CartesUtilisees.Add(Carte);
                    while (CartesUtilisees.Contains(Carte))
                    {
                        Carte = CarteAleatoire();
                    }
                    Carte = 1 * Carte;
                    ListeCartes.Add(carte);
                    pictureBoxAdv6_2.ImageLocation = carte.Image;
                }
            }
            #endregion

            #region Adversaire 7
            Carte = CarteAleatoire();
            CartesUtilisees.Add(Carte);

            while (CartesUtilisees.Contains(Carte))
            {
                Carte = CarteAleatoire();
            }
            Carte = 1 * Carte;
            ListeCartes.Add(carte);

            if (Distrib && dist7_1)
            {
                if (SecondDistr == false)
                {
                    pictureBoxAdv7_1.ImageLocation = carte.Image;
                }
                else
                {
                    Carte = CarteAleatoire();
                    CartesUtilisees.Add(Carte);
                    while (CartesUtilisees.Contains(Carte))
                    {
                        Carte = CarteAleatoire();
                    }
                    Carte = 1 * Carte;
                    ListeCartes.Add(carte);
                    pictureBoxAdv7_2.ImageLocation = carte.Image;
                }
            }
            #endregion

            #region Adversaire 8
            Carte = CarteAleatoire();
            CartesUtilisees.Add(Carte);

            while (CartesUtilisees.Contains(Carte))
            {
                Carte = CarteAleatoire();
            }
            Carte = 1 * Carte;
            ListeCartes.Add(carte);

            if (Distrib && dist8_1)
            {
                if (SecondDistr == false)
                {
                    pictureBoxAdv8_1.ImageLocation = carte.Image;
                }
                else
                {
                    Carte = CarteAleatoire();
                    CartesUtilisees.Add(Carte);
                    while (CartesUtilisees.Contains(Carte))
                    {
                        Carte = CarteAleatoire();
                    }
                    Carte = 1 * Carte;
                    ListeCartes.Add(carte);
                    pictureBoxAdv8_2.ImageLocation = carte.Image;
                }
            }

            #endregion
        }
    }
}