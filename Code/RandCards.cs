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

            new Cartes() {ID = 1, Valeur  = Rank.Deux, Grade = Symb.Coeurs, Image = Environment.CurrentDirectory + "\\img\\2H.png"},
            new Cartes() {ID = 2, Valeur  = Rank.Trois, Grade = Symb.Coeurs, Image = Environment.CurrentDirectory + "\\img\\3H.png"},
            new Cartes() {ID = 3, Valeur  = Rank.Quatre, Grade = Symb.Coeurs, Image =Environment.CurrentDirectory + "\\img\\4H.png"},
            new Cartes() {ID = 4, Valeur  = Rank.Cinq, Grade = Symb.Coeurs, Image =Environment.CurrentDirectory + "\\img\\5H.png"},
            new Cartes() {ID = 5, Valeur  = Rank.Six, Grade = Symb.Coeurs, Nom = "6 de coeur", Image =Environment.CurrentDirectory + "\\img\\6H.png"},
            new Cartes() {ID = 6, Valeur  = Rank.Sept, Grade = Symb.Coeurs, Nom = "7 de coeur", Image =Environment.CurrentDirectory + "\\img\\7H.png"},
            new Cartes() {ID = 7, Valeur  = Rank.Huit, Grade = Symb.Coeurs, Nom = "8 de coeur", Image =Environment.CurrentDirectory + "\\img\\8H.png"},
            new Cartes() {ID = 8, Valeur  = Rank.Neuf, Grade = Symb.Coeurs, Nom = "9 de coeur", Image =Environment.CurrentDirectory + "\\img\\9H.png"},
            new Cartes() {ID = 9, Valeur  = Rank.Dix, Grade = Symb.Coeurs, Nom = "10 de coeur", Image =Environment.CurrentDirectory + "\\img\\10H.png"},
            new Cartes() {ID = 10, Valeur  = Rank.Valet, Grade = Symb.Coeurs, Nom = "Valet de coeur", Image = Environment.CurrentDirectory +"\\img\\JH.png" },
            new Cartes() {ID = 11, Valeur  = Rank.Reine, Grade = Symb.Coeurs, Nom = "Reine de coeur", Image = Environment.CurrentDirectory + "\\img\\QH.png" },
            new Cartes() {ID = 12, Valeur  = Rank.Roi, Grade = Symb.Coeurs, Nom = "Roi de coeur", Image = Environment.CurrentDirectory + "\\img\\KH.png" },
            new Cartes() {ID = 13, Valeur  = Rank.As, Grade = Symb.Coeurs, Nom = "As de coeur", Image = Environment.CurrentDirectory + "\\img\\AH.png" },

            #endregion

            #region Trefles //Liste des cartes de ID = 14,

            new Cartes() {ID = 14, Valeur  = Rank.Deux, Grade = Symb.Trefles, Nom = "2 de trèfle", Image  = Environment.CurrentDirectory + "\\img\\2C.png" },
            new Cartes() {ID = 15, Valeur  = Rank.Trois, Grade = Symb.Trefles, Nom = "3 de trèfle", Image = Environment.CurrentDirectory + "\\img\\3C.png" },
            new Cartes() {ID = 16, Valeur  = Rank.Quatre, Grade = Symb.Trefles, Nom = "4 de trèfle", Image = Environment.CurrentDirectory + "\\img\\4C.png" },
            new Cartes() {ID = 17, Valeur  = Rank.Cinq, Grade = Symb.Trefles, Nom = "5 de trèfle", Image = Environment.CurrentDirectory + "\\img\\5C.png" },
            new Cartes() {ID = 18, Valeur  = Rank.Six, Grade = Symb.Trefles, Nom = "6 de trèfle", Image = Environment.CurrentDirectory + "\\img\\6C.png" },
            new Cartes() {ID = 19, Valeur  = Rank.Sept, Grade = Symb.Trefles, Nom = "7 de trèfle", Image = Environment.CurrentDirectory + "\\img\\7C.png" },
            new Cartes() {ID = 20, Valeur  = Rank.Huit, Grade = Symb.Trefles, Nom = "8 de trèfle", Image = Environment.CurrentDirectory +"\\img\\8C.png" },
            new Cartes() {ID = 21, Valeur  = Rank.Neuf, Grade = Symb.Trefles, Nom = "9 de trèfle", Image = Environment.CurrentDirectory + "\\img\\9C.png" },
            new Cartes() {ID = 22, Valeur  = Rank.Dix, Grade = Symb.Trefles, Nom = "10 de trèfle", Image = Environment.CurrentDirectory + "\\img\\10C.png" },
            new Cartes() {ID = 23, Valeur  = Rank.Valet, Grade = Symb.Trefles, Nom = "Valet de trèfle", Image = Environment.CurrentDirectory + "\\img\\JC.png" },
            new Cartes() {ID = 24, Valeur  = Rank.Reine, Grade = Symb.Trefles, Nom = "Reine de trèfle", Image = Environment.CurrentDirectory + "\\img\\QC.png" },
            new Cartes() {ID = 25, Valeur  = Rank.Roi, Grade = Symb.Trefles, Nom = "Roi de trèfle", Image = Environment.CurrentDirectory + "\\img\\KC.png" },
            new Cartes() {ID = 26, Valeur  = Rank.As, Grade = Symb.Trefles, Nom = "As de trèfle", Image = Environment.CurrentDirectory + "\\img\\AC.png" },

            #endregion

            #region Carreaux //Liste des cartes de carreaux

            new Cartes() {ID = 27, Valeur  = Rank.Deux, Grade = Symb.Trefles, Nom = "2 de carreaux", Image = Environment.CurrentDirectory + "\\img\\2D.png" },
            new Cartes() {ID = 28, Valeur  = Rank.Trois, Grade = Symb.Carreaux, Nom = "3 de carreaux", Image = Environment.CurrentDirectory + "\\img\\3D.png" },
            new Cartes() {ID = 29, Valeur  = Rank.Quatre, Grade = Symb.Carreaux, Nom = "4 de carreaux", Image = Environment.CurrentDirectory + "\\img\\4D.png" },
            new Cartes() {ID = 30, Valeur  = Rank.Cinq, Grade = Symb.Carreaux, Nom = "5 de carreaux", Image = Environment.CurrentDirectory + "\\img\\5D.png" },
            new Cartes() {ID = 31, Valeur  = Rank.Six, Grade = Symb.Carreaux, Nom = "6 de carreaux", Image = Environment.CurrentDirectory + "\\img\\6D.png" },
            new Cartes() {ID = 32, Valeur  = Rank.Sept, Grade = Symb.Carreaux, Nom = "7 de carreaux", Image = Environment.CurrentDirectory + "\\img\\7D.png" },
            new Cartes() {ID = 33, Valeur  = Rank.Huit, Grade = Symb.Carreaux, Nom = "8 de carreaux", Image = Environment.CurrentDirectory + "\\img\\8D.png" },
            new Cartes() {ID = 34, Valeur  = Rank.Neuf, Grade = Symb.Carreaux, Nom = "9 de carreaux", Image = Environment.CurrentDirectory + "\\img\\9D.png" },
            new Cartes() {ID = 35, Valeur  = Rank.Dix, Grade = Symb.Carreaux, Nom = "10 de carreaux", Image = Environment.CurrentDirectory + "\\img\\10D.png" },
            new Cartes() {ID = 36, Valeur  = Rank.Valet, Grade = Symb.Carreaux, Nom = "Valet de carreaux", Image = Environment.CurrentDirectory + "\\img\\JD.png" },
            new Cartes() {ID = 37, Valeur  = Rank.Reine, Grade = Symb.Carreaux, Nom = "Reine de carreaux", Image = Environment.CurrentDirectory + "\\img\\QD.png" },
            new Cartes() {ID = 38, Valeur  = Rank.Roi, Grade = Symb.Carreaux, Nom = "Roi de carreaux", Image = Environment.CurrentDirectory + "\\img\\KD.png" },
            new Cartes() {ID = 39, Valeur  = Rank.As, Grade = Symb.Carreaux, Nom = "As de carreaux", Image = Environment.CurrentDirectory + "\\img\\AD.png" },

            #endregion

            #region Piques //Liste des cartes de piques

            new Cartes() {ID = 40, Valeur  = Rank.Deux, Grade = Symb.Piques, Nom = "2 de piques", Image = Environment.CurrentDirectory + "\\img\\2S.png" },
            new Cartes() {ID = 41, Valeur  = Rank.Trois, Grade = Symb.Piques, Nom = "3 de piques", Image = Environment.CurrentDirectory + "\\img\\3S.png" },
            new Cartes() {ID = 42, Valeur  = Rank.Quatre, Grade = Symb.Piques, Nom = "4 de piques", Image = Environment.CurrentDirectory + "\\img\\4S.png" },
            new Cartes() {ID = 43, Valeur  = Rank.Cinq, Grade = Symb.Piques, Nom = "5 de piques", Image = Environment.CurrentDirectory + "\\img\\5S.png" },
            new Cartes() {ID = 44, Valeur  = Rank.Six, Grade = Symb.Piques, Nom = "6 de piques", Image = Environment.CurrentDirectory + "\\img\\6S.png" },
            new Cartes() {ID = 45, Valeur  = Rank.Sept, Grade = Symb.Piques, Nom = "7 de piques", Image = Environment.CurrentDirectory + "\\img\\7S.png" },
            new Cartes() {ID = 46, Valeur  = Rank.Huit, Grade = Symb.Piques, Nom = "8 de piques", Image = Environment.CurrentDirectory + "\\img\\8S.png" },
            new Cartes() {ID = 47, Valeur  = Rank.Neuf, Grade = Symb.Piques, Nom = "9 de piques", Image = Environment.CurrentDirectory + "\\img\\9S.png" },
            new Cartes() {ID = 48, Valeur  = Rank.Dix, Grade = Symb.Piques, Nom = "10 de piques", Image = Environment.CurrentDirectory + "\\img\\10S.png" },
            new Cartes() {ID = 49, Valeur  = Rank.Valet, Grade = Symb.Piques, Nom = "Valet de piques", Image = Environment.CurrentDirectory + "\\img\\JS.png" },
            new Cartes() {ID = 50, Valeur  = Rank.Reine, Grade = Symb.Piques, Nom = "Reine de piques", Image = Environment.CurrentDirectory + "\\img\\QS.png" },
            new Cartes() {ID = 51, Valeur  = Rank.Roi, Grade = Symb.Piques, Nom = "Roi de piques", Image = Environment.CurrentDirectory + "\\img\\KS.png" },
            new Cartes() {ID = 52, Valeur  = Rank.As,Grade = Symb.Piques, Nom = "As de piques", Image = Environment.CurrentDirectory + "\\img\\AD.png" },
            #endregion
        };
        #endregion

        public int CarteAleatoire()
        {
            int carteAlea;
            carteAlea = random.Next(0, jeu.Count); //génère entre 52 cartes
            return carteAlea;
        }


        public void GenCartesAdv()
        {
            int _Carte0 = CarteAleatoire();
            Cartes carte0_1 = jeu[_Carte0];
            CartesUtilisees.Add(_Carte0);

            while (CartesUtilisees.Contains(_Carte0))
            {
                _Carte0 = CarteAleatoire();
            }
            _Carte0 = 1 * _Carte0;

            ListeCartes.Add(carte0_1);

            if (Distrib && distj1)
            {
                if (SecondDistr == false)
                {
                    pictureBoxJoueur1.ImageLocation = carte0_1.Image;
                }

                else
                {
                    _Carte0 = CarteAleatoire();
                    CartesUtilisees.Add(_Carte0);
                    while (CartesUtilisees.Contains(_Carte0))
                    {
                        _Carte0 = CarteAleatoire();
                    }
                    _Carte0 = 1 * _Carte0;
                    ListeCartes.Add(carte0_1);
                    
                   
                    pictureBoxJoueur2.ImageLocation = carte0_1.Image;
                }
            }

            #region Adversaire 1
            int _Carte1 = CarteAleatoire();
            Cartes carte1_1 = jeu[_Carte1];
            CartesUtilisees.Add(_Carte1);

            while (CartesUtilisees.Contains(_Carte0)&&CartesUtilisees.Contains(_Carte1))
            {
                _Carte1 = CarteAleatoire();
            }
            _Carte1 = 1 * _Carte1;
            ListeCartes.Add(carte1_1);

            if (Distrib && dist1_1)
            {
                if (SecondDistr == false)
                {
                    pictureBoxAdv1_1.ImageLocation = carte1_1.Image;
                }

                else
                {
                    _Carte1 = CarteAleatoire();
                    CartesUtilisees.Add(_Carte1);
                    while (CartesUtilisees.Contains(_Carte0) && CartesUtilisees.Contains(_Carte1))
                    {
                        _Carte1 = CarteAleatoire();
                    }
                    _Carte1 = 1 * _Carte1;
                    ListeCartes.Add(carte1_1);
                    pictureBoxAdv1_2.ImageLocation = carte1_1.Image;
                }
            }
            #endregion

            #region Adversaire 2
            int _Carte2 = CarteAleatoire();
            Cartes carte2 = jeu[_Carte2];
            CartesUtilisees.Add(_Carte2);

            while (CartesUtilisees.Contains(_Carte0) && CartesUtilisees.Contains(_Carte1) && CartesUtilisees.Contains(_Carte2))
            {
                _Carte2= CarteAleatoire();
            }
            _Carte2 = 1 * _Carte2;

            ListeCartes.Add(carte2);

            if (Distrib && dist2_1)
            {
                if (SecondDistr == false)
                {
                    pictureBoxAdv2_1.ImageLocation = carte2.Image;
                }

                else
                {
                    _Carte2 = CarteAleatoire();
                    CartesUtilisees.Add(_Carte2);
                    while (CartesUtilisees.Contains(_Carte0) && CartesUtilisees.Contains(_Carte1) && CartesUtilisees.Contains(_Carte2))
                    {
                        _Carte2 = CarteAleatoire();
                    }
                    _Carte2 = 1 * _Carte2;
                    ListeCartes.Add(carte2);
                    pictureBoxAdv2_2.ImageLocation = carte2.Image;
                }
            }
            #endregion

            #region Adversaire 3
           int _Carte3 = CarteAleatoire();
            Cartes carte3 = jeu[_Carte3];
            CartesUtilisees.Add(_Carte3);

            while (CartesUtilisees.Contains(_Carte0) && CartesUtilisees.Contains(_Carte1) && CartesUtilisees.Contains(_Carte2) && CartesUtilisees.Contains(_Carte3))
            {
                _Carte3 = CarteAleatoire();
            }
            _Carte3 = 1 * _Carte3;

            if (Distrib && dist3_1)
            {
                if (SecondDistr == false)
                {
                    pictureBoxAdv3_1.ImageLocation = carte3.Image;
                }

                else
                {
                    CartesUtilisees.Add(_Carte3);
                    while (CartesUtilisees.Contains(_Carte0) && CartesUtilisees.Contains(_Carte1) && CartesUtilisees.Contains(_Carte2) && CartesUtilisees.Contains(_Carte3))
                    {
                        _Carte3 = CarteAleatoire();
                    }
                    _Carte3 = 1 * _Carte3;
                    ListeCartes.Add(carte3);
                    pictureBoxAdv3_2.ImageLocation = carte3.Image;
                }
            }
            #endregion

            #region Adversaire 4
            int _Carte4 = CarteAleatoire();
            Cartes carte4 = jeu[_Carte4];
            CartesUtilisees.Add(_Carte4);

            while (CartesUtilisees.Contains(_Carte0) && CartesUtilisees.Contains(_Carte1) && CartesUtilisees.Contains(_Carte2) && CartesUtilisees.Contains(_Carte3) && CartesUtilisees.Contains(_Carte4))
            {
                _Carte4 = CarteAleatoire();
            }
            _Carte4 = 1 * _Carte4;
            ListeCartes.Add(carte4);

            if (Distrib && dist4_1)
            {
                if (SecondDistr == false)
                {
                    pictureBoxAdv4_1.ImageLocation = carte4.Image;
                }

                else
                {
                    _Carte4 = CarteAleatoire();
                    CartesUtilisees.Add(_Carte4);
                    while (CartesUtilisees.Contains(_Carte0) && CartesUtilisees.Contains(_Carte1) && CartesUtilisees.Contains(_Carte2) && CartesUtilisees.Contains(_Carte3) && CartesUtilisees.Contains(_Carte4))
                    {
                        _Carte4 = CarteAleatoire();
                    }
                    _Carte4 = 1 * _Carte4;
                    ListeCartes.Add(carte4);
                    pictureBoxAdv4_2.ImageLocation = carte4.Image;
                }

            }
            #endregion

            #region Adversaire 5
            int _Carte5 = CarteAleatoire();
            Cartes carte5 = jeu[_Carte5];
            CartesUtilisees.Add(_Carte5);

            while (CartesUtilisees.Contains(_Carte0) && CartesUtilisees.Contains(_Carte1) && CartesUtilisees.Contains(_Carte2) && CartesUtilisees.Contains(_Carte3) && CartesUtilisees.Contains(_Carte4) && CartesUtilisees.Contains(_Carte5))
            {
                _Carte5= CarteAleatoire();
            }
            _Carte5 = 1 * _Carte5;
            ListeCartes.Add(carte5);

            if (Distrib && dist5_1)
            {
                if (SecondDistr == false)
                {
                    pictureBoxAdv5_1.ImageLocation = carte5.Image;
                }

                else
                {
                    _Carte5 = CarteAleatoire();
                    CartesUtilisees.Add(_Carte5);
                    while (CartesUtilisees.Contains(_Carte0) && CartesUtilisees.Contains(_Carte1) && CartesUtilisees.Contains(_Carte2) && CartesUtilisees.Contains(_Carte3) && CartesUtilisees.Contains(_Carte4) && CartesUtilisees.Contains(_Carte5))
                    {
                        _Carte5 = CarteAleatoire();
                    }
                    _Carte5 = 1 * _Carte5;
                    ListeCartes.Add(carte5);
                    pictureBoxAdv5_2.ImageLocation = carte5.Image;
                }
            }
                #endregion

            #region Adversaire 6
            int _Carte6 = CarteAleatoire();
            Cartes carte6 = jeu[_Carte6];
            CartesUtilisees.Add(_Carte6);

            while (CartesUtilisees.Contains(_Carte0) && CartesUtilisees.Contains(_Carte1) && CartesUtilisees.Contains(_Carte2) && CartesUtilisees.Contains(_Carte3) && CartesUtilisees.Contains(_Carte4) && CartesUtilisees.Contains(_Carte5) && CartesUtilisees.Contains(_Carte6))
            {
                _Carte6 = CarteAleatoire();
            }
            _Carte6 = 1 * _Carte6;
            
            ListeCartes.Add(carte6);

            if (Distrib && dist6_1)
            {
                if(SecondDistr == false)
                {
                    pictureBoxAdv6_1.ImageLocation = carte6.Image;
                }

                else
                {
                    _Carte6 = CarteAleatoire();
                    CartesUtilisees.Add(_Carte6);
                    while (CartesUtilisees.Contains(_Carte6))
                    {
                        _Carte6 = CarteAleatoire();
                    }
                    _Carte6 = 1 * _Carte6;
                    ListeCartes.Add(carte6);
                    pictureBoxAdv6_2.ImageLocation = carte6.Image;
                }                
            }
            #endregion

            #region Adversaire 7
            __Carte1 = CarteAleatoire();
            Cartes carte7 = jeu[__Carte1];
            CartesUtilisees.Add(__Carte1);

            while (CartesUtilisees.Contains(__Carte1))
            {
                __Carte1 = CarteAleatoire();
            }
            __Carte1 = 1 * __Carte1;
            ListeCartes.Add(carte7);

            if (Distrib && dist7_1)
            {
                if (SecondDistr == false)
                {
                    pictureBoxAdv7_1.ImageLocation = carte7.Image;
                }

                else
                {
                    __Carte1 = CarteAleatoire();
                    CartesUtilisees.Add(__Carte1);
                    while (CartesUtilisees.Contains(__Carte1))
                    {
                        __Carte1 = CarteAleatoire();
                    }
                    __Carte1 = 1 * __Carte1;
                    ListeCartes.Add(carte7);
                    pictureBoxAdv7_2.ImageLocation = carte7.Image;
                }
            }
            #endregion

            #region Adversaire 8
            __Carte1 = CarteAleatoire();
            Cartes carte8 = jeu[__Carte1];
            CartesUtilisees.Add(__Carte1);

            while (CartesUtilisees.Contains(__Carte1))
            {
                __Carte1 = CarteAleatoire();
            }
            __Carte1 = 1 * __Carte1;
            ListeCartes.Add(carte8);

            if (Distrib && dist8_1)
            {
                if (SecondDistr == false)
                {
                    pictureBoxAdv8_1.ImageLocation = carte8.Image;
                }

                else
                {
                    __Carte1 = CarteAleatoire();
                    CartesUtilisees.Add(__Carte1);
                    while (CartesUtilisees.Contains(__Carte1))
                    {
                        __Carte1 = CarteAleatoire();
                    }
                    __Carte1 = 1 * __Carte1;
                    ListeCartes.Add(carte8);
                    pictureBoxAdv8_2.ImageLocation = carte8.Image;
                }
            }
           
            #endregion
        }
    }
}