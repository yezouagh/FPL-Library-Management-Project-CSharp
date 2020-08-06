namespace Gestion_de_bilbliotheque_app
{
    partial class Alimenter_la_base_de_deonnees
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
            this.MainContentPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.ajouterEmp1 = new Gestion_de_bilbliotheque_app.AjouterEmp();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ajouterDocument1 = new Gestion_de_bilbliotheque_app.AjouterDocument();
            this.ImporterDocuments = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MainContentPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainContentPanel
            // 
            this.MainContentPanel.Controls.Add(this.groupBox2);
            this.MainContentPanel.Controls.Add(this.groupBox1);
            this.MainContentPanel.Location = new System.Drawing.Point(3, 3);
            this.MainContentPanel.Name = "MainContentPanel";
            this.MainContentPanel.Size = new System.Drawing.Size(990, 576);
            this.MainContentPanel.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.ajouterEmp1);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Location = new System.Drawing.Point(493, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 541);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Emprunteurs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(157, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Etudiants(es) seulement ";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkLabel2.Location = new System.Drawing.Point(333, 53);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(129, 13);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Consulter les Emprunteurs";
            this.toolTip1.SetToolTip(this.linkLabel2, "Afficher tous les emprunteurs stocké dans la base de données.");
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // ajouterEmp1
            // 
            this.ajouterEmp1.BackColor = System.Drawing.Color.White;
            this.ajouterEmp1.Location = new System.Drawing.Point(19, 76);
            this.ajouterEmp1.Name = "ajouterEmp1";
            this.ajouterEmp1.Size = new System.Drawing.Size(462, 459);
            this.ajouterEmp1.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(130, 29);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(197, 37);
            this.button6.TabIndex = 3;
            this.button6.Text = "Importer";
            this.toolTip1.SetToolTip(this.button6, "Importer les informations des etudiants(es)  à partir d\'excel.");
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.ajouterDocument1);
            this.groupBox1.Controls.Add(this.ImporterDocuments);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 540);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Docments";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkLabel1.Location = new System.Drawing.Point(322, 52);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(122, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Consulter les documents";
            this.toolTip1.SetToolTip(this.linkLabel1, "Afficher tous les documents stocké dans la base de données.");
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ajouterDocument1
            // 
            this.ajouterDocument1.BackColor = System.Drawing.Color.White;
            this.ajouterDocument1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ajouterDocument1.Location = new System.Drawing.Point(6, 75);
            this.ajouterDocument1.Name = "ajouterDocument1";
            this.ajouterDocument1.Size = new System.Drawing.Size(453, 459);
            this.ajouterDocument1.TabIndex = 2;
            // 
            // ImporterDocuments
            // 
            this.ImporterDocuments.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ImporterDocuments.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.ImporterDocuments.FlatAppearance.BorderSize = 2;
            this.ImporterDocuments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ImporterDocuments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.ImporterDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImporterDocuments.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImporterDocuments.ForeColor = System.Drawing.Color.White;
            this.ImporterDocuments.Location = new System.Drawing.Point(119, 28);
            this.ImporterDocuments.Name = "ImporterDocuments";
            this.ImporterDocuments.Size = new System.Drawing.Size(197, 37);
            this.ImporterDocuments.TabIndex = 1;
            this.ImporterDocuments.Text = "Importer";
            this.toolTip1.SetToolTip(this.ImporterDocuments, "Importer les informations des documents  à partir d\'excel.");
            this.ImporterDocuments.UseVisualStyleBackColor = false;
            this.ImporterDocuments.Click += new System.EventHandler(this.ImporterDocuments_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            this.openFileDialog1.InitialDirectory = "C:\\";
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            this.toolTip1.OwnerDraw = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            // 
            // Alimenter_la_base_de_deonnees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MainContentPanel);
            this.Name = "Alimenter_la_base_de_deonnees";
            this.Size = new System.Drawing.Size(998, 582);
            this.Resize += new System.EventHandler(this.Alimenter_la_base_de_deonnees_Resize);
            this.MainContentPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainContentPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ImporterDocuments;
        private System.Windows.Forms.Button button6;
        private AjouterEmp ajouterEmp1;
        private AjouterDocument ajouterDocument1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
