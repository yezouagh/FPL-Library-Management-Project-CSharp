using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Gestion_de_bilbliotheque_app
{
    public partial class LesEmprunteurs : Form
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

        string type = " 1=1 ", filier = " and CodeFilier like '%%'", id = " and ID_Emprunteur like '%%' ", nom = " and Nom like '%%' ",
            prenom = " and Prenom like '%%' ";
        public LesEmprunteurs()
        {
            try
            {
                InitializeComponent(); dv = new DataView(Program.ds.Emprunteur);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        DataView dv;

        void filtrer()
        {
            try
            {
                dv.RowFilter = type + filier + id + nom + prenom;
                dataGridView1.DataSource = dv.ToTable(false, new string[] { "ID_Emprunteur", "Nom", "Prenom", "DateNaissance", "LieuNaissance", "Sexe", "Email", "Tele" });
                totalLbl.Text = "Total : " + dv.Count;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void chargerAutoCompliteSourceIdentifiant()
        {
            try
            {
                AutoCompleteStringCollection c = new AutoCompleteStringCollection();
                foreach (BibliothèqueDataSet.EmprunteurRow r in Program.ds.Emprunteur)
                {
                    c.Add(r.ID_Emprunteur);
                }
                IdentifiantTXT.AutoCompleteCustomSource = c;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void LesEmprunteurs_Load(object sender, EventArgs e)
        {
            try
            {
                MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                filtrer();
                TypeComboBox.DataSource = Program.ds.TypeEmprunteur;
                TypeComboBox.DisplayMember = "Dèsignation";
                TypeComboBox.ValueMember = "IdTypeEmp";
                FilierComboBox.DataSource = Program.ds.Filier;
                FilierComboBox.DisplayMember = "Dèsignation";
                FilierComboBox.ValueMember = "CodeFilier";
                FilierComboBox.Text = "";
                TypeComboBox.Text = "";
                this.FilierComboBox.SelectedIndexChanged += new System.EventHandler(this.FilierComboBox_SelectedIndexChanged);
                this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
                {
                    ModifierEmp emp = new ModifierEmp(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    emp.ShowDialog();
                    filtrer();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (TypeComboBox.SelectedIndex != -1)
                {
                    if (TypeComboBox.SelectedValue.ToString() == "1"/*etudiant*/)
                    {
                        label3.Text = "N° d'inscription";
                        Filier.Show();
                    }
                    else
                        if (TypeComboBox.SelectedValue.ToString() == "3"/*prof*/)
                        {
                            label3.Text = "CIN";
                            Filier.Show();
                        }
                        else /*Extern*/
                        {
                            filier = "";
                            label3.Text = "CIN";
                            Filier.Hide();
                            FilierComboBox.SelectedIndex = -1;
                            FilierComboBox.Text = "";
                            filier = " and CodeFilier like '%%'";
                        }
                    type = "IdTypeEmp=" + TypeComboBox.SelectedValue.ToString();
                }
                filtrer();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void IdentifiantTXT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                id = " and ID_Emprunteur like '%" + IdentifiantTXT.Text + "%' ";
                filtrer();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void NomTXT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                nom = " and Nom like '%" + NomTXT.Text + "%' ";
                filtrer();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                prenom = " and Prenom like '%" + PrenomTXT.Text + "%' ";
                filtrer();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void FilierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (FilierComboBox.SelectedIndex != -1)
                {
                    filier = " and CodeFilier like '%" + FilierComboBox.SelectedValue.ToString() + "%'";
                }
                filtrer();
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

        private void TypeComboBox_TextChanged(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            if (box.Text == "")
                box.SelectedIndex = -1;
            if (box.Equals(TypeComboBox))
            {
                type = "1=1";
            }
            else
                if (box.Equals(FilierComboBox))
                {
                    filier = " and CodeFilier like '%%'";
                }
            filtrer();
        }
    }
}
