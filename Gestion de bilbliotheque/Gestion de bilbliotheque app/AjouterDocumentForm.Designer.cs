namespace Gestion_de_bilbliotheque_app
{
    partial class AjouterDocumentForm
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
            this.ajouterDocument1 = new Gestion_de_bilbliotheque_app.AjouterDocument();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AnnulerBTN = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ajouterDocument1
            // 
            this.ajouterDocument1.BackColor = System.Drawing.Color.White;
            this.ajouterDocument1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ajouterDocument1.Location = new System.Drawing.Point(24, 74);
            this.ajouterDocument1.Name = "ajouterDocument1";
            this.ajouterDocument1.Size = new System.Drawing.Size(453, 461);
            this.ajouterDocument1.TabIndex = 0;
            this.ajouterDocument1.Load += new System.EventHandler(this.ajouterDocument1_Load);
            this.ajouterDocument1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.ajouterDocument1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 33);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(149, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ajouter un Document ";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // AnnulerBTN
            // 
            this.AnnulerBTN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AnnulerBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AnnulerBTN.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.AnnulerBTN.FlatAppearance.BorderSize = 2;
            this.AnnulerBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AnnulerBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.AnnulerBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnnulerBTN.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnulerBTN.ForeColor = System.Drawing.Color.White;
            this.AnnulerBTN.Location = new System.Drawing.Point(267, 491);
            this.AnnulerBTN.Name = "AnnulerBTN";
            this.AnnulerBTN.Size = new System.Drawing.Size(87, 31);
            this.AnnulerBTN.TabIndex = 6;
            this.AnnulerBTN.Text = "Annuler";
            this.toolTip1.SetToolTip(this.AnnulerBTN, "Annuler cette opération.");
            this.AnnulerBTN.UseVisualStyleBackColor = false;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            this.toolTip1.OwnerDraw = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            // 
            // AjouterDocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.AnnulerBTN;
            this.ClientSize = new System.Drawing.Size(503, 547);
            this.ControlBox = false;
            this.Controls.Add(this.AnnulerBTN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ajouterDocument1);
            this.DoubleBuffered = true;
            this.Name = "AjouterDocumentForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Gestion_de_bilbliotheque_app.AjouterDocument ajouterDocument1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AnnulerBTN;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}