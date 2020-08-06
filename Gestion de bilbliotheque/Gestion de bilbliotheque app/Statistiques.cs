using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;

namespace Gestion_de_bilbliotheque_app
{
    public partial class Statistiques : UserControl
    {
        string du = "", au = "", session = "S2,S4,S6,S1,S3,S5", sexe = "", filier = "", typeEmp = "", typeDoc = "", domaineOuSous = "";

        public Statistiques()
        {
            InitializeComponent();
            AuDateTimePicker.Value = DateTime.Now;
        }

        void filtrerEmp()
        {
            try
            {
                string where = "";
                if (sexe != "" || filier != "" || typeEmp != "")
                {
                    where = " where ";
                    if (sexe != "")
                    {
                        where += " sexe like '%" + sexe + "%' ";
                    }
                    if (filier != "")
                    {
                        if (sexe != "")
                        {
                            where += " and  filier like '%" + filier + "%' ";
                        }
                        else
                        {
                            where += " filier like '%" + filier + "%' ";
                        }
                    }
                    if (typeEmp != "")
                    {
                        if (sexe != "" || filier != "")
                        {
                            where += " and  idType =" + typeEmp;
                        }
                        else
                        {
                            where += " idType =" + typeEmp;
                        }
                    }
                }
                SqlDataReader rd;
                if (Program.con.State == ConnectionState.Closed)
                {
                    Program.con.Open();
                }
                DataTable dt = new DataTable();
                Program.cmd.CommandText = "select nb as 'Nombre de prets',TypeEmp as 'Type',ID,Nom,Prenom,sexe from statistiqueParEmp('" + du + "','" + au + "','" + session + "') " + where;
                rd = Program.cmd.ExecuteReader();
                dt.Load(rd);
                DataView dv1 = new DataView(dt);
                if (!rd.IsClosed)
                {
                    rd.Close();
                }
                dv1.Sort = "Nombre de prets desc";
                dataGridViewEmp.DataSource = dv1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void filtrerDoc()
        {
            try
            {
                string where = "";
                if (typeDoc != "" || domaineOuSous != "")
                {
                    where = " where ";
                    if (typeDoc != "")
                    {
                        where += " TypeDoc like '%" + typeDoc + "%' ";
                    }
                    if (domaineOuSous != "")
                    {
                        if (typeDoc != "")
                        {
                            where += " and  domain like '%" + domaineOuSous + "%' or Sdomain  like '%" + domaineOuSous + "%' ";
                        }
                        else
                        {
                            where += " domain like '%" + domaineOuSous + "%' or Sdomain  like '%" + domaineOuSous + "%' ";
                        }
                    }

                }
                SqlDataReader rd;
                if (Program.con.State == ConnectionState.Closed)
                {
                    Program.con.Open();
                }
                DataTable dt = new DataTable();
                Program.cmd.CommandText = "select nb as 'Nombre de prets',Cote,titre,auteur,TypeDoc as 'Type du document',domain as 'Domaine' from statistiqueParDoc('" + du + "','" + au + "','" + session + "') " + where;
                rd = Program.cmd.ExecuteReader();
                dt.Load(rd);
                DataView dv1 = new DataView(dt);
                if (!rd.IsClosed)
                {
                    rd.Close();
                }
                dv1.Sort = "Nombre de prets desc";
                dataGridViewDoc.DataSource = dv1;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void SessionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SessionPanel.Enabled = SessionRadioButton.Checked;
                SemestrePanel.Enabled = SemestreRadioButton.Checked;
                session = "S2,S4,S6,S1,S3,S5"; SessionComboBox.SelectedIndex = -1;
                SemestreComboBox.SelectedIndex = -1;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void periodeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Periode.Enabled = periodeCheckBox.Checked;
                if (!periodeCheckBox.Checked)
                {
                    SessionSemestrecheckBox.Checked = false;
                    DuDateTimePicker.Value = DateTime.Now.Subtract(new TimeSpan(1900, 0, 0, 0));
                    AuDateTimePicker.Value = DateTime.Now;
                    du = DuDateTimePicker.Value.ToString("yyyyMMdd");
                    au = AuDateTimePicker.Value.ToString("yyyyMMdd"); 
                }
                session = "S2,S4,S6,S1,S3,S5"; 
                SessionComboBox.SelectedIndex = -1;
                SemestreComboBox.SelectedIndex = -1;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void SessionSemestrecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SgroupBox.Enabled = SessionSemestrecheckBox.Checked;
                session = "S2,S4,S6,S1,S3,S5"; SessionComboBox.SelectedIndex = -1;
                SemestreComboBox.SelectedIndex = -1;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void EmpCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            emprunteur.Enabled = EmpCheckBox.Checked;
            typeEmp = ""; TypeEmpComboBox.SelectedIndex = -1;
            filier = ""; FiliereComboBox.SelectedIndex = -1;
            sexe = ""; SexeComboBox.SelectedIndex = -1;
        }

        private void DocumentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Document.Enabled = DocumentCheckBox.Checked;
            typeDoc = ""; TypeDocComboBox.SelectedIndex = -1;
            domaineOuSous = ""; DomaineComboBox.SelectedIndex = -1;
        }

        private void dataGridViewEmp_DataSourceChanged(object sender, EventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow r in dataGridViewEmp.Rows)
            {
                count += int.Parse(r.Cells[0].Value.ToString());
            }
            TotalEmpLBL.Text = "Total : " + count;
        }

        private void dataGridViewDoc_DataSourceChanged(object sender, EventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow r in dataGridViewDoc.Rows)
            {
                count += int.Parse(r.Cells[0].Value.ToString());
            }
            TotaldocLBL.Text = "Total : " + count;
        }

        private void Statistiques_Resize(object sender, EventArgs e)
        {
            Main.Left = 30;
            Main.Top = (Height / 9);
        }

        private void SessionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SessionComboBox.SelectedIndex == 0)
            {
                session = "S1,S3,S5";
            }
            else
                if (SessionComboBox.SelectedIndex == 1)
                {
                    session = "S2,S4,S6";
                }
            filtrerDoc(); filtrerEmp();
        }

        private void SemestreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SemestreComboBox.SelectedIndex != -1)
                session = SemestreComboBox.Items[SemestreComboBox.SelectedIndex].ToString();
            filtrerDoc(); filtrerEmp();
        }

        private void TypeEmpComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeEmpComboBox.SelectedIndex != -1)
                typeEmp = TypeEmpComboBox.SelectedValue.ToString();
            filtrerEmp();
        }

        private void FiliereComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiliereComboBox.SelectedIndex != -1)
                filier = FiliereComboBox.SelectedValue.ToString();
            filtrerEmp();
        }

        private void SexeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SexeComboBox.SelectedIndex != -1)
                sexe = SexeComboBox.Items[SexeComboBox.SelectedIndex].ToString();
            filtrerEmp();
        }

        private void TypeDocComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeDocComboBox.SelectedIndex != -1)
                typeDoc = TypeDocComboBox.Text;
            filtrerDoc();
        }

        private void DomaineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DomaineComboBox.SelectedIndex != -1)
                domaineOuSous = DomaineComboBox.Text;
            filtrerDoc();
        }

        private void TypeEmpComboBox_TextChanged(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            if (box.Text == "")
                box.SelectedIndex = -1;
            if (box.Equals(DomaineComboBox))
            {
                domaineOuSous = "";
            }
            else
                if (box.Equals(TypeDocComboBox))
                {
                    typeDoc = "";
                }
                else
                    if (box.Equals(TypeEmpComboBox))
                    {
                        typeEmp = "";
                    }
                    else
                        if (box.Equals(FiliereComboBox))
                        {
                            filier = "";
                        }
                        else
                            if (box.Equals(SexeComboBox))
                            {
                                sexe = "";
                            }
            filtrerDoc(); filtrerEmp();
        }

        private void DuDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            du = DuDateTimePicker.Value.ToString("yyyyMMdd"); 
            filtrerDoc(); filtrerEmp();
        }

        private void AuDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            au = AuDateTimePicker.Value.ToString("yyyyMMdd"); 
            filtrerDoc(); filtrerEmp();
        }

        private void Statistiques_Load(object sender, EventArgs e)
        {
            try
            {
                FiliereComboBox.DataSource = Program.ds.Filier;
                FiliereComboBox.DisplayMember = "Dèsignation";
                FiliereComboBox.ValueMember = "CodeFilier";
                TypeEmpComboBox.DataSource = Program.ds.TypeEmprunteur;
                TypeEmpComboBox.DisplayMember = "Dèsignation";
                TypeEmpComboBox.ValueMember = "IdTypeEmp";
                TypeDocComboBox.DataSource = Program.ds.TypesOuvrage;
                TypeDocComboBox.DisplayMember = "TypeOuvrage";
                List<string> dEtsDomaine = new List<string>();
                
                foreach (BibliothèqueDataSet.SousDomaineRow r in Program.ds.SousDomaine)
                {
                    dEtsDomaine.Add(r.SousDomaine);
                }
                foreach (BibliothèqueDataSet.DomaineRow r in Program.ds.Domaine)
                {
                    dEtsDomaine.Add(r.Domaine);
                }
                DomaineComboBox.DataSource = dEtsDomaine;
                this.dataGridViewEmp.DataSourceChanged += new System.EventHandler(this.dataGridViewEmp_DataSourceChanged);
                this.dataGridViewDoc.DataSourceChanged += new System.EventHandler(this.dataGridViewDoc_DataSourceChanged);
                this.AuDateTimePicker.ValueChanged += new System.EventHandler(this.AuDateTimePicker_ValueChanged);
                this.DuDateTimePicker.ValueChanged += new System.EventHandler(this.DuDateTimePicker_ValueChanged);
                du = DuDateTimePicker.Value.ToString("yyyyMMdd"); 
                au = AuDateTimePicker.Value.ToString("yyyyMMdd"); 
                FiliereComboBox.SelectedIndex = -1;
                TypeEmpComboBox.SelectedIndex = -1;
                TypeDocComboBox.SelectedIndex = -1;
                filtrerDoc(); filtrerEmp(); DomaineComboBox.SelectedIndex = -1;
                this.TypeEmpComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeEmpComboBox_SelectedIndexChanged);
                this.FiliereComboBox.SelectedIndexChanged += new System.EventHandler(this.FiliereComboBox_SelectedIndexChanged);
                this.TypeDocComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeDocComboBox_SelectedIndexChanged);
                this.DomaineComboBox.SelectedIndexChanged += new System.EventHandler(this.DomaineComboBox_SelectedIndexChanged);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void createPDF(bool parEmp, DataGridView dgv)
        {
            try
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;
                    string headerTXT = "", type = "", filier2 = "", sexe2 = "", domainS = "";
                    string documentName = folderBrowser.SelectedPath;
                    #region condition
                    if (parEmp)
                    {
                        headerTXT = "Fiche de préts par emprunteur";

                        if (typeEmp == "")
                            type = "Type d'emprunteur : Tous";
                        else
                            type = "Type d'emprunteur :  " + TypeEmpComboBox.Text;
                        if (filier == "")
                            filier2 = "Filier : Tous";
                        else
                            filier2 = "Filier :  " + filier;
                        if (sexe == "")
                            sexe2 = "Sexe  :  Tous";
                        else
                        {
                            if (sexe == "M")
                                sexe2 = "Sexe  :   Masculin";
                            else
                                sexe2 = "Sexe  :   Féminin";
                        }
                    }
                    else
                    {
                        headerTXT = "Fiche de préts par document";
                        if (typeDoc == "")
                            type = "Type de document :  Tous";
                        else
                            type = "Type de document  :  " + typeDoc;
                        if (domaineOuSous == "")
                            domainS = "Domaine Ou Sous-domaine  : Tous";
                        else
                            domainS = "Domaine Ou Sous-domaine  :  " + domaineOuSous;
                    }
                    documentName += "\\" + headerTXT + " Le  " + DateTime.Now.ToString("dd-MM-yyyy") + ".pdf";
                    iTextSharp.text.Document doc = new Document(PageSize.LETTER, 10, 10, 35, 35);
                    PdfWriter wr = PdfWriter.GetInstance(doc, new FileStream(documentName, FileMode.Create));
                    doc.Open();
                    iTextSharp.text.Image royaum = iTextSharp.text.Image.GetInstance(Properties.Resources.royum1, BaseColor.WHITE);
                    royaum.ScalePercent(80);
                    royaum.Alignment = 0;
                    doc.Add(royaum);
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Properties.Resources.logo, BaseColor.WHITE);
                    logo.ScalePercent(65);
                    logo.SetAbsolutePosition((doc.PageSize.Width / 2) - 35f, doc.PageSize.Height - logo.Height);
                    doc.Add(logo);
                    iTextSharp.text.Image royaum2 = iTextSharp.text.Image.GetInstance(Properties.Resources.royum, BaseColor.WHITE);
                    royaum2.ScalePercent(70);
                    royaum2.SetAbsolutePosition(((doc.PageSize.Width) - (royaum2.Width - 30f)), (doc.PageSize.Height - royaum2.Height) - 10f);
                    doc.Add(royaum2);
                    Paragraph Labiblio = new Paragraph("\n\n  La bibliothéque");
                    Labiblio.Alignment = 1;
                    Labiblio.Font.Size = 12f;
                    Labiblio.Font.SetStyle(2);
                    doc.Add(Labiblio);
                    Paragraph leDate = new Paragraph("Le " + DateTime.Now.ToShortDateString());
                    leDate.Alignment = 2;
                    leDate.IndentationRight = 10f;
                    doc.Add(leDate);
                    Paragraph Headerpara = new Paragraph("\n" + headerTXT);
                    Headerpara.Alignment = 1; Headerpara.IndentationLeft = 5f;
                    Headerpara.Font.Size = 15f;
                    Headerpara.Font.SetStyle(6);
                    doc.Add(Headerpara);
                    Paragraph Periode = new Paragraph("\n\n  Période :\n");
                    Periode.IndentationLeft = 20f;
                    Periode.Font.Size = 10f;
                    Periode.Font.SetStyle(2);
                    doc.Add(Periode);
                    Paragraph DuAu = new Paragraph("\n  Du :     " + DuDateTimePicker.Value.ToShortDateString() + ".\n  Au :     " + AuDateTimePicker.Value.ToShortDateString() + ".\n");
                    DuAu.IndentationLeft = 60f;
                    DuAu.Font.Size = 10f;
                    DuAu.Font.SetStyle(3);
                    doc.Add(DuAu);
                    if (SessionSemestrecheckBox.Checked)
                    {
                        if (SessionComboBox.SelectedIndex != -1)
                        {
                            Paragraph ses = new Paragraph("\n   Session   :     " + SessionComboBox.Text + ".\n");
                            ses.IndentationLeft = 80f;
                            ses.Font.Size = 10f;
                            ses.Font.SetStyle(4);
                            doc.Add(ses);
                        }
                        else
                            if (SemestreComboBox.SelectedIndex != -1)
                            {
                                Paragraph sem = new Paragraph("\n  Semestre  :     " + session + ".\n");
                                sem.IndentationLeft = 80f;
                                sem.Font.Size = 10f;
                                sem.Font.SetStyle(4);
                                doc.Add(sem);
                            }
                    }

                    Paragraph typ = new Paragraph("\n  " + type + ".\n");
                    typ.IndentationLeft = 60f;
                    typ.Font.Size = 10f;
                    typ.Font.SetStyle(4);
                    doc.Add(typ);

                    if (parEmp)
                    {
                        Paragraph filSex = new Paragraph("\n  " + filier2 + ".\n  " + sexe2 + ".\n\n\n");
                        filSex.IndentationLeft = 60f;
                        filSex.Font.Size = 10f;
                        filSex.Font.SetStyle(4);
                        doc.Add(filSex);
                    }
                    else
                    {
                        Paragraph dom = new Paragraph("\n  " + domainS + ".\n\n\n");
                        dom.IndentationLeft = 60f;
                        dom.Font.Size = 10f;
                        dom.Font.SetStyle(4);
                        doc.Add(dom);
                    }
                    #endregion
                    PdfPTable table = new PdfPTable(dgv.ColumnCount);
                    for (int i = 0; i < dgv.ColumnCount; i++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(dgv.Columns[i].HeaderText));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        cell.Phrase.Font.Color = BaseColor.WHITE;
                        table.AddCell(cell);
                    }
                    table.HeaderRows = 1;
                    foreach (DataGridViewRow r in dgv.Rows)
                    {
                        foreach (DataGridViewCell c in r.Cells)
                        {
                            if (c.Value != null)
                            {
                                table.AddCell(new Phrase(c.Value.ToString()));
                            }
                        }
                    }
                    table.HorizontalAlignment = 1;
                    float w = doc.PageSize.Width / 6;
                    if (parEmp)
                    {
                        table.SetTotalWidth(new float[] { w + 20, w, w, w, w, w - 20 });
                        doc.Add(table);
                        Paragraph Totale1 = new Paragraph("\n  " + TotalEmpLBL.Text + ".\n");
                        Totale1.IndentationLeft = 70f;
                        Totale1.Font.Size = 16f;
                        Totale1.Font.SetStyle(8);
                        doc.Add(Totale1);
                    }
                    else
                    {
                        table.SetTotalWidth(new float[] { w - 20, w - 20, w + 50, w + 20, w - 20, w - 10 });
                        doc.Add(table);
                        Paragraph Totale2 = new Paragraph("\n  " + TotaldocLBL.Text + ".\n");
                        Totale2.IndentationLeft = 70f;
                        Totale2.Font.Size = 16f;
                        Totale2.Font.SetStyle(8);
                        doc.Add(Totale2);
                    }

                    Paragraph signe = new Paragraph("\n Signature  ");
                    signe.Alignment = 2;
                    signe.IndentationRight = 30f;
                    signe.Font.Size = 13f;
                    signe.Font.SetStyle(3);
                    doc.Add(signe);
                    doc.Close();
                    Process.Start(documentName);
                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); Cursor = Cursors.Default; }
        }

        private void EmpPDF_btn_Click(object sender, EventArgs e)
        {
            createPDF(true, dataGridViewEmp);
        }

        private void DocPDF_btn_Click(object sender, EventArgs e)
        {
            createPDF(false, dataGridViewDoc);
        }

        private void ParDomaine_Click(object sender, EventArgs e)
        {
            try
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    #region set datasource
                    SqlDataReader rd;
                    Cursor = Cursors.WaitCursor;
                    if (Program.con.State == ConnectionState.Closed)
                    {
                        Program.con.Open();
                    }
                    DataTable dt = new DataTable();
                    Program.cmd.CommandText = "select domain as 'Domaine',nb as 'Nombre de préts' from statistiqueParDomaine('" + du + "','" + au + "','" + session + "') order by nb desc";
                    rd = Program.cmd.ExecuteReader();
                    dt.Load(rd);
                    DataView dv1 = new DataView(dt);
                    if (!rd.IsClosed)
                    {
                        rd.Close();
                    }
                    dgv1.DataSource = dv1;
                    #endregion
                    string documentName = folderBrowser.SelectedPath + "\\Préts par domaine Le " + DateTime.Now.ToString("dd-MM-yyyy") + ".pdf";
                    iTextSharp.text.Document doc = new Document(PageSize.LETTER, 10, 10, 35, 35);
                    PdfWriter wr = PdfWriter.GetInstance(doc, new FileStream(documentName, FileMode.Create));
                    doc.Open();
                    iTextSharp.text.Image royaum = iTextSharp.text.Image.GetInstance(Properties.Resources.royum1, BaseColor.WHITE);
                    royaum.ScalePercent(80);
                    royaum.Alignment = 0;
                    doc.Add(royaum);
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Properties.Resources.logo, BaseColor.WHITE);
                    logo.ScalePercent(65);
                    logo.SetAbsolutePosition((doc.PageSize.Width / 2) - 35f, doc.PageSize.Height - logo.Height);
                    doc.Add(logo);
                    iTextSharp.text.Image royaum2 = iTextSharp.text.Image.GetInstance(Properties.Resources.royum, BaseColor.WHITE);
                    royaum2.ScalePercent(70);
                    royaum2.SetAbsolutePosition(((doc.PageSize.Width) - (royaum2.Width - 30f)), (doc.PageSize.Height - royaum2.Height) - 10f);
                    doc.Add(royaum2);
                    Paragraph Labiblio = new Paragraph("\n\n  La bibliothéque");
                    Labiblio.Alignment = 1;
                    Labiblio.Font.Size = 12f;
                    Labiblio.Font.SetStyle(2);
                    doc.Add(Labiblio);
                    Paragraph leDate = new Paragraph("Le " + DateTime.Now.ToShortDateString());
                    leDate.Alignment = 2;
                    leDate.IndentationRight = 10f;
                    doc.Add(leDate);
                    Paragraph Headerpara = new Paragraph("\n Fiche de préts par domaine\n\n\n\n\n");
                    Headerpara.Alignment = 1; Headerpara.IndentationLeft = 5f;
                    Headerpara.Font.Size = 15f;
                    Headerpara.Font.SetStyle(6);
                    doc.Add(Headerpara);

                    Paragraph Periode = new Paragraph("\n\n  Période :\n");
                    Periode.IndentationLeft = 20f;
                    Periode.Font.Size = 10f;
                    Periode.Font.SetStyle(2);
                    doc.Add(Periode);
                    Paragraph DuAu = new Paragraph("\n  Du :     " + DuDateTimePicker.Value.ToShortDateString() + ".\n  Au :     " + AuDateTimePicker.Value.ToShortDateString() + ".\n");
                    DuAu.IndentationLeft = 60f;
                    DuAu.Font.Size = 10f;
                    DuAu.Font.SetStyle(3);
                    doc.Add(DuAu);
                    if (SessionSemestrecheckBox.Checked)
                    {
                        if (SessionComboBox.SelectedIndex != -1)
                        {
                            Paragraph ses = new Paragraph("\n   Session   :     " + SessionComboBox.Text + ".\n");
                            ses.IndentationLeft = 80f;
                            ses.Font.Size = 10f;
                            ses.Font.SetStyle(4);
                            doc.Add(ses);
                        }
                        else
                            if (SemestreComboBox.SelectedIndex != -1)
                            {
                                Paragraph sem = new Paragraph("\n  Semestre  :     " + session + ".\n");
                                sem.IndentationLeft = 80f;
                                sem.Font.Size = 10f;
                                sem.Font.SetStyle(4);
                                doc.Add(sem);
                            }
                    }

                    PdfPTable table = new PdfPTable(dgv1.ColumnCount);
                    for (int i = 0; i < dgv1.ColumnCount; i++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(dgv1.Columns[i].HeaderText));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        cell.Phrase.Font.Color = BaseColor.WHITE;
                        table.AddCell(cell);
                    }
                    table.HeaderRows = 1;
                    int t = 0;
                    chart1.Series[0].Points.Clear();
                    foreach (DataGridViewRow r in dgv1.Rows)
                    {
                        t += int.Parse(r.Cells[1].Value.ToString());
                        chart1.Series[0].Points.AddXY(r.Cells[0].Value.ToString(), int.Parse(r.Cells[1].Value.ToString()));
                        foreach (DataGridViewCell c in r.Cells)
                        {
                            if (c.Value != null)
                            {
                                table.AddCell(new Phrase(c.Value.ToString()));
                            }
                        }
                    }
                    table.HorizontalAlignment = 1;
                    doc.Add(table);
                    Paragraph Totale2 = new Paragraph("\n Total  : " + t + ".\n");
                    Totale2.IndentationLeft = 70f;
                    Totale2.Font.Size = 16f;
                    Totale2.Font.SetStyle(8);
                    doc.Add(Totale2);
                    var chart = new MemoryStream();
                    chart1.SaveImage(chart, ChartImageFormat.Png);
                    iTextSharp.text.Image ch = iTextSharp.text.Image.GetInstance(chart.GetBuffer());
                    ch.Alignment = 1;
                    doc.Add(ch);
                    doc.Close();
                    Cursor = Cursors.Default;
                    Process.Start(documentName);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); Cursor = Cursors.Default; }

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
