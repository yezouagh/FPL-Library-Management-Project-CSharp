namespace Gestion_de_bilbliotheque_app
{
    partial class LesDocuments
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.FermerBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.Filier = new System.Windows.Forms.Panel();
            this.DomaintTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SousDomaineTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AuteurTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.CoteTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TitreTXT = new System.Windows.Forms.TextBox();
            this.TitreLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.QuantiteLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Filier.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1127, 364);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 33);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(470, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulter les documents";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // FermerBTN
            // 
            this.FermerBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FermerBTN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.FermerBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.FermerBTN.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.FermerBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.FermerBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.FermerBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FermerBTN.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FermerBTN.ForeColor = System.Drawing.Color.White;
            this.FermerBTN.Location = new System.Drawing.Point(1073, 519);
            this.FermerBTN.Name = "FermerBTN";
            this.FermerBTN.Size = new System.Drawing.Size(75, 23);
            this.FermerBTN.TabIndex = 5;
            this.FermerBTN.Text = "Fermer";
            this.toolTip1.SetToolTip(this.FermerBTN, "Fermer cette interface.");
            this.FermerBTN.UseVisualStyleBackColor = false;
            this.FermerBTN.Click += new System.EventHandler(this.FermerBTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("MingLiU-ExtB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1120, 109);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrer";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.Filier);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1103, 76);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TypeComboBox);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 32);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU-ExtB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.Font = new System.Drawing.Font("MingLiU-ExtB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(65, 6);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(176, 20);
            this.TypeComboBox.TabIndex = 2;
            this.TypeComboBox.TextChanged += new System.EventHandler(this.TypeComboBox_TextChanged);
            // 
            // Filier
            // 
            this.Filier.Controls.Add(this.DomaintTXT);
            this.Filier.Controls.Add(this.label5);
            this.Filier.Location = new System.Drawing.Point(285, 3);
            this.Filier.Name = "Filier";
            this.Filier.Size = new System.Drawing.Size(276, 32);
            this.Filier.TabIndex = 7;
            // 
            // DomaintTXT
            // 
            this.DomaintTXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.DomaintTXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.DomaintTXT.Font = new System.Drawing.Font("MingLiU-ExtB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DomaintTXT.Location = new System.Drawing.Point(73, 4);
            this.DomaintTXT.Name = "DomaintTXT";
            this.DomaintTXT.Size = new System.Drawing.Size(180, 23);
            this.DomaintTXT.TabIndex = 2;
            this.DomaintTXT.TextChanged += new System.EventHandler(this.DomaintTXT_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MingLiU-ExtB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "Domaine";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SousDomaineTXT);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(567, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(276, 32);
            this.panel3.TabIndex = 4;
            // 
            // SousDomaineTXT
            // 
            this.SousDomaineTXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SousDomaineTXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SousDomaineTXT.Font = new System.Drawing.Font("MingLiU-ExtB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SousDomaineTXT.Location = new System.Drawing.Point(112, 5);
            this.SousDomaineTXT.Name = "SousDomaineTXT";
            this.SousDomaineTXT.Size = new System.Drawing.Size(140, 22);
            this.SousDomaineTXT.TabIndex = 0;
            this.SousDomaineTXT.TextChanged += new System.EventHandler(this.IdentifiantTXT_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU-ExtB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sous domaine";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.AuteurTXT);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(849, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(251, 32);
            this.panel4.TabIndex = 5;
            // 
            // AuteurTXT
            // 
            this.AuteurTXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.AuteurTXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.AuteurTXT.Font = new System.Drawing.Font("MingLiU-ExtB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuteurTXT.Location = new System.Drawing.Point(65, 3);
            this.AuteurTXT.Name = "AuteurTXT";
            this.AuteurTXT.Size = new System.Drawing.Size(176, 22);
            this.AuteurTXT.TabIndex = 0;
            this.AuteurTXT.TextChanged += new System.EventHandler(this.NomTXT_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MingLiU-ExtB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "Auteur";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.CoteTXT);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(3, 41);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(276, 32);
            this.panel6.TabIndex = 6;
            // 
            // CoteTXT
            // 
            this.CoteTXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CoteTXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CoteTXT.Font = new System.Drawing.Font("MingLiU-ExtB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoteTXT.Location = new System.Drawing.Point(65, 4);
            this.CoteTXT.Name = "CoteTXT";
            this.CoteTXT.Size = new System.Drawing.Size(176, 22);
            this.CoteTXT.TabIndex = 0;
            this.CoteTXT.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MingLiU-ExtB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 14);
            this.label6.TabIndex = 1;
            this.label6.Text = "Côte";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.TitreTXT);
            this.panel5.Controls.Add(this.TitreLbl);
            this.panel5.Location = new System.Drawing.Point(285, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(276, 32);
            this.panel5.TabIndex = 6;
            // 
            // TitreTXT
            // 
            this.TitreTXT.Font = new System.Drawing.Font("MingLiU-ExtB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreTXT.Location = new System.Drawing.Point(73, 7);
            this.TitreTXT.Name = "TitreTXT";
            this.TitreTXT.Size = new System.Drawing.Size(180, 22);
            this.TitreTXT.TabIndex = 0;
            this.TitreTXT.TextChanged += new System.EventHandler(this.Titre_TextChanged);
            // 
            // TitreLbl
            // 
            this.TitreLbl.AutoSize = true;
            this.TitreLbl.Font = new System.Drawing.Font("MingLiU-ExtB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreLbl.Location = new System.Drawing.Point(3, 10);
            this.TitreLbl.Name = "TitreLbl";
            this.TitreLbl.Size = new System.Drawing.Size(42, 14);
            this.TitreLbl.TabIndex = 1;
            this.TitreLbl.Text = "Titre";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(398, 524);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(314, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Double clique sur la ligne que vous voulez modifier ou supprimer !";
            // 
            // QuantiteLbl
            // 
            this.QuantiteLbl.AutoSize = true;
            this.QuantiteLbl.BackColor = System.Drawing.Color.GhostWhite;
            this.QuantiteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantiteLbl.ForeColor = System.Drawing.Color.Red;
            this.QuantiteLbl.Location = new System.Drawing.Point(885, 519);
            this.QuantiteLbl.Name = "QuantiteLbl";
            this.QuantiteLbl.Size = new System.Drawing.Size(91, 20);
            this.QuantiteLbl.TabIndex = 8;
            this.QuantiteLbl.Text = "Quantite : 0";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.BackColor = System.Drawing.Color.GhostWhite;
            this.totalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.ForeColor = System.Drawing.Color.Red;
            this.totalLbl.Location = new System.Drawing.Point(19, 519);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(65, 20);
            this.totalLbl.TabIndex = 9;
            this.totalLbl.Text = "Total : 0";
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            this.toolTip1.OwnerDraw = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            // 
            // LesDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.FermerBTN;
            this.ClientSize = new System.Drawing.Size(1168, 546);
            this.ControlBox = false;
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.QuantiteLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FermerBTN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "LesDocuments";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LesEmprunteurs_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Filier.ResumeLayout(false);
            this.Filier.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FermerBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label TitreLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TitreTXT;
        private System.Windows.Forms.TextBox AuteurTXT;
        private System.Windows.Forms.TextBox SousDomaineTXT;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel Filier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox CoteTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DomaintTXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label QuantiteLbl;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}