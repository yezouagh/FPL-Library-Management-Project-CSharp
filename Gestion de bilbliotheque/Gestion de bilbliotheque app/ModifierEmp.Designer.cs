namespace Gestion_de_bilbliotheque_app
{
    partial class ModifierEmp
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SupprimerBTN = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Type = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.IdentifiantPanel = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.IdentifiantTXT = new System.Windows.Forms.TextBox();
            this.Identifiant = new System.Windows.Forms.Label();
            this.CIN = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CinTXT = new System.Windows.Forms.TextBox();
            this.Cinlbl = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.NomTXT = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Prenom = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.PrenomTXT = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Filier = new System.Windows.Forms.Panel();
            this.NouveauFilierBTN = new System.Windows.Forms.Button();
            this.FilierComboBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.DateNaissance = new System.Windows.Forms.Panel();
            this.DateNaissanceTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.LieuNaissance = new System.Windows.Forms.Panel();
            this.LieuNaissanceTXT = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Sexe = new System.Windows.Forms.Panel();
            this.SexeM = new System.Windows.Forms.RadioButton();
            this.SexeF = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Panel();
            this.EmailTXT = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.Tele = new System.Windows.Forms.Panel();
            this.TeleTXT = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.AjouterEmpBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.Type.SuspendLayout();
            this.IdentifiantPanel.SuspendLayout();
            this.CIN.SuspendLayout();
            this.Nom.SuspendLayout();
            this.Prenom.SuspendLayout();
            this.Filier.SuspendLayout();
            this.DateNaissance.SuspendLayout();
            this.LieuNaissance.SuspendLayout();
            this.Sexe.SuspendLayout();
            this.Email.SuspendLayout();
            this.Tele.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SupprimerBTN);
            this.groupBox4.Controls.Add(this.flowLayoutPanel1);
            this.groupBox4.Controls.Add(this.AjouterEmpBTN);
            this.groupBox4.Location = new System.Drawing.Point(12, 63);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(453, 454);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Emprunteur info";
            // 
            // SupprimerBTN
            // 
            this.SupprimerBTN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SupprimerBTN.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.SupprimerBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SupprimerBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.SupprimerBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupprimerBTN.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupprimerBTN.ForeColor = System.Drawing.Color.White;
            this.SupprimerBTN.Location = new System.Drawing.Point(238, 425);
            this.SupprimerBTN.Name = "SupprimerBTN";
            this.SupprimerBTN.Size = new System.Drawing.Size(96, 25);
            this.SupprimerBTN.TabIndex = 17;
            this.SupprimerBTN.Text = "Supprimer";
            this.toolTip1.SetToolTip(this.SupprimerBTN, "Supprimer cet emprunteur complètement.");
            this.SupprimerBTN.UseVisualStyleBackColor = false;
            this.SupprimerBTN.Click += new System.EventHandler(this.SupprimerBTN_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Type);
            this.flowLayoutPanel1.Controls.Add(this.IdentifiantPanel);
            this.flowLayoutPanel1.Controls.Add(this.CIN);
            this.flowLayoutPanel1.Controls.Add(this.Nom);
            this.flowLayoutPanel1.Controls.Add(this.Prenom);
            this.flowLayoutPanel1.Controls.Add(this.Filier);
            this.flowLayoutPanel1.Controls.Add(this.DateNaissance);
            this.flowLayoutPanel1.Controls.Add(this.LieuNaissance);
            this.flowLayoutPanel1.Controls.Add(this.Sexe);
            this.flowLayoutPanel1.Controls.Add(this.Email);
            this.flowLayoutPanel1.Controls.Add(this.Tele);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(432, 397);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // Type
            // 
            this.Type.Controls.Add(this.label1);
            this.Type.Controls.Add(this.TypeComboBox);
            this.Type.Controls.Add(this.label18);
            this.Type.Enabled = false;
            this.Type.Location = new System.Drawing.Point(3, 3);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(429, 29);
            this.Type.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(309, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "*";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(105, 2);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(198, 21);
            this.TypeComboBox.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Type";
            // 
            // IdentifiantPanel
            // 
            this.IdentifiantPanel.Controls.Add(this.checkBox1);
            this.IdentifiantPanel.Controls.Add(this.label14);
            this.IdentifiantPanel.Controls.Add(this.IdentifiantTXT);
            this.IdentifiantPanel.Controls.Add(this.Identifiant);
            this.IdentifiantPanel.Enabled = false;
            this.IdentifiantPanel.Location = new System.Drawing.Point(3, 38);
            this.IdentifiantPanel.Name = "IdentifiantPanel";
            this.IdentifiantPanel.Size = new System.Drawing.Size(429, 29);
            this.IdentifiantPanel.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(330, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Modifier";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(309, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "*";
            // 
            // IdentifiantTXT
            // 
            this.IdentifiantTXT.Enabled = false;
            this.IdentifiantTXT.Location = new System.Drawing.Point(105, 2);
            this.IdentifiantTXT.Name = "IdentifiantTXT";
            this.IdentifiantTXT.Size = new System.Drawing.Size(198, 20);
            this.IdentifiantTXT.TabIndex = 3;
            // 
            // Identifiant
            // 
            this.Identifiant.AutoSize = true;
            this.Identifiant.Location = new System.Drawing.Point(3, 5);
            this.Identifiant.Name = "Identifiant";
            this.Identifiant.Size = new System.Drawing.Size(77, 13);
            this.Identifiant.TabIndex = 2;
            this.Identifiant.Text = "N° d\'inscription";
            // 
            // CIN
            // 
            this.CIN.Controls.Add(this.label2);
            this.CIN.Controls.Add(this.CinTXT);
            this.CIN.Controls.Add(this.Cinlbl);
            this.CIN.Enabled = false;
            this.CIN.Location = new System.Drawing.Point(3, 73);
            this.CIN.Name = "CIN";
            this.CIN.Size = new System.Drawing.Size(429, 29);
            this.CIN.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(309, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "*";
            // 
            // CinTXT
            // 
            this.CinTXT.Location = new System.Drawing.Point(105, 2);
            this.CinTXT.Name = "CinTXT";
            this.CinTXT.Size = new System.Drawing.Size(197, 20);
            this.CinTXT.TabIndex = 4;
            // 
            // Cinlbl
            // 
            this.Cinlbl.AutoSize = true;
            this.Cinlbl.Location = new System.Drawing.Point(3, 5);
            this.Cinlbl.Name = "Cinlbl";
            this.Cinlbl.Size = new System.Drawing.Size(25, 13);
            this.Cinlbl.TabIndex = 2;
            this.Cinlbl.Text = "CIN";
            // 
            // Nom
            // 
            this.Nom.Controls.Add(this.label23);
            this.Nom.Controls.Add(this.NomTXT);
            this.Nom.Controls.Add(this.label13);
            this.Nom.Enabled = false;
            this.Nom.Location = new System.Drawing.Point(3, 108);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(429, 29);
            this.Nom.TabIndex = 0;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(309, 2);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(15, 20);
            this.label23.TabIndex = 27;
            this.label23.Text = "*";
            // 
            // NomTXT
            // 
            this.NomTXT.Location = new System.Drawing.Point(105, 2);
            this.NomTXT.Name = "NomTXT";
            this.NomTXT.Size = new System.Drawing.Size(198, 20);
            this.NomTXT.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.Controls.Add(this.label24);
            this.Prenom.Controls.Add(this.PrenomTXT);
            this.Prenom.Controls.Add(this.label15);
            this.Prenom.Enabled = false;
            this.Prenom.Location = new System.Drawing.Point(3, 143);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(429, 29);
            this.Prenom.TabIndex = 0;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(309, 5);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(15, 20);
            this.label24.TabIndex = 27;
            this.label24.Text = "*";
            // 
            // PrenomTXT
            // 
            this.PrenomTXT.Location = new System.Drawing.Point(105, 2);
            this.PrenomTXT.Name = "PrenomTXT";
            this.PrenomTXT.Size = new System.Drawing.Size(197, 20);
            this.PrenomTXT.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Prénom";
            // 
            // Filier
            // 
            this.Filier.Controls.Add(this.NouveauFilierBTN);
            this.Filier.Controls.Add(this.FilierComboBox);
            this.Filier.Controls.Add(this.label16);
            this.Filier.Enabled = false;
            this.Filier.Location = new System.Drawing.Point(3, 178);
            this.Filier.Name = "Filier";
            this.Filier.Size = new System.Drawing.Size(429, 29);
            this.Filier.TabIndex = 0;
            // 
            // NouveauFilierBTN
            // 
            this.NouveauFilierBTN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.NouveauFilierBTN.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.NouveauFilierBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.NouveauFilierBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.NouveauFilierBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NouveauFilierBTN.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NouveauFilierBTN.ForeColor = System.Drawing.Color.White;
            this.NouveauFilierBTN.Location = new System.Drawing.Point(322, 1);
            this.NouveauFilierBTN.Name = "NouveauFilierBTN";
            this.NouveauFilierBTN.Size = new System.Drawing.Size(104, 25);
            this.NouveauFilierBTN.TabIndex = 9;
            this.NouveauFilierBTN.Text = "Nouveau";
            this.NouveauFilierBTN.UseVisualStyleBackColor = false;
            this.NouveauFilierBTN.Click += new System.EventHandler(this.NouveauFilierBTN_Click);
            // 
            // FilierComboBox
            // 
            this.FilierComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilierComboBox.FormattingEnabled = true;
            this.FilierComboBox.Location = new System.Drawing.Point(105, 2);
            this.FilierComboBox.Name = "FilierComboBox";
            this.FilierComboBox.Size = new System.Drawing.Size(198, 21);
            this.FilierComboBox.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Filière";
            // 
            // DateNaissance
            // 
            this.DateNaissance.Controls.Add(this.DateNaissanceTimePicker);
            this.DateNaissance.Controls.Add(this.label17);
            this.DateNaissance.Enabled = false;
            this.DateNaissance.Location = new System.Drawing.Point(3, 213);
            this.DateNaissance.Name = "DateNaissance";
            this.DateNaissance.Size = new System.Drawing.Size(429, 29);
            this.DateNaissance.TabIndex = 0;
            // 
            // DateNaissanceTimePicker
            // 
            this.DateNaissanceTimePicker.Location = new System.Drawing.Point(105, 3);
            this.DateNaissanceTimePicker.Name = "DateNaissanceTimePicker";
            this.DateNaissanceTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateNaissanceTimePicker.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 5);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Date de naissance";
            // 
            // LieuNaissance
            // 
            this.LieuNaissance.Controls.Add(this.LieuNaissanceTXT);
            this.LieuNaissance.Controls.Add(this.label19);
            this.LieuNaissance.Enabled = false;
            this.LieuNaissance.Location = new System.Drawing.Point(3, 248);
            this.LieuNaissance.Name = "LieuNaissance";
            this.LieuNaissance.Size = new System.Drawing.Size(429, 29);
            this.LieuNaissance.TabIndex = 0;
            // 
            // LieuNaissanceTXT
            // 
            this.LieuNaissanceTXT.Location = new System.Drawing.Point(105, 4);
            this.LieuNaissanceTXT.Name = "LieuNaissanceTXT";
            this.LieuNaissanceTXT.Size = new System.Drawing.Size(197, 20);
            this.LieuNaissanceTXT.TabIndex = 11;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 5);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Lieu de naissance";
            // 
            // Sexe
            // 
            this.Sexe.Controls.Add(this.SexeM);
            this.Sexe.Controls.Add(this.SexeF);
            this.Sexe.Controls.Add(this.label20);
            this.Sexe.Enabled = false;
            this.Sexe.Location = new System.Drawing.Point(3, 283);
            this.Sexe.Name = "Sexe";
            this.Sexe.Size = new System.Drawing.Size(429, 29);
            this.Sexe.TabIndex = 0;
            // 
            // SexeM
            // 
            this.SexeM.AutoSize = true;
            this.SexeM.Checked = true;
            this.SexeM.Location = new System.Drawing.Point(142, 5);
            this.SexeM.Name = "SexeM";
            this.SexeM.Size = new System.Drawing.Size(34, 17);
            this.SexeM.TabIndex = 13;
            this.SexeM.TabStop = true;
            this.SexeM.Text = "M";
            this.SexeM.UseVisualStyleBackColor = true;
            // 
            // SexeF
            // 
            this.SexeF.AutoSize = true;
            this.SexeF.Location = new System.Drawing.Point(105, 3);
            this.SexeF.Name = "SexeF";
            this.SexeF.Size = new System.Drawing.Size(31, 17);
            this.SexeF.TabIndex = 12;
            this.SexeF.Text = "F";
            this.SexeF.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 5);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Sexe";
            // 
            // Email
            // 
            this.Email.Controls.Add(this.EmailTXT);
            this.Email.Controls.Add(this.label21);
            this.Email.Enabled = false;
            this.Email.Location = new System.Drawing.Point(3, 318);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(429, 29);
            this.Email.TabIndex = 0;
            // 
            // EmailTXT
            // 
            this.EmailTXT.Location = new System.Drawing.Point(105, 2);
            this.EmailTXT.Name = "EmailTXT";
            this.EmailTXT.Size = new System.Drawing.Size(198, 20);
            this.EmailTXT.TabIndex = 14;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 5);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "E-mail";
            // 
            // Tele
            // 
            this.Tele.Controls.Add(this.TeleTXT);
            this.Tele.Controls.Add(this.label22);
            this.Tele.Enabled = false;
            this.Tele.Location = new System.Drawing.Point(3, 353);
            this.Tele.Name = "Tele";
            this.Tele.Size = new System.Drawing.Size(429, 29);
            this.Tele.TabIndex = 0;
            // 
            // TeleTXT
            // 
            this.TeleTXT.Location = new System.Drawing.Point(105, 2);
            this.TeleTXT.Name = "TeleTXT";
            this.TeleTXT.Size = new System.Drawing.Size(198, 20);
            this.TeleTXT.TabIndex = 15;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 5);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(28, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "Tele";
            // 
            // AjouterEmpBTN
            // 
            this.AjouterEmpBTN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AjouterEmpBTN.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.AjouterEmpBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AjouterEmpBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.AjouterEmpBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AjouterEmpBTN.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterEmpBTN.ForeColor = System.Drawing.Color.White;
            this.AjouterEmpBTN.Location = new System.Drawing.Point(340, 425);
            this.AjouterEmpBTN.Name = "AjouterEmpBTN";
            this.AjouterEmpBTN.Size = new System.Drawing.Size(107, 25);
            this.AjouterEmpBTN.TabIndex = 16;
            this.AjouterEmpBTN.Text = "Modifier";
            this.toolTip1.SetToolTip(this.AjouterEmpBTN, "Modifier les information de cet emprunteur.");
            this.AjouterEmpBTN.UseVisualStyleBackColor = false;
            this.AjouterEmpBTN.Click += new System.EventHandler(this.AjouterEmpBTN_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 33);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(159, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Emprunteur info";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // CloseBTN
            // 
            this.CloseBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBTN.BackColor = System.Drawing.Color.Red;
            this.CloseBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBTN.FlatAppearance.BorderSize = 0;
            this.CloseBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.CloseBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBTN.Font = new System.Drawing.Font("Miriam", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBTN.ForeColor = System.Drawing.Color.White;
            this.CloseBTN.Location = new System.Drawing.Point(446, -1);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(39, 23);
            this.CloseBTN.TabIndex = 7;
            this.CloseBTN.Text = "X";
            this.CloseBTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseBTN.UseVisualStyleBackColor = false;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            this.toolTip1.OwnerDraw = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            // 
            // ModifierEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 519);
            this.ControlBox = false;
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.DoubleBuffered = true;
            this.Name = "ModifierEmp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AjouterEmp_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.groupBox4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.Type.ResumeLayout(false);
            this.Type.PerformLayout();
            this.IdentifiantPanel.ResumeLayout(false);
            this.IdentifiantPanel.PerformLayout();
            this.CIN.ResumeLayout(false);
            this.CIN.PerformLayout();
            this.Nom.ResumeLayout(false);
            this.Nom.PerformLayout();
            this.Prenom.ResumeLayout(false);
            this.Prenom.PerformLayout();
            this.Filier.ResumeLayout(false);
            this.Filier.PerformLayout();
            this.DateNaissance.ResumeLayout(false);
            this.DateNaissance.PerformLayout();
            this.LieuNaissance.ResumeLayout(false);
            this.LieuNaissance.PerformLayout();
            this.Sexe.ResumeLayout(false);
            this.Sexe.PerformLayout();
            this.Email.ResumeLayout(false);
            this.Email.PerformLayout();
            this.Tele.ResumeLayout(false);
            this.Tele.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel IdentifiantPanel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox IdentifiantTXT;
        private System.Windows.Forms.Label Identifiant;
        private System.Windows.Forms.Panel CIN;
        private System.Windows.Forms.TextBox CinTXT;
        private System.Windows.Forms.Label Cinlbl;
        private System.Windows.Forms.Panel Nom;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox NomTXT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel Prenom;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox PrenomTXT;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel Filier;
        private System.Windows.Forms.Button NouveauFilierBTN;
        private System.Windows.Forms.ComboBox FilierComboBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel DateNaissance;
        private System.Windows.Forms.DateTimePicker DateNaissanceTimePicker;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel LieuNaissance;
        private System.Windows.Forms.TextBox LieuNaissanceTXT;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel Sexe;
        private System.Windows.Forms.RadioButton SexeM;
        private System.Windows.Forms.RadioButton SexeF;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel Email;
        private System.Windows.Forms.TextBox EmailTXT;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel Tele;
        private System.Windows.Forms.TextBox TeleTXT;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button AjouterEmpBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button SupprimerBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CloseBTN;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
