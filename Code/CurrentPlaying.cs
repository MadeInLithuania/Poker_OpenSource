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
        public void WhoIsPlaying()
        {
            if (TourJoueur)
            {
               labelJoueur.BackColor = Color.Orange;
            }

            else if (TourAdv1)
            {
                lblAdv1.BackColor = Color.Orange;
            }

            else if (TourAdv2)
            {
                lblAdv2.BackColor = Color.Orange;
            }

            else if (TourAdv3)
            {
                lblAdv3.BackColor = Color.Orange;
            }

            else if (TourAdv4)
            {
                lblAdv4.BackColor = Color.Orange;
            }

            else if (TourAdv5)
            {
                lblAdv5.BackColor = Color.Orange;
            }

            else if (TourAdv6)
            {
                lblAdv6.BackColor = Color.Orange;
            }

            else if (TourAdv7)
            {
                lblAdv7.BackColor = Color.Orange;
            }

            else if (TourAdv8)
            {
                lblAdv8.BackColor = Color.Orange;
            }
        }
    }
}