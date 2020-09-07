using Poker.Code.Noms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public partial class Play 
    {
        List<Noms> RandNoms = new List<Noms>()
        {
            new Noms() {noms = "Asha", EstSpecial = false},
            new Noms(){noms = "Aliza", EstSpecial = false},
            new Noms(){noms = "Tolga",EstSpecial = false},
            new Noms(){noms = "Chenai",EstSpecial = false},
            new Noms(){noms = "Alton",EstSpecial = false},
            new Noms(){noms = "Remi",EstSpecial = false},
            new Noms(){noms = "Haroon", EstSpecial = false},
            new Noms(){noms = "Kadeem",EstSpecial = false},
            new Noms(){noms = "Chenai",EstSpecial = false},
            new Noms(){noms = "Sebastian",EstSpecial = false},
            new Noms(){noms = "Gavin",EstSpecial = false},
            new Noms(){noms = "Kohen", EstSpecial = false},
            new Noms(){noms = "Jennifer",EstSpecial = false},
            new Noms(){noms = "Lilly",EstSpecial = false},
            new Noms(){noms = "Franklin",EstSpecial = false},
            new Noms(){noms = "Mohsin",EstSpecial = false},
            new Noms(){noms = "Suzie", EstSpecial = false},
            new Noms(){noms = "Therodore",EstSpecial = false},
            new Noms(){noms = "Ebonie",EstSpecial = false},
            new Noms(){noms = "Amaya",EstSpecial = false},
            new Noms(){noms = "Morwenna",EstSpecial = false},
            new Noms(){noms = "Annie", EstSpecial = false},
            new Noms(){noms = "Louisa",EstSpecial = false},
            new Noms(){noms = "Linda",EstSpecial = false},
            new Noms(){noms = "Cassie",EstSpecial = false},
            new Noms(){noms = "Laclan",EstSpecial = false},
            new Noms(){noms = "Gwendoline",EstSpecial = false},
            #region Spéciaux
            new Noms(){noms = "Liucijus",EstSpecial = true,Couleur = Color.Gray},
            new Noms(){noms = "Tadas",EstSpecial = true, Couleur = Color.Gold}
            #endregion
        };

        List<Noms> NomsUtilises = new List<Noms>();

        Random RandAdv = new Random();

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
