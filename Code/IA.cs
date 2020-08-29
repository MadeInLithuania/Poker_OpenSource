using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public partial class Play : Form
    {
        List<int> mises = new List<int>();
        
        int choix = 1;
        int Tours;
        void RandDecisions()
        {
            Random rdmChoix = new Random();
            int rdmC = rdmChoix.Next(choix, 4);
            switch (rdmC)
            {
                case 1: //Mise
                    Mise_();
                break;

                 case 2 : // Coucher
                    Coucher();
                 break;

                case 3: //Suivre
                    Suivre();
                break;
                   
            }
        }
        public void CompteTours()
        {

        }
    }
}
