using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Configuration;
using System.Runtime.InteropServices;

namespace Catalogue
{
    public partial class SetSqlConnection : Form
    {

        #region Move form with dllImport
        private Point mouse_offset;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

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

        public SetSqlConnection()
        {
            InitializeComponent();
            textBox1.Text = Environment.MachineName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (!textBox1.Text.Equals(string.Empty))
                {
                    string src = textBox1.Text;
                    if (checkBox1.Checked)
                    {
                        src += "\\SQLEXPRESS";
                    }
                    Properties.Settings.Default["BibliothèqueConnectionString"] = "Data Source=" + src + ";Initial Catalog=Bibliothèque;Integrated Security=SSPI";
                    SqlConnection con = new SqlConnection(Properties.Settings.Default.BibliothèqueConnectionString);
                    SqlCommand cmd = new SqlCommand("select Count(*) from TypeEmprunteur", con);
                    con.Open();
                    cmd.ExecuteScalar();
                    Properties.Settings.Default.Set = true;
                    Properties.Settings.Default.Save();
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("remplire le nom de la machine !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor = Cursors.Default;
        }
    }
}
