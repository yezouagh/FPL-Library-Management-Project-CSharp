using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_bilbliotheque_app
{
    public partial class Bienvenu : Form
    {
        /// <summary>
        /// ////////////DO IT IN ALL FORMS
        /// </summary>
        #region Move form with dllImport
        private Point mouse_offset;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        int width = 933;
        void positioner()
        {
            Bienvenulabel.Left = (Width / 2) - (Bienvenulabel.Width / 2);
            MenuPanel.Left = (Width / 2) - (MenuPanel.Width / 2);
            BienVenuPanel.Left = (Width / 2) - (BienVenuPanel.Width / 2);
            BienVenuPanel.Top = (Body.Height / 2) - (BienVenuPanel.Height / 2);
            label7.Left = (Width / 2) - (label7.Width / 2);
        }
        public Bienvenu()
        {
            InitializeComponent();
            MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width + 5, Screen.PrimaryScreen.WorkingArea.Height + 5);
            width = Width;
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaxMin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void Minimiz_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Bienvenu_Resize(object sender, EventArgs e)
        {
            positioner();
            if (Width>width || BienVenuPanel.Visible)
            {
                label7.Show();
            }
            else
            {
                label7.Hide();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
                mouse_offset = new Point(-e.X, -e.Y);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    Point mousePos = Control.MousePosition;
                    mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                    Location = mousePos;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.ForeColor = Color.White;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.ForeColor = Color.Black;
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            BienVenuPanel.Hide();
            WindowState = FormWindowState.Maximized;
            Button b = (Button)sender;
            Bienvenulabel.Text = b.Text;
            b.FlatAppearance.BorderSize = 2;
            if (b.Name == "BTNPRÊTER")
            {
                ShowGestionPret();
            }
            else
                if (b.Name == "BTNouvrages")
                {
                    ShowAlimenterBaseDeDonnees();
                }

                else
                    if (b.Name == "BTNstatistiques")
                    {
                        ShowStatistique();
                    }
            positioner();
        }
        
        void ShowGestionPret()
        {
            Alimenter_La_Base_De_Deonnees.Hide();
            BTNouvrages.FlatAppearance.BorderSize = 0;
            BTNstatistiques.FlatAppearance.BorderSize = 0;
            Alimenter_La_Base_De_Deonnees.Dock = DockStyle.None;
            statistique.Dock = DockStyle.None;
            statistique.Hide();
            GestionPret.Dock = DockStyle.Fill;
            GestionPret.Show();
        }
        
        void ShowAlimenterBaseDeDonnees()
        {
            BTNstatistiques.FlatAppearance.BorderSize = 0;
            BTNPRÊTER.FlatAppearance.BorderSize = 0;
            GestionPret.Hide();
            statistique.Dock = DockStyle.None;
            statistique.Hide();
            GestionPret.Dock = DockStyle.None;
            Alimenter_La_Base_De_Deonnees.Dock = DockStyle.Fill;
            Alimenter_La_Base_De_Deonnees.Show();
        }
       
        void ShowStatistique()
        {
            BTNPRÊTER.FlatAppearance.BorderSize = 0;
            BTNouvrages.FlatAppearance.BorderSize = 0;
            GestionPret.Hide();
            GestionPret.Dock = DockStyle.None;
            Alimenter_La_Base_De_Deonnees.Hide();
            Alimenter_La_Base_De_Deonnees.Dock = DockStyle.None;
            statistique.Dock = DockStyle.Fill;
            statistique.Show();
        }

        private void EntrerBTN_Click(object sender, EventArgs e)
        { 
            Asanctionnee asanctione = new Asanctionnee();
            asanctione.ShowDialog();
            BTNPRÊTER.PerformClick();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
