namespace Gestion_de_bilbliotheque_app
{
    partial class Asanctionnee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.FermerBTN = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.bibliothèqueDataSet = new Gestion_de_bilbliotheque_app.BibliothèqueDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.sanctionneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanctionneTableAdapter = new Gestion_de_bilbliotheque_app.BibliothèqueDataSetTableAdapters.SanctionneTableAdapter();
            this.tableAdapterManager = new Gestion_de_bilbliotheque_app.BibliothèqueDataSetTableAdapters.TableAdapterManager();
            this.sanctionneDataGridView = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Confirmer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothèqueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanctionneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanctionneDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 33);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(408, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Les emprunteurs qui seront sanctionné";
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
            this.FermerBTN.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FermerBTN.ForeColor = System.Drawing.Color.White;
            this.FermerBTN.Location = new System.Drawing.Point(1062, 418);
            this.FermerBTN.Name = "FermerBTN";
            this.FermerBTN.Size = new System.Drawing.Size(80, 30);
            this.FermerBTN.TabIndex = 5;
            this.FermerBTN.Text = "Fermer";
            this.toolTip1.SetToolTip(this.FermerBTN, "Fermer cette  interface.");
            this.FermerBTN.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(9, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(390, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cocher la case qui  concerne le  sanctione, pour confirmer l\'opération !";
            // 
            // bibliothèqueDataSet
            // 
            this.bibliothèqueDataSet.DataSetName = "BibliothèqueDataSet";
            this.bibliothèqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(913, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Confirmer";
            this.toolTip1.SetToolTip(this.button1, "confirmer la sanction de les emprunteurs sélectionné.");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sanctionneBindingSource
            // 
            this.sanctionneBindingSource.DataMember = "Sanctionne";
            this.sanctionneBindingSource.DataSource = this.bibliothèqueDataSet;
            // 
            // sanctionneTableAdapter
            // 
            this.sanctionneTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.EmprunterTableAdapter = null;
            this.tableAdapterManager.Emprunteur_SanctionneTableAdapter = null;
            this.tableAdapterManager.EmprunteurTableAdapter = null;
            this.tableAdapterManager.FilierTableAdapter = null;
            this.tableAdapterManager.OuvrageTableAdapter = null;
            this.tableAdapterManager.TypeEmprunteurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Gestion_de_bilbliotheque_app.BibliothèqueDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sanctionneDataGridView
            // 
            this.sanctionneDataGridView.AllowUserToAddRows = false;
            this.sanctionneDataGridView.AllowUserToDeleteRows = false;
            this.sanctionneDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sanctionneDataGridView.AutoGenerateColumns = false;
            this.sanctionneDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.sanctionneDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sanctionneDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.Confirmer});
            this.sanctionneDataGridView.DataSource = this.sanctionneBindingSource;
            this.sanctionneDataGridView.Location = new System.Drawing.Point(10, 80);
            this.sanctionneDataGridView.Name = "sanctionneDataGridView";
            this.sanctionneDataGridView.Size = new System.Drawing.Size(1135, 323);
            this.sanctionneDataGridView.TabIndex = 9;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            this.toolTip1.OwnerDraw = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodePret";
            this.dataGridViewTextBoxColumn1.HeaderText = "Code Pret";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cote";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cote";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_Emprunteur";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID Emprunteur";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Prenom";
            this.dataGridViewTextBoxColumn5.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DateEmprunt";
            this.dataGridViewTextBoxColumn6.HeaderText = "Date Emprunt";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Date_Retour_prevoyer";
            this.dataGridViewTextBoxColumn7.HeaderText = "Date retour prevoyer";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Nombre de sanctions";
            this.dataGridViewTextBoxColumn8.HeaderText = "Nombre de sanctions";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // Confirmer
            // 
            this.Confirmer.HeaderText = "Confirmer";
            this.Confirmer.Name = "Confirmer";
            // 
            // Asanctionnee
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.FermerBTN;
            this.ClientSize = new System.Drawing.Size(1148, 452);
            this.ControlBox = false;
            this.Controls.Add(this.sanctionneDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FermerBTN);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Asanctionnee";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LesEmprunteurs_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothèqueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanctionneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanctionneDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FermerBTN;
        private System.Windows.Forms.Label label7;
        private BibliothèqueDataSet bibliothèqueDataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource sanctionneBindingSource;
        private BibliothèqueDataSetTableAdapters.SanctionneTableAdapter sanctionneTableAdapter;
        private BibliothèqueDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView sanctionneDataGridView;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Confirmer;
    }
}