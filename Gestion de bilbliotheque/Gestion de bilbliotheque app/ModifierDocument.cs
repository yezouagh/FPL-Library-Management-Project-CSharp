using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Gestion_de_bilbliotheque_app
{
    public partial class ModifierDocument : Form
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

        string Cote = "";

        public ModifierDocument(string cote)
        {
            InitializeComponent();
            Cote = cote;
        }

        private void AjouterDocBTN_Click(object sender, EventArgs e)
        {
            if (AjouterDocBTN.Text == "Modifier")
            {
                AjouterDocBTN.Text = "Valider";
                enable();
            }
            else
            {

                if (!CoteTXT.Text.Equals(string.Empty) && !TitreTXT.Text.Equals(string.Empty) && !Inventaire1TXT.Text.Equals(string.Empty) && !AuteurTXT.Text.Equals(string.Empty) && !TypeDocTXT.Text.Equals(string.Empty) && !DomaineTXT.Text.Equals(string.Empty))
                {
                    try
                    {
                        BibliothèqueDataSet.OuvrageRow r = Program.ds.Ouvrage.FindByCote(Cote);
                        r.Cote = CoteTXT.Text;
                        r.Titre = TitreTXT.Text;
                        r.PremierInventair = Inventaire1TXT.Text;
                        r.DernierInventair = Inventaire2TXT.Text;
                        r.Auteur = AuteurTXT.Text;
                        r.Domaine = DomaineTXT.Text;
                        r.SousDomaine = SousDomaineTXT.Text;
                        r.Nversement = NversementTXT.Text;
                        r.Date_Entre = dateEntreTimePicker.Value;
                        r.Qte = (int)QuantiteTXT.Value;
                        r.TypeOuvrage = TypeDocTXT.Text;
                        r.Observation = ObservationTXT.Text;
                        MessageBox.Show("le document est Modifier avec succes !");
                        Program.docsTA.Update(Program.ds.Ouvrage);
                        AjouterDocBTN.Text = "Modifier"; disable();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Vous deviez remplire les champs obligatoir!");
                }
            }
        }

        void enable()
        {
            dateEntreTimePicker.Enabled = true;
            NversementTXT.Enabled = true;
            TitreTXT.Enabled = true;
            Inventaire1TXT.Enabled = true;
            Inventaire2TXT.Enabled = true;
            AuteurTXT.Enabled = true;
            DomaineTXT.Enabled = true;
            SousDomaineTXT.Enabled = true;
            TypeDocTXT.Enabled = true;
            QuantiteTXT.Enabled = true;
            ObservationTXT.Enabled = true;
            checkBox1.Enabled = true;
        }

        void disable()
        {
            dateEntreTimePicker.Enabled = false;
            NversementTXT.Enabled = false;
            CoteTXT.Enabled = false;
            TitreTXT.Enabled = false;
            Inventaire1TXT.Enabled = false;
            Inventaire2TXT.Enabled = false;
            AuteurTXT.Enabled = false;
            DomaineTXT.Enabled = false;
            SousDomaineTXT.Enabled = false;
            TypeDocTXT.Enabled = false;
            QuantiteTXT.Enabled = false;
            ObservationTXT.Enabled = false;
            checkBox1.Checked = false;
            checkBox1.Enabled = false;
        }

        void loadAuteur()
        {
            try
            {
                AuteurTXT.AutoCompleteCustomSource.Clear();
                AutoCompleteStringCollection c = new AutoCompleteStringCollection();
                foreach (BibliothèqueDataSet.AuteurRow r in Program.ds.Auteur)
                {
                    c.Add(r.Auteur);
                }
                SetControlPropertyValue(AuteurTXT, "AutoCompleteCustomSource", c);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void loadDomain()
        {
            try
            {
                AutoCompleteStringCollection c = new AutoCompleteStringCollection();
                DomaineTXT.AutoCompleteCustomSource.Clear();
                foreach (BibliothèqueDataSet.DomaineRow r in Program.ds.Domaine)
                {
                    c.Add(r.Domaine);
                }
                SetControlPropertyValue(DomaineTXT, "AutoCompleteCustomSource", c);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void loadSousDomain()
        {
            try
            {
                AutoCompleteStringCollection c = new AutoCompleteStringCollection();
                SousDomaineTXT.AutoCompleteCustomSource.Clear();
                foreach (BibliothèqueDataSet.SousDomaineRow r in Program.ds.SousDomaine)
                {
                    c.Add(r.SousDomaine);
                }
                SetControlPropertyValue(SousDomaineTXT, "AutoCompleteCustomSource", c);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void loadTypeDoc()
        {
            try
            {
                AutoCompleteStringCollection c = new AutoCompleteStringCollection();
                TypeDocTXT.AutoCompleteCustomSource.Clear();
                foreach (BibliothèqueDataSet.TypesOuvrageRow r in Program.ds.TypesOuvrage)
                {
                    c.Add(r.TypeOuvrage);
                }
                SetControlPropertyValue(TypeDocTXT, "AutoCompleteCustomSource", c);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void remlireData()
        {
            try
            {
                BibliothèqueDataSet.OuvrageRow r = Program.ds.Ouvrage.FindByCote(Cote);
                CoteTXT.Text = r.Cote;
                TitreTXT.Text = r.Titre;
                Inventaire1TXT.Text = r.PremierInventair;
                Inventaire2TXT.Text = r.DernierInventair;
                AuteurTXT.Text = r.Auteur;
                DomaineTXT.Text = r.Domaine;
                SousDomaineTXT.Text = r.SousDomaine;
                NversementTXT.Text = r.Nversement;
                QuantiteTXT.Value = r.Qte;
                TypeDocTXT.Text = r.TypeOuvrage;
                ObservationTXT.Text = r.Observation;
                dateEntreTimePicker.Value = r.Date_Entre;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void AjouterDocument_Load(object sender, EventArgs e)
        {
            try
            {
                loadAuteur(); loadDomain(); loadSousDomain(); loadTypeDoc();remlireData();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        delegate void SetControlValueCallback(Control oControl, string propName, object propValue);
        private void SetControlPropertyValue(Control oControl, string propName, object propValue)
        {
            if (oControl.InvokeRequired)
            {
                SetControlValueCallback d = new SetControlValueCallback(SetControlPropertyValue);
                oControl.Invoke(d, new object[] { oControl, propName, propValue });
            }
            else
            {
                Type t = oControl.GetType();
                PropertyInfo[] props = t.GetProperties();
                foreach (PropertyInfo p in props)
                {
                    if (p.Name.ToUpper() == propName.ToUpper())
                    {
                        p.SetValue(oControl, propValue, null);
                    }
                }
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.ds.Ouvrage.FindByCote(CoteTXT.Text) != null)
                {
                    if (MessageBox.Show("Note : Si vous avez supprimer ce document ,tous les données relier avec ce document seront supprimer !\nVoulez vous vraiment supprimer ce document ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        Program.ds.Ouvrage.FindByCote(Cote).Delete();
                        MessageBox.Show("La supprission est fait avec succes !");
                        Program.docsTA.Update(Program.ds.Ouvrage);
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Ce document n'exist pas !");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CoteTXT.Enabled = checkBox1.Checked;
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
