using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Attach_library_database
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string op = "";
            try
            {
                Console.WriteLine("Selectioner L'operation que vous voulez faire ?\n\n1)-Attacher la base de données.\n\n2)-Détacher la base de données.\n\n3)-Executer une command.\n");
                op = Console.ReadLine();
                if (op == "1")
                {
                    attach(Environment.MachineName);
                }
                else
                    if (op == "2")
                    {
                        detach(Environment.MachineName);
                    }
                    else
                    {
                        executeQuery(Environment.MachineName);
                    }
                Console.WriteLine("L'operation est passer avec succès.");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("s'il vous plait, tapez le nom de votre pc qui contient SQL server !");
                string pc = Console.ReadLine();
                try
                {
                    if (op == "1")
                    {
                        attach(pc);
                    }
                    else if (op == "2")
                    {
                        detach(pc);
                    }
                    else
                    {
                        executeQuery(pc);
                    }
                    Console.WriteLine("L'operation est passer avec succès.");
                }
                catch (Exception ex2)
                {
                    Console.WriteLine(ex2.Message + Environment.NewLine + "cliquer sur un clé pour redémarrer le processus.");
                    Console.ReadKey();
                    string Exepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                    string Directory = System.IO.Path.GetDirectoryName(Exepath);
                    Process.Start(Directory + "\\Attach library database.exe");
                    Environment.Exit(0);
                }
            }

        }
        
        static void attach(string pc)
        {
            string Exepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string Directory = System.IO.Path.GetDirectoryName(Exepath);
            SqlConnection con = new SqlConnection("Data Source=" + pc + "\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("EXEC sp_attach_db @dbname = 'Bibliothèque',@filename1 ='" + Directory +
                "\\Bibliothèque.mdf',@filename2 = '" + Directory + "\\Bibliothèque_log.ldf';", con);
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            cmd.ExecuteNonQuery();
            cmd.CommandText = "exec sp_configure 'remote access',1;";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "reconfigure with override";
            
        }

        static void detach(string pc)
        {
            SqlConnection con = new SqlConnection("Data Source=" + pc + "\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("EXEC sp_detach_db @dbname = 'Bibliothèque';", con);
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            cmd.ExecuteNonQuery();
        }
        
        static void executeQuery(string pc)
        {
            do
            {
                try
                {
                    SqlConnection con;
                    Console.WriteLine("\nChoisir la base de donnés : \n\n 1)-master.\n\n 2)-Bibliothèque.\n");
                    if (Console.ReadLine() == "1")
                    {
                        con = new SqlConnection("Data Source=" + pc + "\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
                    }
                    else
                    {
                        con = new SqlConnection("Data Source=" + pc + "\\SQLEXPRESS;Initial Catalog=Bibliothèque;Integrated Security=True");
                    }
                    Console.WriteLine("\nTaper votre sql command  :\n");
                    string cmand = Console.ReadLine();
                    SqlCommand cmd = new SqlCommand(cmand, con);
                    if (con.State == System.Data.ConnectionState.Closed)
                        con.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("\nCommand execute avec succes.!\n");
                }
                catch (Exception ex) 
                { 
                    Console.WriteLine("erreur : " + ex.Message);
                    executeQuery(pc);
                }
                Console.WriteLine("\nVoulez vous taper Une Autre command? Oui /Non\n");
            } 
            while (Console.ReadLine().ToLower() == "oui");
        }
    }
}
