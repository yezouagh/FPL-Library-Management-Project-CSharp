using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Gestion_de_bilbliotheque_app
{
    public partial class ModifierEmp : Form
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

        string ID = "";

        public ModifierEmp(string id)
        {
            InitializeComponent();
            ID = id;
        }

        private void NouveauFilierBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Filiere Filiere1 = new Filiere();
                Filiere1.ShowDialog();
                Load1();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        bool VerifierChampsRequis
        {
            get
            {
                bool check = true;
                if (IdentifiantTXT.Text.Equals(string.Empty) || NomTXT.Text.Equals(string.Empty) || PrenomTXT.Text.Equals(string.Empty))
                {
                    check = false;
                }
                return check;
            }
        }

        void enable()
        {
            IdentifiantPanel.Enabled = true;
            DateNaissance.Enabled = true;
            LieuNaissance.Enabled = true;
            CIN.Enabled = true;
            Nom.Enabled = true;
            Prenom.Enabled = true;
            Filier.Enabled = true;
            Email.Enabled = true;
            Tele.Enabled = true;
            Type.Enabled = true;
            Sexe.Enabled = true;
        }

        void disable()
        {
            IdentifiantPanel.Enabled = false;
            DateNaissance.Enabled = false;
            LieuNaissance.Enabled = false;
            CIN.Enabled = false;
            Nom.Enabled = false;
            Prenom.Enabled = false;
            Filier.Enabled = false;
            Email.Enabled = false;
            Tele.Enabled = false;
            Type.Enabled = false;
            Sexe.Enabled = false;
            checkBox1.Checked = false;
        }

        private void AjouterEmpBTN_Click(object sender, EventArgs e)
        {
            if (AjouterEmpBTN.Text == "Modifier")
            {
                AjouterEmpBTN.Text = "Valider";
                enable();
            }
            else
            {
                if (VerifierChampsRequis)
                {
                    try
                    {
                        string cin = CinTXT.Text;
                        if (TypeComboBox.SelectedValue.ToString() != "1") { cin = IdentifiantTXT.Text; }
                        string sx = "M";
                        if (SexeF.Checked)
                        {
                            sx = "F";
                        }
                        BibliothèqueDataSet.EmprunteurRow r = Program.ds.Emprunteur.FindByID_Emprunteur(ID);
                        r.ID_Emprunteur = IdentifiantTXT.Text;
                        r.CIN = cin;
                        r.Nom = NomTXT.Text;
                        r.Prenom = PrenomTXT.Text;
                        if (TypeComboBox.SelectedValue.ToString() == "2")
                        {
                            FilierComboBox.SelectedValue = "NAN";
                        }
                        r.CodeFilier = FilierComboBox.SelectedValue.ToString();
                        r.DateNaissance = DateNaissanceTimePicker.Value;
                        r.LieuNaissance = LieuNaissanceTXT.Text;
                        r.Sexe = sx; r.Email = EmailTXT.Text; r.Tele = TeleTXT.Text;
                        r.IdTypeEmp = int.Parse(TypeComboBox.SelectedValue.ToString());
                        MessageBox.Show("l'Emprunteur est Modifier avec succes !");
                        Program.emprunteurTA.Update(Program.ds.Emprunteur);
                        AjouterEmpBTN.Text = "Modifier"; disable();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }

                }
                else
                {
                    MessageBox.Show("Vous deviez remplire les champs obligatoir!");
                }
            }
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeComboBox.SelectedValue.ToString() == "1"/*etudiant*/)
            {
                CIN.Show();
                Identifiant.Text = "N° d'inscription";
                Filier.Show();
            }
            else
                if (TypeComboBox.SelectedValue.ToString() == "3"/*prof*/)
                {
                    CIN.Hide();
                    Identifiant.Text = "CIN";
                    Filier.Show();
                }
                else /*Extern*/
                {
                    CIN.Hide();
                    Identifiant.Text = "CIN";
                    Filier.Hide();
                }
        }

        void Load1()
        {
            FilierComboBox.DataSource = Program.ds.Filier;
            FilierComboBox.DisplayMember = "Dèsignation";
            FilierComboBox.ValueMember = "CodeFilier";
        }

        private void AjouterEmp_Load(object sender, EventArgs e)
        {
            try
            {
                TypeComboBox.DataSource = Program.ds.TypeEmprunteur;
                TypeComboBox.DisplayMember = "Dèsignation";
                TypeComboBox.ValueMember = "IdTypeEmp";
                Load1();
                this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
                remplireData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void remplireData()
        {
            try
            {
                BibliothèqueDataSet.EmprunteurRow r = Program.ds.Emprunteur.FindByID_Emprunteur(ID);
                TypeComboBox.SelectedValue = r.IdTypeEmp;
                IdentifiantTXT.Text = r.ID_Emprunteur;
                CinTXT.Text = r.CIN;
                LieuNaissanceTXT.Text = r.LieuNaissance;
                NomTXT.Text = r.Nom;
                PrenomTXT.Text = r.Prenom;
                FilierComboBox.SelectedValue = r.CodeFilier;
                EmailTXT.Text = r.Email;
                TeleTXT.Text = r.Tele;

                DateNaissanceTimePicker.Value = r.DateNaissance;
                if (r.Sexe == "M")
                {
                    SexeM.Checked = true;
                }
                else
                {
                    SexeF.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            IdentifiantTXT.Enabled = checkBox1.Checked;
        }

        private void SupprimerBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.ds.Emprunteur.FindByID_Emprunteur(ID) != null)
                {
                    if (MessageBox.Show("Note : Si vous avez supprimer ce emprunteur ,tous ces operation seront supprimer !\nVoulez vous vraiment supprimer ce emprunteur ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        Program.ds.Emprunteur.FindByID_Emprunteur(ID).Delete();
                        MessageBox.Show("La supprission est fait avec succes !");
                        Program.emprunteurTA.Update(Program.ds.Emprunteur);
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Ce emprunteur n'exist pas !");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
