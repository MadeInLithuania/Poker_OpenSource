using Poker.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public partial class Play : Form
    {
        List<int> ValeurJetons = new List<int>();

        List<ClassJetons> jetons = new List<ClassJetons>()
        {
            new ClassJetons(){valeurJetons = 1, imageJetons = Environment.CurrentDirectory + "\\img\\Jetons\\chip_white_top.png"},
            new ClassJetons(){valeurJetons = 5, imageJetons = Environment.CurrentDirectory + "\\img\\Jetons\\chip_red_top.png"},
            new ClassJetons(){valeurJetons = 25, imageJetons = Environment.CurrentDirectory + "\\img\\Jetons\\chip_green_top.png"},
            new ClassJetons(){valeurJetons = 50, imageJetons = Environment.CurrentDirectory + "\\img\\Jetons\\chip_blue_top.png"},
            new ClassJetons(){valeurJetons = 100, imageJetons = Environment.CurrentDirectory + "\\img\\Jetons\\chip_black_top.png"},
            new ClassJetons(){valeurJetons = 500, imageJetons = Environment.CurrentDirectory + "\\img\\Jetons\\chip_purple_top.png"},
            new ClassJetons(){valeurJetons = 1000, imageJetons = Environment.CurrentDirectory + "\\img\\Jetons\\chip_yellow_top.png"},
            new ClassJetons(){valeurJetons = 5000, imageJetons = Environment.CurrentDirectory + "\\img\\Jetons\\chip_biege_top.png"}
        };
        
    }
}