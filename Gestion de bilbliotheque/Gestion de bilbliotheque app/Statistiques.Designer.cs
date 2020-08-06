namespace Gestion_de_bilbliotheque_app
{
    partial class Statistiques
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Periode = new System.Windows.Forms.GroupBox();
            this.SessionSemestrecheckBox = new System.Windows.Forms.CheckBox();
            this.SgroupBox = new System.Windows.Forms.GroupBox();
            this.SemestreRadioButton = new System.Windows.Forms.RadioButton();
            this.SessionRadioButton = new System.Windows.Forms.RadioButton();
            this.SemestrePanel = new System.Windows.Forms.Panel();
            this.SemestreComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SessionPanel = new System.Windows.Forms.Panel();
            this.SessionComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AuDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DuDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.periodeCheckBox = new System.Windows.Forms.CheckBox();
            this.Main = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.ParDomaine = new System.Windows.Forms.Button();
            this.DocumentCheckBox = new System.Windows.Forms.CheckBox();
            this.EmpCheckBox = new System.Windows.Forms.CheckBox();
            this.DocPDF_btn = new System.Windows.Forms.Button();
            this.EmpPDF_btn = new System.Windows.Forms.Button();
            this.TotalEmpLBL = new System.Windows.Forms.Label();
            this.TotaldocLBL = new System.Windows.Forms.Label();
            this.dataGridViewDoc = new System.Windows.Forms.DataGridView();
            this.dataGridViewEmp = new System.Windows.Forms.DataGridView();
            this.Document = new System.Windows.Forms.GroupBox();
            this.DomaineComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TypeDocComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.emprunteur = new System.Windows.Forms.GroupBox();
            this.SexeComboBox = new System.Windows.Forms.ComboBox();
            this.FiliereComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TypeEmpComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Periode.SuspendLayout();
            this.SgroupBox.SuspendLayout();
            this.SemestrePanel.SuspendLayout();
            this.SessionPanel.SuspendLayout();
            this.Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).BeginInit();
            this.Document.SuspendLayout();
            this.emprunteur.SuspendLayout();
            this.SuspendLayout();
            // 
            // Periode
            // 
            this.Periode.BackColor = System.Drawing.Color.White;
            this.Periode.Controls.Add(this.SessionSemestrecheckBox);
            this.Periode.Controls.Add(this.SgroupBox);
            this.Periode.Controls.Add(this.label2);
            this.Periode.Controls.Add(this.label1);
            this.Periode.Controls.Add(this.AuDateTimePicker);
            this.Periode.Controls.Add(this.DuDateTimePicker);
            this.Periode.Enabled = false;
            this.Periode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Periode.Location = new System.Drawing.Point(259, 1);
            this.Periode.Name = "Periode";
            this.Periode.Size = new System.Drawing.Size(720, 100);
            this.Periode.TabIndex = 0;
            this.Periode.TabStop = false;
            this.Periode.Text = "Période    ";
            this.toolTip1.SetToolTip(this.Periode, "Cocher la case pour specifier la periode du préts a consulter");
            // 
            // SessionSemestrecheckBox
            // 
            this.SessionSemestrecheckBox.AutoSize = true;
            this.SessionSemestrecheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SessionSemestrecheckBox.Location = new System.Drawing.Point(285, 14);
            this.SessionSemestrecheckBox.Name = "SessionSemestrecheckBox";
            this.SessionSemestrecheckBox.Size = new System.Drawing.Size(15, 14);
            this.SessionSemestrecheckBox.TabIndex = 0;
            this.SessionSemestrecheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SessionSemestrecheckBox.UseVisualStyleBackColor = true;
            this.SessionSemestrecheckBox.CheckedChanged += new System.EventHandler(this.SessionSemestrecheckBox_CheckedChanged);
            // 
            // SgroupBox
            // 
            this.SgroupBox.Controls.Add(this.SemestreRadioButton);
            this.SgroupBox.Controls.Add(this.SessionRadioButton);
            this.SgroupBox.Controls.Add(this.SemestrePanel);
            this.SgroupBox.Controls.Add(this.SessionPanel);
            this.SgroupBox.Enabled = false;
            this.SgroupBox.Location = new System.Drawing.Point(286, 11);
            this.SgroupBox.Name = "SgroupBox";
            this.SgroupBox.Size = new System.Drawing.Size(423, 84);
            this.SgroupBox.TabIndex = 3;
            this.SgroupBox.TabStop = false;
            // 
            // SemestreRadioButton
            // 
            this.SemestreRadioButton.AutoSize = true;
            this.SemestreRadioButton.Location = new System.Drawing.Point(401, 20);
            this.SemestreRadioButton.Name = "SemestreRadioButton";
            this.SemestreRadioButton.Size = new System.Drawing.Size(14, 13);
            this.SemestreRadioButton.TabIndex = 4;
            this.SemestreRadioButton.UseVisualStyleBackColor = true;
            this.SemestreRadioButton.CheckedChanged += new System.EventHandler(this.SessionRadioButton_CheckedChanged);
            // 
            // SessionRadioButton
            // 
            this.SessionRadioButton.AutoSize = true;
            this.SessionRadioButton.Checked = true;
            this.SessionRadioButton.Location = new System.Drawing.Point(192, 19);
            this.SessionRadioButton.Name = "SessionRadioButton";
            this.SessionRadioButton.Size = new System.Drawing.Size(14, 13);
            this.SessionRadioButton.TabIndex = 3;
            this.SessionRadioButton.TabStop = true;
            this.SessionRadioButton.UseVisualStyleBackColor = true;
            this.SessionRadioButton.CheckedChanged += new System.EventHandler(this.SessionRadioButton_CheckedChanged);
            // 
            // SemestrePanel
            // 
            this.SemestrePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SemestrePanel.Controls.Add(this.SemestreComboBox);
            this.SemestrePanel.Controls.Add(this.label4);
            this.SemestrePanel.Enabled = false;
            this.SemestrePanel.Location = new System.Drawing.Point(211, 23);
            this.SemestrePanel.Name = "SemestrePanel";
            this.SemestrePanel.Size = new System.Drawing.Size(200, 54);
            this.SemestrePanel.TabIndex = 2;
            // 
            // SemestreComboBox
            // 
            this.SemestreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SemestreComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemestreComboBox.FormattingEnabled = true;
            this.SemestreComboBox.Items.AddRange(new object[] {
            "S1",
            "S2",
            "S3",
            "S4",
            "S5",
            "S6"});
            this.SemestreComboBox.Location = new System.Drawing.Point(95, 18);
            this.SemestreComboBox.Name = "SemestreComboBox";
            this.SemestreComboBox.Size = new System.Drawing.Size(98, 24);
            this.SemestreComboBox.TabIndex = 1;
            this.SemestreComboBox.SelectedIndexChanged += new System.EventHandler(this.SemestreComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Semestre  :";
            // 
            // SessionPanel
            // 
            this.SessionPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SessionPanel.Controls.Add(this.SessionComboBox);
            this.SessionPanel.Controls.Add(this.label3);
            this.SessionPanel.Location = new System.Drawing.Point(7, 22);
            this.SessionPanel.Name = "SessionPanel";
            this.SessionPanel.Size = new System.Drawing.Size(197, 56);
            this.SessionPanel.TabIndex = 1;
            // 
            // SessionComboBox
            // 
            this.SessionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SessionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionComboBox.FormattingEnabled = true;
            this.SessionComboBox.Items.AddRange(new object[] {
            "Session 1",
            "Session 2"});
            this.SessionComboBox.Location = new System.Drawing.Point(77, 19);
            this.SessionComboBox.Name = "SessionComboBox";
            this.SessionComboBox.Size = new System.Drawing.Size(113, 24);
            this.SessionComboBox.TabIndex = 1;
            this.SessionComboBox.SelectedIndexChanged += new System.EventHandler(this.SessionComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Session :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Au  *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Du  *";
            // 
            // AuDateTimePicker
            // 
            this.AuDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(5)), true);
            this.AuDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.AuDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AuDateTimePicker.Location = new System.Drawing.Point(71, 62);
            this.AuDateTimePicker.Name = "AuDateTimePicker";
            this.AuDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.AuDateTimePicker.TabIndex = 1;
            this.AuDateTimePicker.Value = new System.DateTime(2015, 5, 11, 12, 49, 16, 0);
            // 
            // DuDateTimePicker
            // 
            this.DuDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.DuDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DuDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DuDateTimePicker.Location = new System.Drawing.Point(71, 28);
            this.DuDateTimePicker.MaxDate = new System.DateTime(2062, 11, 24, 0, 0, 0, 0);
            this.DuDateTimePicker.Name = "DuDateTimePicker";
            this.DuDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.DuDateTimePicker.TabIndex = 1;
            this.DuDateTimePicker.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            // 
            // periodeCheckBox
            // 
            this.periodeCheckBox.AutoSize = true;
            this.periodeCheckBox.Location = new System.Drawing.Point(340, 3);
            this.periodeCheckBox.Name = "periodeCheckBox";
            this.periodeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.periodeCheckBox.TabIndex = 0;
            this.periodeCheckBox.UseVisualStyleBackColor = true;
            this.periodeCheckBox.CheckedChanged += new System.EventHandler(this.periodeCheckBox_CheckedChanged);
            // 
            // Main
            // 
            this.Main.Controls.Add(this.chart1);
            this.Main.Controls.Add(this.dgv1);
            this.Main.Controls.Add(this.ParDomaine);
            this.Main.Controls.Add(this.DocumentCheckBox);
            this.Main.Controls.Add(this.EmpCheckBox);
            this.Main.Controls.Add(this.periodeCheckBox);
            this.Main.Controls.Add(this.DocPDF_btn);
            this.Main.Controls.Add(this.EmpPDF_btn);
            this.Main.Controls.Add(this.TotalEmpLBL);
            this.Main.Controls.Add(this.TotaldocLBL);
            this.Main.Controls.Add(this.dataGridViewDoc);
            this.Main.Controls.Add(this.dataGridViewEmp);
            this.Main.Controls.Add(this.Document);
            this.Main.Controls.Add(this.emprunteur);
            this.Main.Controls.Add(this.Periode);
            this.Main.Location = new System.Drawing.Point(3, 3);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(1188, 560);
            this.Main.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Area3DStyle.Rotation = 10;
            chartArea2.Area3DStyle.WallWidth = 10;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(266, 208);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series2.ChartArea = "ChartArea1";
            series2.CustomProperties = "CollectedSliceExploded=True, PieDrawingStyle=SoftEdge";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            series2.IsValueShownAsLabel = true;
            series2.IsXValueIndexed = true;
            series2.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series2.Legend = "Legend1";
            series2.Name = "Nombre de préts";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(485, 300);
            this.chart1.TabIndex = 9;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title2.Name = "nombredepres ";
            title2.Text = "Nombre de préts par domaine";
            title2.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chart1.Titles.Add(title2);
            this.chart1.Visible = false;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(995, 4);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.Size = new System.Drawing.Size(13, 13);
            this.dgv1.TabIndex = 8;
            this.dgv1.Visible = false;
            // 
            // ParDomaine
            // 
            this.ParDomaine.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ParDomaine.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.ParDomaine.FlatAppearance.BorderSize = 2;
            this.ParDomaine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ParDomaine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.ParDomaine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ParDomaine.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParDomaine.ForeColor = System.Drawing.Color.White;
            this.ParDomaine.Location = new System.Drawing.Point(1041, 7);
            this.ParDomaine.Name = "ParDomaine";
            this.ParDomaine.Size = new System.Drawing.Size(144, 38);
            this.ParDomaine.TabIndex = 7;
            this.ParDomaine.Text = "Par Domaine";
            this.toolTip1.SetToolTip(this.ParDomaine, "Les domaines les plus consulter depuis le début,sous form de PDF");
            this.ParDomaine.UseVisualStyleBackColor = false;
            this.ParDomaine.Click += new System.EventHandler(this.ParDomaine_Click);
            // 
            // DocumentCheckBox
            // 
            this.DocumentCheckBox.AutoSize = true;
            this.DocumentCheckBox.Location = new System.Drawing.Point(729, 104);
            this.DocumentCheckBox.Name = "DocumentCheckBox";
            this.DocumentCheckBox.Size = new System.Drawing.Size(15, 14);
            this.DocumentCheckBox.TabIndex = 0;
            this.DocumentCheckBox.UseVisualStyleBackColor = true;
            this.DocumentCheckBox.CheckedChanged += new System.EventHandler(this.DocumentCheckBox_CheckedChanged);
            // 
            // EmpCheckBox
            // 
            this.EmpCheckBox.AutoSize = true;
            this.EmpCheckBox.Location = new System.Drawing.Point(122, 103);
            this.EmpCheckBox.Name = "EmpCheckBox";
            this.EmpCheckBox.Size = new System.Drawing.Size(15, 14);
            this.EmpCheckBox.TabIndex = 0;
            this.EmpCheckBox.UseVisualStyleBackColor = true;
            this.EmpCheckBox.CheckedChanged += new System.EventHandler(this.EmpCheckBox_CheckedChanged);
            // 
            // DocPDF_btn
            // 
            this.DocPDF_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.DocPDF_btn.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.DocPDF_btn.FlatAppearance.BorderSize = 2;
            this.DocPDF_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DocPDF_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.DocPDF_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DocPDF_btn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocPDF_btn.ForeColor = System.Drawing.Color.White;
            this.DocPDF_btn.Location = new System.Drawing.Point(1012, 527);
            this.DocPDF_btn.Name = "DocPDF_btn";
            this.DocPDF_btn.Size = new System.Drawing.Size(161, 30);
            this.DocPDF_btn.TabIndex = 6;
            this.DocPDF_btn.Text = "Créer un PDF";
            this.toolTip1.SetToolTip(this.DocPDF_btn, "Créer un PDF de ces resultats de statistique,pour le document");
            this.DocPDF_btn.UseVisualStyleBackColor = false;
            this.DocPDF_btn.Click += new System.EventHandler(this.DocPDF_btn_Click);
            // 
            // EmpPDF_btn
            // 
            this.EmpPDF_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.EmpPDF_btn.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.EmpPDF_btn.FlatAppearance.BorderSize = 2;
            this.EmpPDF_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.EmpPDF_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.EmpPDF_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpPDF_btn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPDF_btn.ForeColor = System.Drawing.Color.White;
            this.EmpPDF_btn.Location = new System.Drawing.Point(426, 527);
            this.EmpPDF_btn.Name = "EmpPDF_btn";
            this.EmpPDF_btn.Size = new System.Drawing.Size(173, 30);
            this.EmpPDF_btn.TabIndex = 6;
            this.EmpPDF_btn.Text = "Créer un PDF";
            this.toolTip1.SetToolTip(this.EmpPDF_btn, "Créer un PDF de ces resultats de statistique pour l\'emprunteur.");
            this.EmpPDF_btn.UseVisualStyleBackColor = false;
            this.EmpPDF_btn.Click += new System.EventHandler(this.EmpPDF_btn_Click);
            // 
            // TotalEmpLBL
            // 
            this.TotalEmpLBL.AutoSize = true;
            this.TotalEmpLBL.BackColor = System.Drawing.Color.Azure;
            this.TotalEmpLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalEmpLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalEmpLBL.ForeColor = System.Drawing.Color.Red;
            this.TotalEmpLBL.Location = new System.Drawing.Point(3, 527);
            this.TotalEmpLBL.Name = "TotalEmpLBL";
            this.TotalEmpLBL.Size = new System.Drawing.Size(63, 20);
            this.TotalEmpLBL.TabIndex = 5;
            this.TotalEmpLBL.Text = "Total : 0";
            // 
            // TotaldocLBL
            // 
            this.TotaldocLBL.AutoSize = true;
            this.TotaldocLBL.BackColor = System.Drawing.Color.Azure;
            this.TotaldocLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotaldocLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotaldocLBL.ForeColor = System.Drawing.Color.Red;
            this.TotaldocLBL.Location = new System.Drawing.Point(618, 527);
            this.TotaldocLBL.Name = "TotaldocLBL";
            this.TotaldocLBL.Size = new System.Drawing.Size(63, 20);
            this.TotaldocLBL.TabIndex = 4;
            this.TotaldocLBL.Text = "Total : 0";
            // 
            // dataGridViewDoc
            // 
            this.dataGridViewDoc.AllowUserToAddRows = false;
            this.dataGridViewDoc.AllowUserToDeleteRows = false;
            this.dataGridViewDoc.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoc.Location = new System.Drawing.Point(618, 208);
            this.dataGridViewDoc.Name = "dataGridViewDoc";
            this.dataGridViewDoc.ReadOnly = true;
            this.dataGridViewDoc.Size = new System.Drawing.Size(567, 313);
            this.dataGridViewDoc.TabIndex = 3;
            // 
            // dataGridViewEmp
            // 
            this.dataGridViewEmp.AllowUserToAddRows = false;
            this.dataGridViewEmp.AllowUserToDeleteRows = false;
            this.dataGridViewEmp.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmp.Location = new System.Drawing.Point(3, 208);
            this.dataGridViewEmp.Name = "dataGridViewEmp";
            this.dataGridViewEmp.ReadOnly = true;
            this.dataGridViewEmp.Size = new System.Drawing.Size(609, 313);
            this.dataGridViewEmp.TabIndex = 2;
            // 
            // Document
            // 
            this.Document.Controls.Add(this.DomaineComboBox);
            this.Document.Controls.Add(this.label9);
            this.Document.Controls.Add(this.TypeDocComboBox);
            this.Document.Controls.Add(this.label8);
            this.Document.Enabled = false;
            this.Document.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Document.Location = new System.Drawing.Point(618, 102);
            this.Document.Name = "Document";
            this.Document.Size = new System.Drawing.Size(567, 100);
            this.Document.TabIndex = 1;
            this.Document.TabStop = false;
            this.Document.Text = "Document      ";
            this.toolTip1.SetToolTip(this.Document, "Cocher la case pour specifier le type ou/et  le domaine ou le sous-domaine du doc" +
                    "ument qui est emprunter le plus");
            // 
            // DomaineComboBox
            // 
            this.DomaineComboBox.FormattingEnabled = true;
            this.DomaineComboBox.Location = new System.Drawing.Point(318, 55);
            this.DomaineComboBox.Name = "DomaineComboBox";
            this.DomaineComboBox.Size = new System.Drawing.Size(227, 28);
            this.DomaineComboBox.TabIndex = 1;
            this.DomaineComboBox.TextChanged += new System.EventHandler(this.TypeEmpComboBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(315, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Domaine ou sous domaine :";
            // 
            // TypeDocComboBox
            // 
            this.TypeDocComboBox.FormattingEnabled = true;
            this.TypeDocComboBox.Location = new System.Drawing.Point(61, 55);
            this.TypeDocComboBox.Name = "TypeDocComboBox";
            this.TypeDocComboBox.Size = new System.Drawing.Size(178, 28);
            this.TypeDocComboBox.TabIndex = 1;
            this.TypeDocComboBox.TextChanged += new System.EventHandler(this.TypeEmpComboBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(58, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Type :";
            // 
            // emprunteur
            // 
            this.emprunteur.Controls.Add(this.SexeComboBox);
            this.emprunteur.Controls.Add(this.FiliereComboBox);
            this.emprunteur.Controls.Add(this.label7);
            this.emprunteur.Controls.Add(this.TypeEmpComboBox);
            this.emprunteur.Controls.Add(this.label6);
            this.emprunteur.Controls.Add(this.label5);
            this.emprunteur.Enabled = false;
            this.emprunteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emprunteur.Location = new System.Drawing.Point(3, 102);
            this.emprunteur.Name = "emprunteur";
            this.emprunteur.Size = new System.Drawing.Size(609, 100);
            this.emprunteur.TabIndex = 1;
            this.emprunteur.TabStop = false;
            this.emprunteur.Text = "Emprunteur      ";
            this.toolTip1.SetToolTip(this.emprunteur, "Cocher la case pour specifier le type ou/et  la filier ou/et  le sexe de l\'emprun" +
                    "teur  qui a emprunter le plus");
            // 
            // SexeComboBox
            // 
            this.SexeComboBox.FormattingEnabled = true;
            this.SexeComboBox.Items.AddRange(new object[] {
            "M",
            "F"});
            this.SexeComboBox.Location = new System.Drawing.Point(455, 55);
            this.SexeComboBox.Name = "SexeComboBox";
            this.SexeComboBox.Size = new System.Drawing.Size(91, 28);
            this.SexeComboBox.TabIndex = 1;
            this.SexeComboBox.SelectedIndexChanged += new System.EventHandler(this.SexeComboBox_SelectedIndexChanged);
            this.SexeComboBox.TextChanged += new System.EventHandler(this.TypeEmpComboBox_TextChanged);
            // 
            // FiliereComboBox
            // 
            this.FiliereComboBox.FormattingEnabled = true;
            this.FiliereComboBox.Location = new System.Drawing.Point(247, 55);
            this.FiliereComboBox.Name = "FiliereComboBox";
            this.FiliereComboBox.Size = new System.Drawing.Size(154, 28);
            this.FiliereComboBox.TabIndex = 1;
            this.FiliereComboBox.TextChanged += new System.EventHandler(this.TypeEmpComboBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(452, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sexe :";
            // 
            // TypeEmpComboBox
            // 
            this.TypeEmpComboBox.FormattingEnabled = true;
            this.TypeEmpComboBox.Location = new System.Drawing.Point(51, 55);
            this.TypeEmpComboBox.Name = "TypeEmpComboBox";
            this.TypeEmpComboBox.Size = new System.Drawing.Size(155, 28);
            this.TypeEmpComboBox.TabIndex = 1;
            this.TypeEmpComboBox.TextChanged += new System.EventHandler(this.TypeEmpComboBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(244, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Filiere :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Type :";
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            this.toolTip1.OwnerDraw = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            // 
            // Statistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Main);
            this.Name = "Statistiques";
            this.Size = new System.Drawing.Size(1194, 566);
            this.Load += new System.EventHandler(this.Statistiques_Load);
            this.Resize += new System.EventHandler(this.Statistiques_Resize);
            this.Periode.ResumeLayout(false);
            this.Periode.PerformLayout();
            this.SgroupBox.ResumeLayout(false);
            this.SgroupBox.PerformLayout();
            this.SemestrePanel.ResumeLayout(false);
            this.SemestrePanel.PerformLayout();
            this.SessionPanel.ResumeLayout(false);
            this.SessionPanel.PerformLayout();
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).EndInit();
            this.Document.ResumeLayout(false);
            this.Document.PerformLayout();
            this.emprunteur.ResumeLayout(false);
            this.emprunteur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Periode;
        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.GroupBox emprunteur;
        private System.Windows.Forms.CheckBox periodeCheckBox;
        private System.Windows.Forms.GroupBox Document;
        private System.Windows.Forms.CheckBox EmpCheckBox;
        private System.Windows.Forms.CheckBox DocumentCheckBox;
        private System.Windows.Forms.GroupBox SgroupBox;
        private System.Windows.Forms.RadioButton SemestreRadioButton;
        private System.Windows.Forms.RadioButton SessionRadioButton;
        private System.Windows.Forms.Panel SemestrePanel;
        private System.Windows.Forms.ComboBox SemestreComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel SessionPanel;
        private System.Windows.Forms.ComboBox SessionComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox SessionSemestrecheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker AuDateTimePicker;
        private System.Windows.Forms.DateTimePicker DuDateTimePicker;
        private System.Windows.Forms.Button DocPDF_btn;
        private System.Windows.Forms.Button EmpPDF_btn;
        private System.Windows.Forms.Label TotalEmpLBL;
        private System.Windows.Forms.Label TotaldocLBL;
        private System.Windows.Forms.DataGridView dataGridViewDoc;
        private System.Windows.Forms.DataGridView dataGridViewEmp;
        private System.Windows.Forms.ComboBox DomaineComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox TypeDocComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox SexeComboBox;
        private System.Windows.Forms.ComboBox FiliereComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox TypeEmpComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button ParDomaine;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
