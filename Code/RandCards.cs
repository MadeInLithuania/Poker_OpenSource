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
        Random random = new Random();

        List<int>CartesUtilisees = new List<int>();

        List<Cartes>ListeCartes = new List<Cartes>()
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

            new Cartes() {ID = 1, Valeur  = 2, Image = Environment.CurrentDirectory + "\\img\\2H.png"},
            new Cartes() {ID = 2, Valeur  = 3,  Image = Environment.CurrentDirectory + "\\img\\3H.png"},
            new Cartes() {ID = 3, Valeur  = 4,  Image =Environment.CurrentDirectory + "\\img\\4H.png"},
            new Cartes() {ID = 4, Valeur  = 5,  Image =Environment.CurrentDirectory + "\\img\\5H.png"},
            new Cartes() {ID = 5, Valeur  = 6, Nom = "6 de coeur", Image =Environment.CurrentDirectory + "\\img\\6H.png"},
            new Cartes() {ID = 6, Valeur  = 7, Nom = "7 de coeur", Image =Environment.CurrentDirectory + "\\img\\7H.png"},
            new Cartes() {ID = 7, Valeur  = 8, Nom = "8 de coeur", Image =Environment.CurrentDirectory + "\\img\\8H.png"},
            new Cartes() {ID = 8, Valeur  = 9, Nom = "9 de coeur", Image =Environment.CurrentDirectory + "\\img\\9H.png"},
            new Cartes() {ID = 9, Valeur  = 10, Nom = "10 de coeur", Image =Environment.CurrentDirectory + "\\img\\10H.png"},
            new Cartes() {ID = 10, Valeur  = 11, Nom = "Valet de coeur", Image = Environment.CurrentDirectory +"\\img\\JH.png" },
            new Cartes() {ID = 11, Valeur  = 12, Nom = "Reine de coeur", Image = Environment.CurrentDirectory + "\\img\\QH.png" },
            new Cartes() {ID = 12, Valeur  = 13, Nom = "Roi de coeur", Image = Environment.CurrentDirectory + "\\img\\KH.png" },
            new Cartes() {ID = 13, Valeur  = 14, Nom = "As de coeur", Image = Environment.CurrentDirectory + "\\img\\AH.png" },

            #endregion

            #region Trefles //Liste des cartes de ID = 14,

            new Cartes() {ID = 14, Valeur  = 2, Nom = "2 de trèfle", Image  = Environment.CurrentDirectory + "\\img\\2C.png" },
            new Cartes() {ID = 15, Valeur  = 3, Nom = "3 de trèfle", Image = Environment.CurrentDirectory + "\\img\\3C.png" },
            new Cartes() {ID = 16, Valeur  = 4, Nom = "4 de trèfle", Image = Environment.CurrentDirectory + "\\img\\4C.png" },
            new Cartes() {ID = 17, Valeur  = 5, Nom = "5 de trèfle", Image = Environment.CurrentDirectory + "\\img\\5C.png" },
            new Cartes() {ID = 18, Valeur  = 6, Nom = "6 de trèfle", Image = Environment.CurrentDirectory + "\\img\\6C.png" },
            new Cartes() {ID = 19, Valeur  = 7, Nom = "7 de trèfle", Image = Environment.CurrentDirectory + "\\img\\7C.png" },
            new Cartes() {ID = 20, Valeur  = 8, Nom = "8 de trèfle", Image = Environment.CurrentDirectory +"\\img\\8C.png" },
            new Cartes() {ID = 21, Valeur  = 9, Nom = "9 de trèfle", Image = Environment.CurrentDirectory + "\\img\\9C.png" },
            new Cartes() {ID = 22, Valeur  = 10, Nom = "10 de trèfle", Image = Environment.CurrentDirectory + "\\img\\10C.png" },
            new Cartes() {ID = 23, Valeur  = 11, Nom = "Valet de trèfle", Image = Environment.CurrentDirectory + "\\img\\JC.png" },
            new Cartes() {ID = 24, Valeur  = 12, Nom = "Reine de trèfle", Image = Environment.CurrentDirectory + "\\img\\QC.png" },
            new Cartes() {ID = 25, Valeur  = 13, Nom = "Roi de trèfle", Image = Environment.CurrentDirectory + "\\img\\KC.png" },
            new Cartes() {ID = 26, Valeur  = 14, Nom = "As de trèfle", Image = Environment.CurrentDirectory + "\\img\\AC.png" },

            #endregion

            #region Carreaux //Liste des cartes de carreaux

            new Cartes() {ID = 27, Valeur  = 2, Nom = "2 de carreaux", Image = Environment.CurrentDirectory + "\\img\\2D.png" },
            new Cartes() {ID = 28, Valeur  = 3, Nom = "3 de carreaux", Image = Environment.CurrentDirectory + "\\img\\3D.png" },
            new Cartes() {ID = 29, Valeur  = 4, Nom = "4 de carreaux", Image = Environment.CurrentDirectory + "\\img\\4D.png" },
            new Cartes() {ID = 30, Valeur  = 5, Nom = "5 de carreaux", Image = Environment.CurrentDirectory + "\\img\\5D.png" },
            new Cartes() {ID = 31, Valeur  = 6, Nom = "6 de carreaux", Image = Environment.CurrentDirectory + "\\img\\6D.png" },
            new Cartes() {ID = 32, Valeur  = 7, Nom = "7 de carreaux", Image = Environment.CurrentDirectory + "\\img\\7D.png" },
            new Cartes() {ID = 33, Valeur  = 7, Nom = "8 de carreaux", Image = Environment.CurrentDirectory + "\\img\\8D.png" },
            new Cartes() {ID = 34, Valeur  = 9, Nom = "9 de carreaux", Image = Environment.CurrentDirectory + "\\img\\9D.png" },
            new Cartes() {ID = 35, Valeur  = 10, Nom = "10 de carreaux", Image = Environment.CurrentDirectory + "\\img\\10D.png" },
            new Cartes() {ID = 36, Valeur  = 11, Nom = "Valet de carreaux", Image = Environment.CurrentDirectory + "\\img\\JD.png" },
            new Cartes() {ID = 37, Valeur  = 12, Nom = "Reine de carreaux", Image = Environment.CurrentDirectory + "\\img\\QD.png" },
            new Cartes() {ID = 38, Valeur  = 13, Nom = "Roi de carreaux", Image = Environment.CurrentDirectory + "\\img\\KD.png" },
            new Cartes() {ID = 39, Valeur  = 14, Nom = "As de carreaux", Image = Environment.CurrentDirectory + "\\img\\AD.png" },

            #endregion

            #region Piques //Liste des cartes de piques

            new Cartes() {ID = 40, Valeur  = 2, Nom = "2 de piques", Image = Environment.CurrentDirectory + "\\img\\2S.png" },
            new Cartes() {ID = 41, Valeur  = 3, Nom = "3 de piques", Image = Environment.CurrentDirectory + "\\img\\3S.png" },
            new Cartes() {ID = 42, Valeur  = 4, Nom = "4 de piques", Image = Environment.CurrentDirectory + "\\img\\4S.png" },
            new Cartes() {ID = 43, Valeur  = 5, Nom = "5 de piques", Image = Environment.CurrentDirectory + "\\img\\5S.png" },
            new Cartes() {ID = 44, Valeur  = 6, Nom = "6 de piques", Image = Environment.CurrentDirectory + "\\img\\6S.png" },
            new Cartes() {ID = 45, Valeur  = 7, Nom = "7 de piques", Image = Environment.CurrentDirectory + "\\img\\7S.png" },
            new Cartes() {ID = 46, Valeur  = 8, Nom = "8 de piques", Image = Environment.CurrentDirectory + "\\img\\8S.png" },
            new Cartes() {ID = 47, Valeur  = 9, Nom = "9 de piques", Image = Environment.CurrentDirectory + "\\img\\9S.png" },
            new Cartes() {ID = 48, Valeur  = 10, Nom = "10 de piques", Image = Environment.CurrentDirectory + "\\img\\10S.png" },
            new Cartes() {ID = 49, Valeur  = 11, Nom = "Valet de piques", Image = Environment.CurrentDirectory + "\\img\\JS.png" },
            new Cartes() {ID = 50, Valeur  = 12, Nom = "Reine de piques", Image = Environment.CurrentDirectory + "\\img\\QS.png" },
            new Cartes() {ID = 51, Valeur  = 13, Nom = "Roi de piques", Image = Environment.CurrentDirectory + "\\img\\KS.png" },
            new Cartes() {ID = 52, Valeur  = 14, Nom = "As de piques", Image = Environment.CurrentDirectory + "\\img\\AD.png" },
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
                Carte= CarteAleatoire();
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
                Carte= CarteAleatoire();
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
                if(SecondDistr == false)
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

        public void DebugDistr()
        {
            /*#region Adversaire 1
            int CarteAleaA1 = CarteAleatoire();
            Cartes carteA1 = jeu[CarteAleaA1];
            CartesUtilisees.Add(CarteAleaA1);
            int CarteAleaA1_2 = CarteAleatoire();

            while (CartesUtilisees.Contains(CarteAleaA1_2))
            {
                CarteAleaA1_2 = CarteAleatoire();
            }
            CarteAleaA1_2 = 1 * CarteAleaA1_2;
            ListeCartes.Add(carteA1);

            if (Distrib && dist1_1)
            {
                if (SecondDistr == false)
                {
                    pictureBoxAdv1_1.ImageLocation = carteA1.Image;
                }

                else
                {
                    Cartes carteA1_2 = jeu[CarteAleaA1_2];
                    CartesUtilisees.Add(CarteAleaA1_2);
                    ListeCartes.Add(carteA1_2);
                    pictureBoxAdv1_2.ImageLocation = carteA1_2.Image;
                }
            }
            #endregion

            #region Adversaire 2
            int CarteAleaA2 = CarteAleatoire();
            Cartes carteA2 = jeu[CarteAleaA2];
            CartesUtilisees.Add(CarteAleaA2);
            int CarteAleaA2_2 = CarteAleatoire();

            while (CartesUtilisees.Contains(CarteAleaA2_2))
            {
                CarteAleaA2_2 = CarteAleatoire();
            }
            CarteAleaA2_2 = 1 * CarteAleaA2_2;

            ListeCartes.Add(carteA2);

            if (Distrib && dist2_1)
            {
                if (SecondDistr == false)
                {
                    pictureBoxAdv2_1.ImageLocation = carteA2.Image;
                }

                else
                {
                    Cartes carteA2_2 = jeu[CarteAleaA2_2];
                    CartesUtilisees.Add(CarteAleaA2_2);
                    ListeCartes.Add(carteA2_2);
                    pictureBoxAdv2_2.ImageLocation = carteA2_2.Image;
                }
            }
            #endregion

            #region Adversaire 3
            int CarteAleaA3 = CarteAleatoire();
            Cartes carteA3 = jeu[CarteAleaA3];
            CartesUtilisees.Add(CarteAleaA3);
            int CarteAleaA3_2 = CarteAleatoire();

            while (CartesUtilisees.Contains(CarteAleaA3_2))
            {
                CarteAleaA3_2 = CarteAleatoire();
            }
            CarteAleaA3_2 = 1 * CarteAleaA3_2;

            if (Distrib && dist3_1)
            {
                if (SecondDistr == false)
                {
                    pictureBoxAdv3_1.ImageLocation = carteA3.Image;
                }

                else
                {
                    Cartes carteA3_2 = jeu[CarteAleaA3_2];
                    CartesUtilisees.Add(CarteAleaA3_2);
                    ListeCartes.Add(carteA3_2);
                    pictureBoxAdv3_2.ImageLocation = carteA3_2.Image;
                }
            }
            #endregion

            #region Adversaire 4
            int CarteAleaA4 = CarteAleatoire();
            Cartes carteA4 = jeu[CarteAleaA4];
            CartesUtilisees.Add(CarteAleaA4);
            int CarteAleaA4_2 = CarteAleatoire();

            while (CartesUtilisees.Contains(CarteAleaA4_2))
            {
                CarteAleaA4_2 = CarteAleatoire();
            }
            CarteAleaA4_2 = 1 * CarteAleaA4_2;
            ListeCartes.Add(carteA4);

            if (Distrib && dist4_1)
            {
                if (SecondDistr == false)
                {
                    pictureBoxAdv4_1.ImageLocation = carteA4.Image;
                }

                else
                {
                    Cartes carteA4_2 = jeu[CarteAleaA4_2];
                    CartesUtilisees.Add(CarteAleaA4_2);
                    ListeCartes.Add(carteA4_2);
                    pictureBoxAdv4_2.ImageLocation = carteA4_2.Image;
                }

            }
            #endregion

            #region Adversaire 5
            int CarteAleaA5 = CarteAleatoire();
            Cartes carteA5 = jeu[CarteAleaA5];
            CartesUtilisees.Add(CarteAleaA5);
            int CarteAleaA5_2 = CarteAleatoire();

            while (CartesUtilisees.Contains(CarteAleaA5_2))
            {
                CarteAleaA5_2 = CarteAleatoire();
            }
            CarteAleaA5_2 = 1 * CarteAleaA5_2;
            ListeCartes.Add(carteA5);

            if (Distrib && dist5_1)
            {
                if (SecondDistr == false)
                {
                    pictureBoxAdv5_1.ImageLocation = carteA5.Image;
                }

                else
                {
                    Cartes carteA5_2 = jeu[CarteAleaA5_2];
                    CartesUtilisees.Add(CarteAleaA5_2);
                    ListeCartes.Add(carteA5_2);
                    pictureBoxAdv5_2.ImageLocation = carteA5_2.Image;
                }
                #endregion
            }
            #region Adversaire 6
            int CarteAleaA6 = CarteAleatoire();
            Cartes carteA6 = jeu[CarteAleaA6];
            CartesUtilisees.Add(CarteAleaA6);
            int CarteAleaA6_2 = CarteAleatoire();

            while (CartesUtilisees.Contains(CarteAleaA6_2))
            {
                CarteAleaA6_2 = CarteAleatoire();
            }
            CarteAleaA6_2 = 1 * CarteAleaA6_2;

            ListeCartes.Add(carteA6);

            if (Distrib && dist6_1)
            {
                if (SecondDistr == false)
                {
                    pictureBoxAdv6_1.ImageLocation = carteA6.Image;
                }

                else
                {
                    Cartes carteA6_2 = jeu[CarteAleaA6_2];
                    CartesUtilisees.Add(CarteAleaA6_2);
                    ListeCartes.Add(carteA6_2);
                    pictureBoxAdv6_2.ImageLocation = carteA6_2.Image;
                }
            }
            #endregion

            #region Adversaire 7
            int CarteAleaA7 = CarteAleatoire();
            Cartes carteA7 = jeu[CarteAleaA7];
            CartesUtilisees.Add(CarteAleaA7);
            int CarteAleaA7_2 = CarteAleatoire();

            while (CartesUtilisees.Contains(CarteAleaA7_2))
            {
                CarteAleaA7_2 = CarteAleatoire();
            }
            CarteAleaA7_2 = 1 * CarteAleaA7_2;
            ListeCartes.Add(carteA7); ;

            if (Distrib && dist7_1)
            {
                if (SecondDistr == false)
                {
                    pictureBoxAdv7_1.ImageLocation = carteA7.Image;
                }

                else
                {
                    Cartes carteA7_2 = jeu[CarteAleaA7_2];
                    CartesUtilisees.Add(CarteAleaA7_2);
                    ListeCartes.Add(carteA7_2);
                    pictureBoxAdv7_2.ImageLocation = carteA7_2.Image;
                }
            }
            #endregion

            #region Adversaire 8
            int CarteAleaA8 = CarteAleatoire();
            Cartes carteA8 = jeu[CarteAleaA8];
            CartesUtilisees.Add(CarteAleaA8);
            int CarteAleaA8_2 = CarteAleatoire();

            while (CartesUtilisees.Contains(CarteAleaA8_2))
            {
                CarteAleaA8_2 = CarteAleatoire();
            }
            CarteAleaA8_2 = 1 * CarteAleaA8_2;
            ListeCartes.Add(carteA8);

            if (Distrib && dist8_1)
            {
                if (SecondDistr == false)
                {
                    pictureBoxAdv8_1.ImageLocation = carteA8.Image;
                }

                else
                {
                    Cartes carteA8_2 = jeu[CarteAleaA8_2];
                    CartesUtilisees.Add(CarteAleaA8_2);
                    ListeCartes.Add(carteA8_2);
                    pictureBoxAdv8_2.ImageLocation = carteA8_2.Image;
                }
            }

            #endregion*/
        }
    }
}