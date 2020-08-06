using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_bilbliotheque_app
{
    public partial class AjouterEmp : UserControl
    {
        public AjouterEmp()
        {
            InitializeComponent();
        }

        private void NouveauFilierBTN_Click(object sender, EventArgs e)
        {
            Filiere Filiere1 = new Filiere();
            Filiere1.ShowDialog();
            Load1();
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
        
        void vider()
        {
            IdentifiantTXT.Text = "";
            CinTXT.Text = "";
            NomTXT.Text = "";
            PrenomTXT.Text = "";
            LieuNaissanceTXT.Text = "";
            EmailTXT.Text = "";
            TeleTXT.Text = "";
        }
        
        private void AjouterEmpBTN_Click(object sender, EventArgs e)
        {

            if (VerifierChampsRequis)
            {
                string cin;
                string sx = "M";
                if (SexeF.Checked)
                {
                    sx = "F";
                }
                if (TypeComboBox.SelectedValue.ToString() == "1"/*etudiant*/)
                {
                    cin = CinTXT.Text;
                }
                else

                    if (TypeComboBox.SelectedValue.ToString() == "3"/*prof*/)
                    {
                        cin = IdentifiantTXT.Text;
                    }
                    else /*Extern*/
                    {
                        cin = IdentifiantTXT.Text;
                    }
                try
                {
                    Program.ds.Emprunteur.AddEmprunteurRow(IdentifiantTXT.Text, cin, NomTXT.Text, PrenomTXT.Text, Program.ds.Filier.FindByCodeFilier(FilierComboBox.SelectedValue.ToString()),
                     DateNaissanceTimePicker.Value, LieuNaissanceTXT.Text, sx, EmailTXT.Text, TeleTXT.Text,
                     Program.ds.TypeEmprunteur.FindByIdTypeEmp(int.Parse(TypeComboBox.SelectedValue.ToString())));
                    MessageBox.Show("l'Emprunteur est ajoute avec succes !");
                    vider(); 
                    Program.emprunteurTA.Update(Program.ds.Emprunteur);
                    label3.Hide();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }
            else
            {
                label3.Show();
            }
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CinTXT.Text = "";
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
                    FilierComboBox.SelectedValue = "NAN";
                    CIN.Hide();
                    Identifiant.Text = "CIN";
                    Filier.Hide();
                }
        }
        
        void Load1()
        {
            try
            {
                FilierComboBox.DataSource = Program.ds.Filier;
                FilierComboBox.DisplayMember = "Dèsignation";
                FilierComboBox.ValueMember = "CodeFilier";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        
        private void AjouterEmp_Load(object sender, EventArgs e)
        {
            try
            {
            Load1();
            TypeComboBox.DataSource = Program.ds.TypeEmprunteur;
            TypeComboBox.DisplayMember = "Dèsignation";
            TypeComboBox.ValueMember = "IdTypeEmp";
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
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
    }
}
