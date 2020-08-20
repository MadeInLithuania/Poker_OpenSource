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
    public partial class Settings : Form
    {
        #region Defintions langue
        public String[] langues = new String[3] { "Français","Lietuvių","English"};

        #endregion
        public bool EnregPara = false;
        public Settings()
        {
            InitializeComponent();
        }

        private void lblArriere_Click(object sender, EventArgs e)
        {
            if(EnregPara == false)
            {
                DialogResult Return = MessageBox.Show("Etes-vous sûr(e) de retourner à l'accueil sans avoir sauvegardé les paramètres ?",
                    "Attention",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if(Return == DialogResult.Yes)
                {
                    Retour();
                }

                else
                {
                    return;
                }
            }

            else
            {
                Retour();
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            
        }

        void Retour()
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
    }
}
