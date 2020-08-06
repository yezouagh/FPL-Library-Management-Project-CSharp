using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Gestion_de_bilbliotheque_app
{
    public partial class Historique : Form
    {
        string ID;
        public Historique(string id)
        {
            InitializeComponent();
            ID = id;
            MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
        }


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

        private void TypeComboBOX2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeComboBOX2.SelectedValue.ToString() == "1"/*etudiant*/)
            {
                CIN.Show();
                Identifiantlabel.Text = "N° d'inscription";
                Filier.Show();
            }
            else
                if (TypeComboBOX2.SelectedValue.ToString() == "3"/*prof*/)
                {
                    CIN.Hide();
                    Identifiantlabel.Text = "CIN";
                    Filier.Show();
                }
                else /*Extern*/
                {
                    CIN.Hide();
                    Identifiantlabel.Text = "CIN";
                    Filier.Hide();
                }
        }

        void remplire()
        {
            BibliothèqueDataSet.EmprunteurRow r = Program.ds.Emprunteur.FindByID_Emprunteur(ID);
            IdentifiantTXT2.Text = r.ID_Emprunteur;
            CinTXT.Text = r.CIN;
            NomTXT.Text = r.Nom;
            label1.Text = "Historique de " + r.Nom + " " + r.Prenom;
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
        }

        private void Historique_Load(object sender, EventArgs e)
        {
            this.filierTableAdapter.Fill(this.bibliothèqueDataSet.Filier);
            this.typeEmprunteurTableAdapter.Fill(this.bibliothèqueDataSet.TypeEmprunteur);
            remplire();
            DataView dv = new DataView(Program.ds.Emprunter);
            dv.RowFilter = "ID_Emprunteur='" + ID + "'";
            dataGridView1.DataSource = dv;
            NbPretsLbl.Text = dv.Count.ToString();
            BibliothèqueDataSetTableAdapters.QueriesTableAdapter nb = new BibliothèqueDataSetTableAdapters.QueriesTableAdapter();
            NbSanctionLbl.Text = nb.NbrSanction(ID).Value.ToString();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.NbSanctionLbl = new System.Windows.Forms.Label();
            this.bibliothèqueDataSet = new Gestion_de_bilbliotheque_app.BibliothèqueDataSet();
            this.typeEmprunteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeEmprunteurTableAdapter = new Gestion_de_bilbliotheque_app.BibliothèqueDataSetTableAdapters.TypeEmprunteurTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.NbPretsLbl = new System.Windows.Forms.Label();
            this.filierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filierTableAdapter = new Gestion_de_bilbliotheque_app.BibliothèqueDataSetTableAdapters.FilierTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Identifiant = new System.Windows.Forms.Panel();
            this.Identifiantlabel = new System.Windows.Forms.Label();
            this.IdentifiantTXT2 = new System.Windows.Forms.TextBox();
            this.CIN = new System.Windows.Forms.Panel();
            this.CINLabel = new System.Windows.Forms.Label();
            this.CinTXT = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.Panel();
            this.NomLabel = new System.Windows.Forms.Label();
            this.NomTXT = new System.Windows.Forms.TextBox();
            this.Prenom = new System.Windows.Forms.Panel();
            this.PrenomLabel = new System.Windows.Forms.Label();
            this.PrenomTXT = new System.Windows.Forms.TextBox();
            this.Filier = new System.Windows.Forms.Panel();
            this.FilierTXT = new System.Windows.Forms.ComboBox();
            this.FilierLabel = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Panel();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTXT = new System.Windows.Forms.TextBox();
            this.Tele = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.Panel();
            this.TypeComboBOX2 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.Sexe = new System.Windows.Forms.Panel();
            this.SexeM = new System.Windows.Forms.RadioButton();
            this.SexeF = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothèqueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeEmprunteurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filierBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.Identifiant.SuspendLayout();
            this.CIN.SuspendLayout();
            this.Nom.SuspendLayout();
            this.Prenom.SuspendLayout();
            this.Filier.SuspendLayout();
            this.Email.SuspendLayout();
            this.Tele.SuspendLayout();
            this.Type.SuspendLayout();
            this.Sexe.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 33);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(432, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Historique de  ?";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(989, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Fermer";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.button1, "Fermer cette interface.");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(419, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 319);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Les prets";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(633, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre de sanctions : ";
            // 
            // NbSanctionLbl
            // 
            this.NbSanctionLbl.AutoSize = true;
            this.NbSanctionLbl.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbSanctionLbl.Location = new System.Drawing.Point(160, 373);
            this.NbSanctionLbl.Name = "NbSanctionLbl";
            this.NbSanctionLbl.Size = new System.Drawing.Size(15, 17);
            this.NbSanctionLbl.TabIndex = 10;
            this.NbSanctionLbl.Text = "0";
            // 
            // bibliothèqueDataSet
            // 
            this.bibliothèqueDataSet.DataSetName = "BibliothèqueDataSet";
            this.bibliothèqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeEmprunteurBindingSource
            // 
            this.typeEmprunteurBindingSource.DataMember = "TypeEmprunteur";
            this.typeEmprunteurBindingSource.DataSource = this.bibliothèqueDataSet;
            // 
            // typeEmprunteurTableAdapter
            // 
            this.typeEmprunteurTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(910, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre des prets : ";
            // 
            // NbPretsLbl
            // 
            this.NbPretsLbl.AutoSize = true;
            this.NbPretsLbl.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbPretsLbl.Location = new System.Drawing.Point(1048, 373);
            this.NbPretsLbl.Name = "NbPretsLbl";
            this.NbPretsLbl.Size = new System.Drawing.Size(15, 17);
            this.NbPretsLbl.TabIndex = 10;
            this.NbPretsLbl.Text = "0";
            // 
            // filierBindingSource
            // 
            this.filierBindingSource.DataMember = "Filier";
            this.filierBindingSource.DataSource = this.bibliothèqueDataSet;
            // 
            // filierTableAdapter
            // 
            this.filierTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 319);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.Identifiant);
            this.flowLayoutPanel2.Controls.Add(this.CIN);
            this.flowLayoutPanel2.Controls.Add(this.Nom);
            this.flowLayoutPanel2.Controls.Add(this.Prenom);
            this.flowLayoutPanel2.Controls.Add(this.Filier);
            this.flowLayoutPanel2.Controls.Add(this.Email);
            this.flowLayoutPanel2.Controls.Add(this.Tele);
            this.flowLayoutPanel2.Controls.Add(this.Type);
            this.flowLayoutPanel2.Controls.Add(this.Sexe);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(11, 17);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(385, 287);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // Identifiant
            // 
            this.Identifiant.Controls.Add(this.Identifiantlabel);
            this.Identifiant.Controls.Add(this.IdentifiantTXT2);
            this.Identifiant.Enabled = false;
            this.Identifiant.Location = new System.Drawing.Point(3, 3);
            this.Identifiant.Name = "Identifiant";
            this.Identifiant.Size = new System.Drawing.Size(368, 25);
            this.Identifiant.TabIndex = 0;
            // 
            // Identifiantlabel
            // 
            this.Identifiantlabel.AutoSize = true;
            this.Identifiantlabel.Location = new System.Drawing.Point(16, 6);
            this.Identifiantlabel.Name = "Identifiantlabel";
            this.Identifiantlabel.Size = new System.Drawing.Size(77, 13);
            this.Identifiantlabel.TabIndex = 11;
            this.Identifiantlabel.Text = "N° d\'inscription";
            // 
            // IdentifiantTXT2
            // 
            this.IdentifiantTXT2.Location = new System.Drawing.Point(124, 1);
            this.IdentifiantTXT2.Name = "IdentifiantTXT2";
            this.IdentifiantTXT2.Size = new System.Drawing.Size(165, 20);
            this.IdentifiantTXT2.TabIndex = 18;
            // 
            // CIN
            // 
            this.CIN.Controls.Add(this.CINLabel);
            this.CIN.Controls.Add(this.CinTXT);
            this.CIN.Enabled = false;
            this.CIN.Location = new System.Drawing.Point(3, 34);
            this.CIN.Name = "CIN";
            this.CIN.Size = new System.Drawing.Size(368, 25);
            this.CIN.TabIndex = 1;
            // 
            // CINLabel
            // 
            this.CINLabel.AutoSize = true;
            this.CINLabel.Location = new System.Drawing.Point(16, 9);
            this.CINLabel.Name = "CINLabel";
            this.CINLabel.Size = new System.Drawing.Size(25, 13);
            this.CINLabel.TabIndex = 17;
            this.CINLabel.Text = "CIN";
            // 
            // CinTXT
            // 
            this.CinTXT.Location = new System.Drawing.Point(124, 3);
            this.CinTXT.Name = "CinTXT";
            this.CinTXT.Size = new System.Drawing.Size(165, 20);
            this.CinTXT.TabIndex = 19;
            // 
            // Nom
            // 
            this.Nom.Controls.Add(this.NomLabel);
            this.Nom.Controls.Add(this.NomTXT);
            this.Nom.Enabled = false;
            this.Nom.Location = new System.Drawing.Point(3, 65);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(368, 25);
            this.Nom.TabIndex = 2;
            // 
            // NomLabel
            // 
            this.NomLabel.AutoSize = true;
            this.NomLabel.Location = new System.Drawing.Point(16, 5);
            this.NomLabel.Name = "NomLabel";
            this.NomLabel.Size = new System.Drawing.Size(29, 13);
            this.NomLabel.TabIndex = 12;
            this.NomLabel.Text = "Nom";
            // 
            // NomTXT
            // 
            this.NomTXT.Location = new System.Drawing.Point(124, 2);
            this.NomTXT.Name = "NomTXT";
            this.NomTXT.Size = new System.Drawing.Size(165, 20);
            this.NomTXT.TabIndex = 20;
            // 
            // Prenom
            // 
            this.Prenom.Controls.Add(this.PrenomLabel);
            this.Prenom.Controls.Add(this.PrenomTXT);
            this.Prenom.Enabled = false;
            this.Prenom.Location = new System.Drawing.Point(3, 96);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(368, 25);
            this.Prenom.TabIndex = 3;
            // 
            // PrenomLabel
            // 
            this.PrenomLabel.AutoSize = true;
            this.PrenomLabel.Location = new System.Drawing.Point(16, 7);
            this.PrenomLabel.Name = "PrenomLabel";
            this.PrenomLabel.Size = new System.Drawing.Size(43, 13);
            this.PrenomLabel.TabIndex = 13;
            this.PrenomLabel.Text = "Prenom";
            // 
            // PrenomTXT
            // 
            this.PrenomTXT.Location = new System.Drawing.Point(124, 2);
            this.PrenomTXT.Name = "PrenomTXT";
            this.PrenomTXT.Size = new System.Drawing.Size(165, 20);
            this.PrenomTXT.TabIndex = 21;
            // 
            // Filier
            // 
            this.Filier.Controls.Add(this.FilierTXT);
            this.Filier.Controls.Add(this.FilierLabel);
            this.Filier.Enabled = false;
            this.Filier.Location = new System.Drawing.Point(3, 127);
            this.Filier.Name = "Filier";
            this.Filier.Size = new System.Drawing.Size(368, 25);
            this.Filier.TabIndex = 4;
            // 
            // FilierTXT
            // 
            this.FilierTXT.DataSource = this.filierBindingSource;
            this.FilierTXT.DisplayMember = "Dèsignation";
            this.FilierTXT.FormattingEnabled = true;
            this.FilierTXT.Location = new System.Drawing.Point(125, 2);
            this.FilierTXT.Name = "FilierTXT";
            this.FilierTXT.Size = new System.Drawing.Size(164, 21);
            this.FilierTXT.TabIndex = 29;
            this.FilierTXT.ValueMember = "CodeFilier";
            // 
            // FilierLabel
            // 
            this.FilierLabel.AutoSize = true;
            this.FilierLabel.Location = new System.Drawing.Point(16, 5);
            this.FilierLabel.Name = "FilierLabel";
            this.FilierLabel.Size = new System.Drawing.Size(28, 13);
            this.FilierLabel.TabIndex = 14;
            this.FilierLabel.Text = "Filier";
            // 
            // Email
            // 
            this.Email.Controls.Add(this.EmailLabel);
            this.Email.Controls.Add(this.EmailTXT);
            this.Email.Enabled = false;
            this.Email.Location = new System.Drawing.Point(3, 158);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(368, 25);
            this.Email.TabIndex = 5;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(16, 6);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 15;
            this.EmailLabel.Text = "Email";
            // 
            // EmailTXT
            // 
            this.EmailTXT.Location = new System.Drawing.Point(124, 3);
            this.EmailTXT.Name = "EmailTXT";
            this.EmailTXT.Size = new System.Drawing.Size(165, 20);
            this.EmailTXT.TabIndex = 22;
            // 
            // Tele
            // 
            this.Tele.Controls.Add(this.label11);
            this.Tele.Controls.Add(this.textBox8);
            this.Tele.Enabled = false;
            this.Tele.Location = new System.Drawing.Point(3, 189);
            this.Tele.Name = "Tele";
            this.Tele.Size = new System.Drawing.Size(368, 25);
            this.Tele.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Tele";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(124, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(165, 20);
            this.textBox8.TabIndex = 23;
            // 
            // Type
            // 
            this.Type.Controls.Add(this.TypeComboBOX2);
            this.Type.Controls.Add(this.label20);
            this.Type.Enabled = false;
            this.Type.Location = new System.Drawing.Point(3, 220);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(368, 25);
            this.Type.TabIndex = 6;
            // 
            // TypeComboBOX2
            // 
            this.TypeComboBOX2.DataSource = this.typeEmprunteurBindingSource;
            this.TypeComboBOX2.DisplayMember = "Dèsignation";
            this.TypeComboBOX2.FormattingEnabled = true;
            this.TypeComboBOX2.Location = new System.Drawing.Point(124, 1);
            this.TypeComboBOX2.Name = "TypeComboBOX2";
            this.TypeComboBOX2.Size = new System.Drawing.Size(164, 21);
            this.TypeComboBOX2.TabIndex = 17;
            this.TypeComboBOX2.ValueMember = "IdTypeEmp";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 13);
            this.label20.TabIndex = 16;
            this.label20.Text = "Type";
            // 
            // Sexe
            // 
            this.Sexe.Controls.Add(this.SexeM);
            this.Sexe.Controls.Add(this.SexeF);
            this.Sexe.Controls.Add(this.label21);
            this.Sexe.Enabled = false;
            this.Sexe.Location = new System.Drawing.Point(3, 251);
            this.Sexe.Name = "Sexe";
            this.Sexe.Size = new System.Drawing.Size(368, 25);
            this.Sexe.TabIndex = 6;
            // 
            // SexeM
            // 
            this.SexeM.AutoSize = true;
            this.SexeM.Checked = true;
            this.SexeM.Location = new System.Drawing.Point(162, 2);
            this.SexeM.Name = "SexeM";
            this.SexeM.Size = new System.Drawing.Size(34, 17);
            this.SexeM.TabIndex = 18;
            this.SexeM.TabStop = true;
            this.SexeM.Text = "M";
            this.SexeM.UseVisualStyleBackColor = true;
            // 
            // SexeF
            // 
            this.SexeF.AutoSize = true;
            this.SexeF.Location = new System.Drawing.Point(125, 2);
            this.SexeF.Name = "SexeF";
            this.SexeF.Size = new System.Drawing.Size(31, 17);
            this.SexeF.TabIndex = 17;
            this.SexeF.Text = "F";
            this.SexeF.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(16, 4);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 13);
            this.label21.TabIndex = 16;
            this.label21.Text = "Sexe";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(435, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "Informer";
            this.toolTip1.SetToolTip(this.button2, "Créer un PDF pour informer cet emprunteur par sa situation actuel.");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            this.toolTip1.OwnerDraw = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            // 
            // Historique
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(1089, 435);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NbPretsLbl);
            this.Controls.Add(this.NbSanctionLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Historique";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Historique_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothèqueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeEmprunteurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filierBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.Identifiant.ResumeLayout(false);
            this.Identifiant.PerformLayout();
            this.CIN.ResumeLayout(false);
            this.CIN.PerformLayout();
            this.Nom.ResumeLayout(false);
            this.Nom.PerformLayout();
            this.Prenom.ResumeLayout(false);
            this.Prenom.PerformLayout();
            this.Filier.ResumeLayout(false);
            this.Filier.PerformLayout();
            this.Email.ResumeLayout(false);
            this.Email.PerformLayout();
            this.Tele.ResumeLayout(false);
            this.Tele.PerformLayout();
            this.Type.ResumeLayout(false);
            this.Type.PerformLayout();
            this.Sexe.ResumeLayout(false);
            this.Sexe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    #region Header
                    string documentName = folderBrowser.SelectedPath + "\\Fiche de Prét de " + NomTXT.Text + " " + PrenomTXT.Text + " Le " + DateTime.Now.ToString("dd-MM-yyyy") + ".pdf";
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

                    Paragraph Nom = new Paragraph("\n Nom et Prénom  :  " + NomTXT.Text + " " + PrenomTXT.Text + ".\n\n");
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
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        if ((bool)r.Cells[7].FormattedValue == false)
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
                        table.SetTotalWidth(new float[] { w - 40, w-40, w+40, w+40 });
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
