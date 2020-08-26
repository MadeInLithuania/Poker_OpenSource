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
        #region Tours
        public bool TourJoueur = false;
        public bool TourAdv1 = false;
        public bool TourAdv2 = false;
        public bool TourAdv3 = false;
        public bool TourAdv4 = false;
        public bool TourAdv5 = false;
        public bool TourAdv6 = false;
        public bool TourAdv7 = false;
        public bool TourAdv8 = false;
        #endregion

        void Round()
        {
            if (TourAdv1)
            {
                Mise_();
            }
        }
    } 
}
