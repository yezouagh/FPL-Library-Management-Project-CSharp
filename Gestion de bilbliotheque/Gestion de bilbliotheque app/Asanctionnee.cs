using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Gestion_de_bilbliotheque_app
{
    public partial class Asanctionnee : Form
    {
        public Asanctionnee()
        {
            InitializeComponent();
            MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
        }

        private void LesEmprunteurs_Load(object sender, EventArgs e)
        {
            try
            {
                this.sanctionneTableAdapter.Fill(this.bibliothèqueDataSet.Sanctionne);
                if (bibliothèqueDataSet.Sanctionne.Rows.Count == 0)
                {
                    Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow r in sanctionneDataGridView.Rows)
                {
                    if ((bool)r.Cells["Confirmer"].FormattedValue == true)
                    {
                        BibliothèqueDataSetTableAdapters.QueriesTableAdapter q = new BibliothèqueDataSetTableAdapters.QueriesTableAdapter();
                        int nb = int.Parse(q.NbrSanction(r.Cells[2].Value.ToString()).Value.ToString());
                        DateTime d = DateTime.Now.Add(new TimeSpan(7, 0, 0, 0));
                        if (nb == 1)
                            d = d.Add(new TimeSpan(7, 0, 0, 0));
                        else
                            if (nb > 1)
                                d = d.Add(new TimeSpan(21, 0, 0, 0));
                        Program.ds.Emprunteur_Sanctionne.AddEmprunteur_SanctionneRow(Program.ds.Emprunter.FindByCodePret(int.Parse(r.Cells[0].Value.ToString())), DateTime.Now,
                           d, "Sanctionne");
                    }
                }
                Program.emprunteurSanctioneTA.Update(Program.ds.Emprunteur_Sanctionne);
                MessageBox.Show("l'opperation est fait avec succes!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.Graphics.DrawLines(SystemPens.ControlLightLight, new Point[] {
                    new Point (0, e.Bounds.Height - 1), 
                    new Point (0, 0), 
                    new Point (e.Bounds.Width - 1, 0)
                });
            e.Graphics.DrawLines(SystemPens.ControlDarkDark, new Point[] {
                    new Point (0, e.Bounds.Height - 1), 
                    new Point (e.Bounds.Width - 1, e.Bounds.Height - 1), 
                    new Point (e.Bounds.Width - 1, 0)
                });
            e.Graphics.FillRectangle(Brushes.DeepSkyBlue, e.Bounds);
            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
                sf.FormatFlags = StringFormatFlags.NoWrap;
                using (System.Drawing.Font f = new System.Drawing.Font("Tahoma", 9))
                {
                    e.Graphics.DrawString(e.ToolTipText, f, Brushes.White, e.Bounds, sf);
                }
            }
        }


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
    }
}
