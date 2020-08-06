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

namespace Gestion_de_bilbliotheque_app
{
    public partial class AjouterDocument : UserControl
    {
        public AjouterDocument()
        {
            InitializeComponent();
        }
       
        private void AjouterDocBTN_Click(object sender, EventArgs e)
        {
            if (!CoteTXT.Text.Equals(string.Empty) && !TitreTXT.Text.Equals(string.Empty) && !Inventaire1TXT.Text.Equals(string.Empty) && !AuteurTXT.Text.Equals(string.Empty) && !TypeDocTXT.Text.Equals(string.Empty) && !DomaineTXT.Text.Equals(string.Empty))
            {
                try
                {
                    Program.ds.Ouvrage.AddOuvrageRow(CoteTXT.Text,TitreTXT.Text,Inventaire1TXT.Text, Inventaire2TXT.Text,AuteurTXT.Text,
                        DomaineTXT.Text, SousDomaineTXT.Text,NversementTXT.Text,dateEntreTimePicker.Value, (int)QuantiteTXT.Value, TypeDocTXT.Text, ObservationTXT.Text);
                    MessageBox.Show("L'ajoute est fait avec succees!");
                    vider();
                    Program.docsTA.Update(Program.ds.Ouvrage);
                    label13.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                label13.Show();
            }
        }
        void vider()
        {
            NversementTXT.Text = "";
            CoteTXT.Text = "";
            TitreTXT.Text = "";
            Inventaire1TXT.Text = "";
            Inventaire2TXT.Text = "";
            AuteurTXT.Text = "";
            DomaineTXT.Text = "";
            SousDomaineTXT.Text = "";
            TypeDocTXT.Text = "";
            QuantiteTXT.Value = 1;
            ObservationTXT.Text = "";
        }
        void loadAuteur()
        {
            try
            {
                AuteurTXT.AutoCompleteCustomSource.Clear();
                AutoCompleteStringCollection c = new AutoCompleteStringCollection();
                if (!Program.ds.Auteur.Equals(null))
                {
                    foreach (BibliothèqueDataSet.AuteurRow r in Program.ds.Auteur)
                    {
                        c.Add(r.Auteur);
                    }
                    SetControlPropertyValue(AuteurTXT, "AutoCompleteCustomSource", c);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        void loadDomain()
        {
            try
            {
                AutoCompleteStringCollection c = new AutoCompleteStringCollection();
                DomaineTXT.AutoCompleteCustomSource.Clear();
                if (!Program.ds.Domaine.Equals(null))
                {
                    foreach (BibliothèqueDataSet.DomaineRow r in Program.ds.Domaine)
                    {
                        c.Add(r.Domaine);
                    }
                    SetControlPropertyValue(DomaineTXT, "AutoCompleteCustomSource", c);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        void loadSousDomain()
        {
            try
            {
                AutoCompleteStringCollection c = new AutoCompleteStringCollection();
                SousDomaineTXT.AutoCompleteCustomSource.Clear();
                if (!Program.ds.SousDomaine.Equals(null))
                {
                    foreach (BibliothèqueDataSet.SousDomaineRow r in Program.ds.SousDomaine)
                    {
                        c.Add(r.SousDomaine);
                    }
                    SetControlPropertyValue(SousDomaineTXT, "AutoCompleteCustomSource", c);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        void loadTypeDoc()
        {
            try
            {
                AutoCompleteStringCollection c = new AutoCompleteStringCollection();
                TypeDocTXT.AutoCompleteCustomSource.Clear();
                if (!Program.ds.TypesOuvrage.Equals(null))
                {
                    foreach (BibliothèqueDataSet.TypesOuvrageRow r in Program.ds.TypesOuvrage)
                    {
                        c.Add(r.TypeOuvrage);
                    }
                    SetControlPropertyValue(TypeDocTXT, "AutoCompleteCustomSource", c);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void AjouterDocument_Load(object sender, EventArgs e)
        {
            try
            {
                loadAuteur(); loadDomain(); loadSousDomain(); loadTypeDoc();
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
