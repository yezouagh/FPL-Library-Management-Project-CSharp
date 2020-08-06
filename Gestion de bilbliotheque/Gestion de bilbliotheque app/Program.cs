using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Gestion_de_bilbliotheque_app.BibliothèqueDataSetTableAdapters;
using System.Configuration;


namespace Gestion_de_bilbliotheque_app
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
                con = new SqlConnection(Properties.Settings.Default.Bibliothèque);
                cmd = new SqlCommand("", con);
                ds = new BibliothèqueDataSet();
                lesSanctionesTA = new LesSanctionnesTableAdapter();
                emprunteurTA = new EmprunteurTableAdapter();
                typeEmpTA = new TypeEmprunteurTableAdapter();
                filierTA = new FilierTableAdapter();
                emprunteurSanctioneTA = new Emprunteur_SanctionneTableAdapter();
                docsTA = new OuvrageTableAdapter();
                auter = new AuteurTableAdapter();
                domain = new DomaineTableAdapter();
                sousdomain = new SousDomaineTableAdapter();
                typeDoc = new TypesOuvrageTableAdapter();
                em = new EmprunterTableAdapter();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Program.loadData();
                Application.Run(new Bienvenu());
                Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            }
        }
        internal static SqlConnection con;
        internal static SqlCommand cmd;
        internal static BibliothèqueDataSet ds;
        internal static LesSanctionnesTableAdapter lesSanctionesTA;
        internal static EmprunteurTableAdapter emprunteurTA;
        internal static TypeEmprunteurTableAdapter typeEmpTA;
        internal static FilierTableAdapter filierTA;
        internal static Emprunteur_SanctionneTableAdapter emprunteurSanctioneTA;
        internal static OuvrageTableAdapter docsTA;
        internal static AuteurTableAdapter auter;
        internal static DomaineTableAdapter domain;
        internal static SousDomaineTableAdapter sousdomain;
        internal static TypesOuvrageTableAdapter typeDoc;
        internal static EmprunterTableAdapter em;

        static void loadData()
        {
            try
            {
                em.Fill(ds.Emprunter);
                emprunteurTA.Fill(ds.Emprunteur);
                typeEmpTA.Fill(ds.TypeEmprunteur);
                filierTA.Fill(ds.Filier);
                domain.Fill(ds.Domaine);
                sousdomain.Fill(ds.SousDomaine);
                typeDoc.Fill(ds.TypesOuvrage);
                auter.Fill(ds.Auteur);
                emprunteurSanctioneTA.Fill(ds.Emprunteur_Sanctionne);
                docsTA.Fill(ds.Ouvrage);
                lesSanctionesTA.Fill(ds.LesSanctionnes);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        static void Application_ApplicationExit(object sender, EventArgs e)
        {
            //UPDATE DATABASE
            Program.emprunteurSanctioneTA.Update(Program.ds.Emprunteur_Sanctionne);
            Program.ds.AcceptChanges();
        }
    }
}
