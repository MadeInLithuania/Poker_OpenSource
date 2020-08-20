using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;

namespace Poker
{
    public partial class LoadForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern IntPtr LoadCursorFromFile(string filename);

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public LoadForm()
        {
            InitializeComponent();
        }

        private void LoadForm_Load(object sender, EventArgs e)
        {
            /*Cursor mycursor = new Cursor(Cursor.Current.Handle);
            IntPtr colorcursorhandle = LoadCursorFromFile(Application.StartupPath + "\\cursors\\Numix Cursors\\Numix Dark\\NO.cur");
            mycursor.GetType().InvokeMember("handle", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetField, null, mycursor, new object[] { colorcursorhandle });
            this.Cursor = mycursor;*/
            Console.WriteLine("Succès.");
        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            panelCharg.Width += 1;

            if(panelCharg.Width > 672)
            {
                timerLoad.Stop();
                Main main = new Main();
                this.Hide();
                main.Show();
            }
        }

        private void LoadForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public class AnimatedCurs
        {
            [DllImport("User32.dll")]
            private static extern IntPtr LoadCursorFromFile(String str);
            public static Cursor Create(string fname)
            {
                IntPtr HC = LoadCursorFromFile(fname);
                // si succès

                if (!IntPtr.Zero.Equals(HC))
                {
                    return new Cursor(HC);
                }
                else
                {
                    throw new ApplicationException("Cursor was not created from file " + fname);
                }
            }
        }
    }
}
