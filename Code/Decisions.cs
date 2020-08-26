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
        public bool Couche = false;
        public bool Mise = false;
        public bool Check = false;
        int tot;

        void ChargerBoutons()
        {
            TourJoueur = true;
            btnCheck.Visible = true;
            btnCoucher.Visible = true;
            btnMiser.Visible = true;
            btnRelancer.Visible = true;
            btnSuivre.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ATTENTION : \n Si vous cliquez ici, toutes les cartes seront changées !",
                "Attention",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            DialogResult dr = new DialogResult();

            if (dr == DialogResult.Yes)
            {
                DebugDistr();
            }

            else return;    
        }

        public void btnCoucher_Click(object sender, EventArgs e)
        {
            Couche = true;
            Coucher();
            HideButtons();
            TourJoueur = false;
            TourAdv1 = true;
            labelJoueur.BackColor = Color.Transparent;
            WhoIsPlaying();
            Round();
        }

        public void Mise_()
        {
            if (TourJoueur)
            {
                ArgentJoueur -= _Mise;
                tot = _Mise + total;
                labelArgentJoueur.Text = TXArgent + ArgentJoueur;
                labelTotal.Text = TXArgent + tot;
                labelJoueur.BackColor = Color.Transparent;
            }

            else if (TourAdv1)
            {
                int ArgMax1 = ArgentAdv1 / 10;
                Random rd1 = new Random();
                _Mise = rd1.Next(10, ArgMax1);
                ArgentAdv1 -= _Mise;
                tot = _Mise + total;
                lblArgentAdversaire1.Text = TXArgent + ArgentAdv1;
                labelTotal.Text = TXArgent + tot;
                lblAdv1.BackColor = Color.Transparent;
            }

        }

        private async void btnValider_Click(object sender, EventArgs e)
        {
            int.TryParse(textBoxmise.Text, out _Mise);
            if (!int.TryParse(textBoxmise.Text, out _Mise))
            {
                MessageBox.Show("Veuillez mettre une valeur valide.",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textBoxmise.Text = " ";
            }

            else if(_Mise > ArgentJoueur)
            {
                MessageBox.Show("Vous ne pouvez pas mettre autant.",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            else
            {
                await Task.Delay(500);
                Mise_();
                Round();
                TourJoueur = false;
                TourAdv1 = true;
                WhoIsPlaying();
                Round();
                HideButtons();
                btnAnnuler.Visible = false;
                textBoxmise.Visible = false;
                btnValider.Visible = false;
            }
        }

        private async void btnMiser_Click(object sender, EventArgs e)
        {
            Mise = true;
            if (Mise)
            {
                await Task.Delay(500);
                textBoxmise.Visible = true;
                HideButtons();
                btnValider.Visible = true;
                btnAnnuler.Visible = true;
            }
            else return;
        }

        private async void btnSuivre_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            TourJoueur = false;
            TourAdv1 = true;
            Round();
        }

        private async void btnAnnuler_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            btnAnnuler.Visible = false;
            btnValider.Visible = false;
            textBoxmise.Visible = false;
            ChargerBoutons();
        }

        public async void HideButtons()
        {
            await Task.Delay(50);
            btnCheck.Visible = false;
            btnCoucher.Visible = false;
            btnMiser.Visible = false;
            btnRelancer.Visible = false;
            btnSuivre.Visible = false;
        }

        public void Coucher()
        {
            if (Couche)
            {
                pictureBoxJoueur1.Image = null;
                pictureBoxJoueur1.Invalidate();
                pictureBoxJoueur2.Image = null;
                pictureBoxJoueur2.Invalidate();
             
            }
            else return;
        }
    }
}