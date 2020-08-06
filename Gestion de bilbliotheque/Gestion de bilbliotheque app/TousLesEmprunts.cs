using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Gestion_de_bilbliotheque_app
{
    public partial class TousLesEmprunts : Form
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

        string id = "", DuAu = "", cote = "";
        
        public TousLesEmprunts()
        {
            InitializeComponent();
            MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            dv = new DataView(Program.ds.Emprunter);
        }

        DataView dv;
        string nomPrenom = "";
        void filtrer()
        {
            dv.RowFilter = id + cote + DuAu;
            dataGridView1.DataSource = dv;
        }

        private void LesEmprunteurs_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = dv;
                chargerAutoCompliteSourceCote(); chargerAutoCompliteSourceID();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void chargerAutoCompliteSourceCote()
        {
            AutoCompleteStringCollection c = new AutoCompleteStringCollection();
            foreach (BibliothèqueDataSet.OuvrageRow r in Program.ds.Ouvrage)
            {
                c.Add(r.Cote);
            }
            CoteTXT.AutoCompleteCustomSource = c;
        }

        void chargerAutoCompliteSourceID()
        {
            AutoCompleteStringCollection c = new AutoCompleteStringCollection();
            foreach (BibliothèqueDataSet.EmprunteurRow r in Program.ds.Emprunteur)
            {
                c.Add(r.ID_Emprunteur);
            }
            IDTXT.AutoCompleteCustomSource = c;
        }

        private void FermerBTN_Click(object sender, EventArgs e)
        {
            dv.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                id = "ID_Emprunteur like '%" + IDTXT.Text + "%' ";
                cote = " and Cote like '%" + CoteTXT.Text + "%' ";
                DuAu = " and DateEmprunt >= '" + dateTimePicker1.Value.ToShortDateString() + "' and DateEmprunt<='" + dateTimePicker2.Value.ToShortDateString() + "'";
                filtrer();
                if (IDTXT.Text != "" && dataGridView1.RowCount > 0)
                {
                    BibliothèqueDataSet.EmprunteurRow r = Program.ds.Emprunteur.FindByID_Emprunteur(dataGridView1.Rows[0].Cells[1].Value.ToString());
                    nomPrenom = r.Nom;
                    nomPrenom += " " + r.Prenom;
                }
                else
                {
                    nomPrenom = "";
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (nomPrenom != "")
                {
                    if (folderBrowser.ShowDialog() == DialogResult.OK)
                    {
                        #region Header
                        string documentName = folderBrowser.SelectedPath + "\\Fiche de Prét de " + nomPrenom + " Le " + DateTime.Now.ToString("dd-MM-yyyy") + ".pdf";
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
                        Paragraph Headerpara = new Paragraph("\n Fiche de Prét\n\n");
                        Headerpara.Alignment = 1; Headerpara.IndentationLeft = 5f;
                        Headerpara.Font.Size = 15f;
                        Headerpara.Font.SetStyle(6);
                        doc.Add(Headerpara);

                        Paragraph Nom = new Paragraph("\n Nom et Prénom  :  " + nomPrenom + ".\n\n");
                        Nom.IndentationLeft = 15f;
                        Nom.Font.Size = 15f;
                        Nom.Font.SetStyle(3);
                        doc.Add(Nom);
                        #endregion
                        PdfPTable table = new PdfPTable(4);
                        for (int i = 0; i < dataGridView1.ColumnCount; i++)
                        {
                            if (i != 1 && i != 3 && i != 6 && i != 7)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(dataGridView1.Columns[i].HeaderText));
                                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                                cell.Phrase.Font.Color = BaseColor.WHITE;
                                table.AddCell(cell);
                            }
                        }
                        table.HeaderRows = 1;
                        string id = dataGridView1.Rows[0].Cells[1].Value.ToString();
                        foreach (DataGridViewRow r in dataGridView1.Rows)
                        {
                            if (r.Cells[1].Value.ToString() == id && (bool)r.Cells[7].FormattedValue == false)
                            {
                                foreach (DataGridViewCell c in r.Cells)
                                {
                                    if (c.ColumnIndex != 1 && c.ColumnIndex != 3 && c.ColumnIndex != 6 && c.ColumnIndex != 7)
                                    {
                                        if (c.Value != null)
                                        {
                                            table.AddCell(new Phrase(c.Value.ToString()));
                                        }
                                        else
                                        {
                                            table.AddCell(new Phrase(""));
                                        }
                                    }
                                }
                            }
                        }
                        float w = doc.PageSize.Width / 4;
                        table.SetTotalWidth(new float[] { w - 40, w - 40, w + 40, w + 40 });
                        table.HorizontalAlignment = 1;
                        doc.Add(table);
                        Paragraph Worning = new Paragraph("\n\nVeuillez vous  présenté au comptoir de prêt pour régulariser votre situation. Merci! \n");
                        Worning.IndentationLeft = 35f;
                        Worning.Font.Color = BaseColor.RED;
                        Worning.Font.Size = 13f;
                        Worning.Font.SetStyle(2);
                        doc.Add(Worning);
                        doc.Close();
                        Cursor = Cursors.Default; 
                        Process.Start(documentName);
                    }
                }
                else
                {
                    MessageBox.Show("choisir le ID de l'emprunteur que vous voulez informer puis cliquer sur chercher,ou plutot cette personne n'a rien emprunter!");
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
