using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Reflection;

namespace Gestion_de_bilbliotheque_app
{
    public partial class Preter : UserControl
    {
        public Preter()
        {
            InitializeComponent();
        }

        private void Preter_Resize(object sender, EventArgs e)
        {
            MainContentPanel.Left = (Width / 2) - (MainContentPanel.Width / 2) + 25;
        }

        private void RechercherBTN_Click(object sender, EventArgs e)
        {
            if (!IdentifiantTXT1.Text.Equals(string.Empty))
            {
                string id = IdentifiantTXT1.Text;

                if (Program.ds.Emprunteur.FindByID_Emprunteur(id) != null)
                {
                    //Remplire les information d'emprunteur
                    try
                    {
                        chargerLesGrid(id);
                        BibliothèqueDataSet.EmprunteurRow r = Program.ds.Emprunteur.FindByID_Emprunteur(id);
                        IdentifiantTXT2.Text = r.ID_Emprunteur;
                        CinTXT.Text = r.CIN;
                        NomTXT.Text = r.Nom;
                        PrenomTXT.Text = r.Prenom;
                        FilierTXT.SelectedValue = r.CodeFilier;
                        EmailTXT.Text = r.Email;
                        textBox8.Text = r.Tele;
                        TypeComboBOX2.SelectedValue = r.IdTypeEmp;
                        if (r.Sexe == "M")
                        {
                            SexeM.Checked = true;
                        }
                        else
                        {
                            SexeF.Checked = true;
                        }
                        disable();
                        ModifierBTN.Text = "Modifier";
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); chargerLesGrid(id); }
                }
                else
                {
                    if (MessageBox.Show("Cette emprunteur n'exist pas ,voulez vous l'ajoute?", "ajouter emprunteur", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        AjouterEmrunteur ajou = new AjouterEmrunteur();
                        if (ajou.ShowDialog() != DialogResult.Cancel) chargerAutoCompliteSourceIdentifiant();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vous deviez remplire l'identifiant !");
            }
        }

        private void NouveauFilierBTN_Click(object sender, EventArgs e)
        {
            Filiere Filiere1 = new Filiere();
            Filiere1.ShowDialog();
            Load1();
        }

        void enable()
        {
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
            CIN.Enabled = false;
            Nom.Enabled = false;
            Prenom.Enabled = false;
            Filier.Enabled = false;
            Email.Enabled = false;
            Tele.Enabled = false;
            Type.Enabled = false;
            Sexe.Enabled = false;
        }

        private void ModifierBTN_Click(object sender, EventArgs e)
        {
            if (!IdentifiantTXT2.Text.Equals(string.Empty))
                if (ModifierBTN.Text == "Modifier")
                {
                    ModifierBTN.Text = "Valider";
                    enable();
                }
                else
                {

                    try
                    {
                        string cin = CinTXT.Text;
                        if (TypeComboBOX2.SelectedValue.ToString() != "1") { cin = IdentifiantTXT2.Text; }
                        BibliothèqueDataSet.EmprunteurRow er = Program.ds.Emprunteur.FindByID_Emprunteur(IdentifiantTXT2.Text);
                        er.CIN = cin;
                        er.Nom = NomTXT.Text;
                        er.Prenom = PrenomTXT.Text;
                        er.CodeFilier = FilierTXT.SelectedValue.ToString();
                        er.Email = EmailTXT.Text;
                        er.Tele = textBox8.Text;
                        er.IdTypeEmp = (int)TypeComboBOX2.SelectedValue;
                        string sx = "M";
                        if (SexeF.Checked)
                        {
                            sx = "F";
                        }
                        er.Sexe = sx;
                        MessageBox.Show("l'Emprunteur est Modifier avec succes !");
                        Program.emprunteurTA.Update(Program.ds.Emprunteur);
                        ModifierBTN.Text = "Modifier";
                        disable();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
        }

        private void TypeComboBOX1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeComboBOX1.SelectedValue.ToString() == "1"/*etudiant*/)
            {
                CIN.Show();
                label2.Text = "N° d'inscription";
                Identifiantlabel.Text = "N° d'inscription";
                Filier.Show();
            }
            else
                if (TypeComboBOX1.SelectedValue.ToString() == "3"/*prof*/)
                {
                    CIN.Hide();
                    label2.Text = "CIN";
                    Identifiantlabel.Text = "CIN";
                    Filier.Show();
                }
                else /*Extern*/
                {
                    CIN.Hide();
                    label2.Text = "CIN";
                    Identifiantlabel.Text = "CIN";
                    Filier.Hide();
                }
        }

        private void EmprunterBTN_Click(object sender, EventArgs e)
        {
            if (!IdentifiantTXT2.Text.Equals(string.Empty) && !CoteTXT.Text.Equals(string.Empty))
            {
                if (Program.ds.Ouvrage.FindByCote(CoteTXT.Text) != null)
                {
                    try
                    {
                        if (Program.con.State == ConnectionState.Closed)
                            Program.con.Open();
                        Program.cmd.CommandText = "select dbo.QteValable('" + CoteTXT.Text + "')";
                        int qte = (int)Program.cmd.ExecuteScalar();
                        DateTime drp = DateTime.Now;
                        if (qte > 0)
                        {
                            if (qte == 1)
                            {
                                drp = drp.AddDays(1);
                                if (drp.DayOfWeek == DayOfWeek.Friday || drp.DayOfWeek == DayOfWeek.Saturday)
                                {
                                    drp = drp.AddDays(3);
                                }
                            }
                            else
                            {
                                drp = drp.AddDays(7);
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Le Quantite de ce document est null!", "confirmer l'opperation", MessageBoxButtons.YesNo) != DialogResult.Yes)
                            {
                                return;
                            }
                        }
                        Program.cmd.CommandText = "exec emprunterOuv '" + IdentifiantTXT2.Text
                            + "','" + CoteTXT.Text + "','" + SemestreComboBox.Text + "','" + drp.ToString("yyyyMMdd") + "'";
                        Program.cmd.ExecuteNonQuery();
                        MessageBox.Show("L'operation est passer avec succes!\n la date de retour prevoyer est : " + drp);
                        chargerLesGrid("");
                        vider(); CoteTXT.Text = ""; IdentifiantTXT1.Text = ""; disable();
                        ModifierBTN.Text = "Modifier";

                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); chargerLesGrid(""); }
                }
                else
                {
                    if (MessageBox.Show("Cette document n'exist pas ,voulez vous l'ajoute?", "ajouter document", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        AjouterDocumentForm ajou = new AjouterDocumentForm();
                        ajou.ShowDialog();
                        chargerAutoCompliteSourceCote();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vous deviez dabord verifier l'identifiant et choisire le Côte!");
            }
        }

        void Load1()
        {
            try
            {
                FilierTXT.DataSource = Program.ds.Filier;
                FilierTXT.DisplayMember = "Dèsignation";
                FilierTXT.ValueMember = "CodeFilier";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void load2()
        {
            try
            {
                TypeComboBOX1.DataSource = Program.ds.TypeEmprunteur;
                TypeComboBOX1.DisplayMember = "Dèsignation";
                TypeComboBOX1.ValueMember = "IdTypeEmp";
                TypeComboBOX2.DataSource = Program.ds.TypeEmprunteur;
                TypeComboBOX2.DisplayMember = "Dèsignation";
                TypeComboBOX2.ValueMember = "IdTypeEmp";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Preter_Load(object sender, EventArgs e)
        {
            try
            {
                chargerLesGrid("");
                load2();
                Load1();
                chargerAutoCompliteSourceCote();
                chargerAutoCompliteSourceIdentifiant();
                this.TypeComboBOX2.SelectedIndexChanged += new System.EventHandler(this.TypeComboBOX1_SelectedIndexChanged);
                this.TypeComboBOX1.SelectedIndexChanged += new System.EventHandler(this.TypeComboBOX1_SelectedIndexChanged);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); load2(); Load1(); }
        }

        void chargerAutoCompliteSourceIdentifiant()
        {
            try
            {
                AutoCompleteStringCollection c = new AutoCompleteStringCollection();
                IdentifiantTXT1.AutoCompleteCustomSource.Clear();
                if (!Program.ds.Ouvrage.Equals(null))
                {
                    foreach (BibliothèqueDataSet.EmprunteurRow r in Program.ds.Emprunteur)
                    {
                        c.Add(r.ID_Emprunteur);
                    }
                    SetControlPropertyValue(IdentifiantTXT1, "AutoCompleteCustomSource", c);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void chargerAutoCompliteSourceCote()
        {
            try
            {
                AutoCompleteStringCollection c = new AutoCompleteStringCollection();
                CoteTXT.AutoCompleteCustomSource.Clear();
                if (!Program.ds.Ouvrage.Equals(null))
                {
                    foreach (BibliothèqueDataSet.OuvrageRow r in Program.ds.Ouvrage)
                    {
                        c.Add(r.Cote);
                    }
                    CoteTXT.AutoCompleteCustomSource = c;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void chargerLesGrid(string filtrer)
        {
            if (Program.con.State == ConnectionState.Closed)
                Program.con.Open();
            SqlDataReader rd;
            try
            {
                DataView dv = new DataView();
                DataTable dt = new DataTable();
                Program.cmd.CommandText = "select * from LesEmpruntAretournee()";
                rd = Program.cmd.ExecuteReader();
                dt.Load(rd);
                DataView dv1 = new DataView(dt);
                dv.Table = Program.ds.LesSanctionnes;
                if (filtrer != "")
                {
                    dv.RowFilter = "ID_Emprunteur='" + IdentifiantTXT1.Text + "'";
                    dv1.RowFilter = "ID_Emprunteur='" + IdentifiantTXT1.Text + "'";
                }
                if (!rd.IsClosed)
                {
                    rd.Close();
                }
                dv1.Sort = "DateEmprunt desc";
                EmpruntsGridView.DataSource = dv1;
                dv.Sort = "Date_Fin_Sanction desc";
                SanctionesGridView.DataSource = dv;
                dt.Dispose();
                if (Program.con.State != ConnectionState.Closed)
                    Program.con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void vider()
        {
            IdentifiantTXT2.Text = "";
            CinTXT.Text = "";
            NomTXT.Text = "";
            PrenomTXT.Text = "";
            EmailTXT.Text = "";
            textBox8.Text = "";
        }

        private void IdentifiantTXT1_TextChanged(object sender, EventArgs e)
        {
            if (IdentifiantTXT1.Text == "")
            {
                try
                {
                    chargerLesGrid("");
                }
                catch { chargerLesGrid(""); }
                vider();
            }
        }

        private void EmpruntsGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < EmpruntsGridView.Rows.Count)
                if (EmpruntsGridView.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    if (MessageBox.Show("Voulez vous vraiment faire cette operation?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        try
                        {
                            if (Program.con.State == ConnectionState.Closed)
                                Program.con.Open();
                            Program.cmd.CommandText = "exec dbo.Retourneremprunt " + EmpruntsGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                            Program.cmd.ExecuteNonQuery();
                            MessageBox.Show("L'emprunt est retourner avec sucsser!");
                            if (Program.con.State != ConnectionState.Closed)
                                Program.con.Close();
                            vider();
                            IdentifiantTXT1.Text = "";
                            chargerLesGrid("");
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                    }
                }
        }

        private void SanctionesGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < SanctionesGridView.Rows.Count)
                if (SanctionesGridView.Rows[e.RowIndex].Cells[2].Value != null)
                {
                    try
                    {
                        string id = SanctionesGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                        if (Program.ds.Emprunteur.FindByID_Emprunteur(id) != null)
                        {
                            Historique h = new Historique(id);
                            BackColor = Color.Gray;
                            Parent.Parent.BackColor = Color.Gray;
                            h.ShowDialog();
                            BackColor = Color.White;
                            Parent.Parent.BackColor = Color.White;
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
        }
        /// <summary>
        /// for threading
        /// </summary>
        /// <param name="oControl"></param>
        /// <param name="propName"></param>
        /// <param name="propValue"></param>
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Program.ds.Ouvrage.FindByCote(CoteTXT.Text) != null)
            {
                ModifierDocument md = new ModifierDocument(CoteTXT.Text);
                md.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ce document n'exist pas !");
            }
        }

        private void CoteTXT_TextChanged(object sender, EventArgs e)
        {
            if (CoteTXT.Text == "")
            {
                linkLabel1.Hide();
            }
            else
            {
                linkLabel1.Show();
            }
        }

        private void NonConfirmerLinkBTN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Asanctionnee asanctione = new Asanctionnee();
            asanctione.ShowDialog();
        }

        private void TousLesPrets_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TousLesEmprunts te = new TousLesEmprunts();
            te.ShowDialog();
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

        private void ActualiserBTN_Click(object sender, EventArgs e)
        {
            chargerAutoCompliteSourceCote(); chargerAutoCompliteSourceIdentifiant();
        }

    }
}
