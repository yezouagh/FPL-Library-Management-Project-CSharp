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

namespace Catalogue
{
    public partial class LesDocuments : Form
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
        DataView dv;
        string type = " 1=1", domain = " and Domaine like '%%' ", sousD = " and SousDomaine like '%%' ", auteur = " and Auteur like '%%' ",
            cote = " and Cote like '%%' ", titre = " and Titre like '%%' ";
        
        public LesDocuments()
        {
            try
            {
                InitializeComponent();
                dv= new DataView(Program.ds.Ouvrage);
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message); 
            }
        }

        void filtrer()
        {
            try
            {
                dv.RowFilter = type + domain + sousD + auteur + cote + titre;
                dataGridView1.DataSource = dv.ToTable(false,new string[]{"Cote","Titre","Auteur","Domaine","SousDomaine","Qte","TypeOuvrage","Observation"});
                totalLbl.Text = "Total : " + dv.Count;
                int count = 0;
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    count += int.Parse(r.Cells[5].Value.ToString());
                }
                QuantiteLbl.Text = "Quantite : " + count;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void LesEmprunteurs_Load(object sender, EventArgs e)
        {
            try
            {
                filtrer();
                dataGridView1.Columns[0].Width = 80;
                dataGridView1.Columns[1].Width = 350;
                dataGridView1.Columns[2].Width = 250;
                dataGridView1.Columns[3].Width = 120;
                dataGridView1.Columns[4].Width = 120;
                dataGridView1.Columns[5].Width = 40;
                dataGridView1.Columns[6].Width = 70;
                dataGridView1.Columns[7].Width = 70;
                loadAuteur();
                loadDomain();
                chargerAutoCompliteSourceCote();
                loadSousDomain();
                TypeComboBox.DataSource = Program.ds.TypesOuvrage;
                TypeComboBox.DisplayMember = "TypeOuvrage";
                TypeComboBox.SelectedItem = null;
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

        void loadAuteur()
        {
            try
            {
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
                foreach (BibliothèqueDataSet.DomaineRow r in Program.ds.Domaine)
                {
                    c.Add(r.Domaine);
                }
                SetControlPropertyValue(DomaintTXT, "AutoCompleteCustomSource", c);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void loadSousDomain()
        {
            try
            {
                AutoCompleteStringCollection c = new AutoCompleteStringCollection();
                foreach (BibliothèqueDataSet.SousDomaineRow r in Program.ds.SousDomaine)
                {
                    c.Add(r.SousDomaine);
                }
                SetControlPropertyValue(SousDomaineTXT, "AutoCompleteCustomSource", c);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void IdentifiantTXT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sousD = " and SousDomaine like '%" + SousDomaineTXT.Text + "%' ";
                filtrer();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void NomTXT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                auteur = " and Auteur like '%" + AuteurTXT.Text + "%' ";
                filtrer();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cote = " and Cote like '%" + CoteTXT.Text + "%' ";
                filtrer();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void DomaintTXT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                domain = " and Domaine like '%" + DomaintTXT.Text + "%' ";
                filtrer();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Titre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                titre = " and Titre like '%" + TitreTXT.Text + "%' ";
                filtrer();
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

        private void TypeComboBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                type = "TypeOuvrage like '%" + TypeComboBox.Text + "%' ";
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

    }
}
