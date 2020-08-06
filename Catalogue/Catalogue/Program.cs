using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Catalogue.BibliothèqueDataSetTableAdapters;
using System.Configuration;


namespace Catalogue
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            if (!Properties.Settings.Default.Set)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new SetSqlConnection());
            }
            else
            {
                con = new SqlConnection(Properties.Settings.Default.BibliothèqueConnectionString);
                cmd = new SqlCommand("", con);
                ds = new BibliothèqueDataSet();
                docsTA = new OuvrageTableAdapter();
                auter = new AuteurTableAdapter();
                domain = new DomaineTableAdapter();
                sousdomain = new SousDomaineTableAdapter();
                typeDoc = new TypesOuvrageTableAdapter();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Program.loadData();
                Application.Run(new LesDocuments());
            }
        }
        internal static SqlConnection con;
        internal static SqlCommand cmd;
        internal static BibliothèqueDataSet ds;
        internal static OuvrageTableAdapter docsTA;
        internal static AuteurTableAdapter auter;
        internal static DomaineTableAdapter domain;
        internal static SousDomaineTableAdapter sousdomain;
        internal static TypesOuvrageTableAdapter typeDoc;

        static void loadData()
        {
            try
            {
                domain.Fill(ds.Domaine);
                sousdomain.Fill(ds.SousDomaine);
                typeDoc.Fill(ds.TypesOuvrage);
                auter.Fill(ds.Auteur);
                docsTA.Fill(ds.Ouvrage);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
