using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Threading;

namespace Gestion_de_bilbliotheque_app
{
    public partial class Alimenter_la_base_de_deonnees : UserControl
    {
        public Alimenter_la_base_de_deonnees()
        {
            InitializeComponent();
        }
        
        private void Alimenter_la_base_de_deonnees_Resize(object sender, EventArgs e)
        {
            MainContentPanel.Left = (Width / 2) - (MainContentPanel.Width / 2) + 25;
        }
        
        void LoadEmprunteurs(string constring, string SheetName, string typeEmp)
        {

            try
            {
                OleDbConnection con = new OleDbConnection(constring);
                OleDbCommand cmd = new OleDbCommand("select Ninscription,CIN,Nom,Prenom,Filier,DateNaissance,LieuNaissance,Sexe,Email,Tele from [" +
                  SheetName + "$]", con);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                OleDbDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (rd.Read())
                {
                    if (rd[0].ToString() != "")
                    {
                        BibliothèqueDataSet.EmprunteurRow r = Program.ds.Emprunteur.FindByID_Emprunteur(rd[0].ToString());
                        if (r == null)
                        {
                            BibliothèqueDataSet.FilierRow fi = Program.ds.Filier.FindByCodeFilier(rd[4].ToString());
                            if (fi == null)
                            {
                                fi = Program.ds.Filier.FindByCodeFilier("NAN");
                                MessageBox.Show("Cette filiere : " + rd[4].ToString() + "n'exist pas !\nCe(tte) etudiant(e) va etre inserer avec une filiere indéfini!veuillez la modifier ulterierement\n  Veuilez dabord ajouter cette filier!", "filiere introuvable", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            DateTime date; string dat = rd[5].ToString();
                            if (DateTime.TryParse(dat, out date))
                            {
                                date.ToString("yyyy-MM-dd");
                            }
                            Program.ds.Emprunteur.AddEmprunteurRow(rd[0].ToString().TrimStart(), rd[1].ToString().TrimStart(), rd[2].ToString().TrimStart(), rd[3].ToString().TrimStart(), fi, date,
                            rd[6].ToString().TrimStart(), rd[7].ToString().Trim(), rd[8].ToString().TrimStart(), rd[9].ToString().TrimStart(), Program.ds.TypeEmprunteur.FindByIdTypeEmp(int.Parse(typeEmp)));

                        }
                    }
                }
                if (!rd.IsClosed)
                    rd.Close();
               
                Program.emprunteurTA.Update(Program.ds.Emprunteur);
                MessageBox.Show("L'importation de Emprunteurs est fait avec succees!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ".\n Vous peuvez redemarer l'operation!");
            }
        }
        
        void LoadDocuments(string constring, string SheetName, string typedoc)
        {

            try
            {
                OleDbConnection con = new OleDbConnection(constring);
                OleDbCommand cmd = new OleDbCommand("select PremierInventair,DernierInventair,COTE,TITRE,AUTEUR,DOMAINE,Sous_Domaine,Numero_De_Versment,Date_entre,QTE from [" +
                SheetName + "$]", con);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                OleDbDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (rd.Read())
                {

                    int q = 1;
                    int.TryParse(rd[9].ToString(), out q);
                    DateTime date; string dat = rd[8].ToString();
                    if (DateTime.TryParse(dat, out date))
                    {
                        date.ToString("yyyy-MM-dd");
                    }
                    if (rd[2] != null && rd[2].ToString() != "")
                    {
                        BibliothèqueDataSet.OuvrageRow r = Program.ds.Ouvrage.FindByCote(rd[2].ToString());
                        if (r == null)
                        {
                            Program.ds.Ouvrage.AddOuvrageRow(rd[2].ToString().TrimStart(), rd[3].ToString().TrimStart(), rd[0].ToString().TrimStart(), rd[1].ToString().TrimStart(), rd[4].ToString().TrimStart(), rd[5].ToString().TrimStart(),
                              rd[6].ToString().TrimStart(), rd[7].ToString().TrimStart(), date, q, typedoc, "");
                        }
                        else
                        {
                            r.Qte += q;
                            if (rd[1] != null)
                            {
                                r.DernierInventair = rd[1].ToString();
                            }
                            else
                                if (rd[0] != null)
                                {
                                    r.DernierInventair = rd[0].ToString();
                                }
                        }
                    }
                }
                if (!rd.IsClosed)
                    rd.Close();

                Program.docsTA.Update(Program.ds.Ouvrage);
                MessageBox.Show("L'importation de domcuments est fait avec succees!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ImporterDocuments_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                string ext = Path.GetExtension(filename);
                string constring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filename + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'";
                if (ext.ToLower() == ".xls")
                {
                    constring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filename + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                }
                inputVariabl input = new inputVariabl("d");
                if (input.ShowDialog() != DialogResult.OK)
                {
                    try
                    {
                        string type = "Ouvrage";
                        if (input.textBox2.Text != "")
                        {
                            type = input.textBox2.Text;
                        }
                        Thread tread = new Thread(() => LoadDocuments(constring, input.textBox1.Text, type));
                        tread.Start();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                string ext = Path.GetExtension(filename);
                string constring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filename + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'";
                if (ext.ToLower() == ".xls")
                {
                    constring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filename + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                }
                inputVariabl input = new inputVariabl("E");
                if (input.ShowDialog() != DialogResult.OK)
                {
                    try
                    {
                        Thread tread = new Thread(() => LoadEmprunteurs(constring, input.textBox1.Text, "1"));
                        tread.Start();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LesDocuments d = new LesDocuments();
            d.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LesEmprunteurs em = new LesEmprunteurs();
            em.ShowDialog();
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
