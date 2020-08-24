using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Poker.Play;

namespace Poker
{
            public struct Cartes { 
            public Symb Grade { get; set; }
            public int ID { get; set; }
            public Rank Valeur { get; set; }
            public string Nom { get; set; }
            public string Image { get; set; }
            public bool EstConnu { get; set; }

    }

}

