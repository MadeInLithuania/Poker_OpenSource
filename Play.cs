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
        System.Drawing.Color color = Color.FromArgb(100, 184, 59, 59);
        Main mn = new Main();
        int _Mise;
        bool Decision = false;
        string TXTotal = "Total :";
        public Play()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
        }

        [Browsable(true)]

        private async void Play_Load(object sender, EventArgs e)
        {
            Partie = true;
            SecondDistr = false;
            label2.Visible = false;
            
            #region Initfonctions
            ChargerArgent();
            ChargerCartes();
            Gen();
            ChargerPrenoms();

            #region Transparence
            labelArgentJoueur.BackColor = color;
            lblArgentAdversaire1.BackColor = color;
            lblArgentAdversaire2.BackColor = color;
            lblArgentAdversaire3.BackColor = color;
            lblArgentAdversaire4.BackColor = color;
            lblArgentAdversaire5.BackColor = color;
            lblArgentAdversaire6.BackColor = color;
            lblArgentAdversaire7.BackColor = color;
            lblArgentAdversaire8.BackColor = color;
            #endregion

            #region borduresronds
            var path = new GraphicsPath();
            path.AddEllipse(0, 0, labelArgentJoueur.Width - 2, labelArgentJoueur.Height);

            this.labelArgentJoueur.Region = new Region(path);
            this.lblArgentAdversaire1.Region = new Region(path);
            this.lblArgentAdversaire2.Region = new Region(path);
            this.lblArgentAdversaire3.Region = new Region(path);
            this.lblArgentAdversaire4.Region = new Region(path);
            this.lblArgentAdversaire5.Region = new Region(path);
            this.lblArgentAdversaire6.Region = new Region(path);
            this.lblArgentAdversaire7.Region = new Region(path);
            this.lblArgentAdversaire8.Region = new Region(path);

            var path1 = new GraphicsPath();
            path1.AddEllipse(0, 0, lblAdv1.Width - 2, lblAdv1.Height);

            this.labelArgentJoueur.Region = new Region(path1);
            this.lblAdv1.Region = new Region(path1);
            this.lblAdv2.Region = new Region(path1);
            this.lblAdv3.Region = new Region(path1);
            this.lblAdv4.Region = new Region(path1);
            this.lblAdv5.Region = new Region(path1);
            this.lblAdv6.Region = new Region(path1);
            this.lblAdv7.Region = new Region(path1);
            this.lblAdv8.Region = new Region(path1);

            #endregion

            await Task.Delay(2000);
            ArgentMin();
            #region Génération cartes         

            #endregion
            #endregion

            #region Initialisation jetons
            pictureBoxdistJoueur.Image = Properties.Resources.chip_black_top;
            pictureBoxdistAdv1.Image = Properties.Resources.chip_black_top;
            pictureBoxdistAdv2.Image = Properties.Resources.chip_black_top;
            pictureBoxdistAdv3.Image = Properties.Resources.chip_black_top;
            pictureBoxdistAdv4.Image = Properties.Resources.chip_black_top;
            pictureBoxdistAdv5.Image = Properties.Resources.chip_black_top;
            pictureBoxdistAdv6.Image = Properties.Resources.chip_black_top;
            pictureBoxdistAdv7.Image = Properties.Resources.chip_black_top;
            pictureBoxdistAdv8.Image = Properties.Resources.chip_black_top;
            #endregion
        }
    }
}
