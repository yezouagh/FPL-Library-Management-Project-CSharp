namespace Gestion_de_bilbliotheque_app
{
    partial class Filiere
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
            this.AjouterBTN = new System.Windows.Forms.Button();
            this.AnnulerBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CodeTXT = new System.Windows.Forms.TextBox();
            this.DesignationTXT = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 33);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ajouter Filière";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // AjouterBTN
            // 
            this.AjouterBTN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AjouterBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AjouterBTN.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.AjouterBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AjouterBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.AjouterBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AjouterBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterBTN.ForeColor = System.Drawing.Color.White;
            this.AjouterBTN.Location = new System.Drawing.Point(191, 192);
            this.AjouterBTN.Name = "AjouterBTN";
            this.AjouterBTN.Size = new System.Drawing.Size(114, 28);
            this.AjouterBTN.TabIndex = 4;
            this.AjouterBTN.Text = "Ajouter";
            this.toolTip1.SetToolTip(this.AjouterBTN, "Ajouter cette filiére.");
            this.AjouterBTN.UseVisualStyleBackColor = false;
            this.AjouterBTN.Click += new System.EventHandler(this.AjouterBTN_Click);
            // 
            // AnnulerBTN
            // 
            this.AnnulerBTN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AnnulerBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AnnulerBTN.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.AnnulerBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AnnulerBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.AnnulerBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnnulerBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnulerBTN.ForeColor = System.Drawing.Color.White;
            this.AnnulerBTN.Location = new System.Drawing.Point(322, 192);
            this.AnnulerBTN.Name = "AnnulerBTN";
            this.AnnulerBTN.Size = new System.Drawing.Size(78, 28);
            this.AnnulerBTN.TabIndex = 5;
            this.AnnulerBTN.Text = "Annuler";
            this.toolTip1.SetToolTip(this.AnnulerBTN, "Annuler cette opération");
            this.AnnulerBTN.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Code filiére";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dèsignation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(240, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Example: SMPC , SEG ...";
            // 
            // CodeTXT
            // 
            this.CodeTXT.Location = new System.Drawing.Point(86, 80);
            this.CodeTXT.Name = "CodeTXT";
            this.CodeTXT.Size = new System.Drawing.Size(100, 20);
            this.CodeTXT.TabIndex = 9;
            // 
            // DesignationTXT
            // 
            this.DesignationTXT.Location = new System.Drawing.Point(86, 126);
            this.DesignationTXT.Name = "DesignationTXT";
            this.DesignationTXT.Size = new System.Drawing.Size(189, 20);
            this.DesignationTXT.TabIndex = 10;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            this.toolTip1.OwnerDraw = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            // 
            // Filiere
            // 
            this.AcceptButton = this.AjouterBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.AnnulerBTN;
            this.ClientSize = new System.Drawing.Size(409, 227);
            this.ControlBox = false;
            this.Controls.Add(this.DesignationTXT);
            this.Controls.Add(this.CodeTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AnnulerBTN);
            this.Controls.Add(this.AjouterBTN);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Filiere";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AjouterBTN;
        private System.Windows.Forms.Button AnnulerBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CodeTXT;
        private System.Windows.Forms.TextBox DesignationTXT;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}