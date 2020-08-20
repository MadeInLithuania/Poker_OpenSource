using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Runtime.InteropServices;

namespace Poker
{
    public partial class Main : Form
    {
        [DllImport("wmp.dll")]
        static extern Int32 mciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);
        //LoadForm lform = new LoadForm();
        Config config = new Config();
        Settings settings = new Settings();


        public Main()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
        }

        public void Main_Load(object sender, EventArgs e)
        {

            this.Cursor = new Cursor(Application.StartupPath + "\\cursors\\Numix Cursors\\Numix Dark\\Arrow.cur");
            this.Cursor = Cursor.Current;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            UnmanagedMemoryStream[] RandMusic = { Properties.Resources.pathway_to_haven,
                    Properties.Resources.Whisper_of_the_Sea,
                    Properties.Resources.Glide_With_Me,
                    Properties.Resources.Memoir_of_Summer}; // musiques
            Random rand = new Random();

            var playSound = RandMusic[rand.Next(0, RandMusic.Length)];
            SoundPlayer player1 = new SoundPlayer(playSound);

            new System.Threading.Thread(() =>
            {
                try
                {
                    player1.PlayLooping();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        "Impossible de jouer le morceau.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }).Start();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            //btnClick();
            DialogResult leave = MessageBox.Show("Voulez-vous quitter le jeu ?", "Quitter ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (leave == DialogResult.Yes)
            {
                Application.Exit();
            }
            else return;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void btnPara_Click(object sender, EventArgs e)
        {
            //btnClick();
            this.Hide();
            settings.Show();
        }

        private void btnJouer_Click_1(object sender, EventArgs e)
        {
            //btnClick();
            this.Hide();
            config.Show();
        }

        

        void btnClick()
        {
                try
                {
                    var _bt = new System.Windows.Media.MediaPlayer();
                    _bt.Open(new System.Uri(Environment.CurrentDirectory + "\\sfx\\button.wav"));
                    _bt.Play();
                }
                catch (Exception xe)
                {
                    MessageBox.Show(xe.Message,
                        "Impossible de jouer ce son.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }   
        }
    }
}
