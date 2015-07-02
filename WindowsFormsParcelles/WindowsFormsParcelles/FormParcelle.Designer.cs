namespace WindowsFormsParcelles
{
    partial class FormParcelle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSurface = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmplacement = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lvEpandages = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFermer = new System.Windows.Forms.Button();
            this.cbCulture = new System.Windows.Forms.ComboBox();
            this.btnCultures = new System.Windows.Forms.Button();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnNouvelleParcelle = new System.Windows.Forms.Button();
            this.btnValiderParcelle = new System.Windows.Forms.Button();
            this.btnAnnulerParcelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catégorie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Culture";
            // 
            // txtSurface
            // 
            this.txtSurface.Location = new System.Drawing.Point(105, 89);
            this.txtSurface.Name = "txtSurface";
            this.txtSurface.Size = new System.Drawing.Size(243, 20);
            this.txtSurface.TabIndex = 5;
            this.txtSurface.Text = "4 Ha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surface";
            // 
            // txtEmplacement
            // 
            this.txtEmplacement.Location = new System.Drawing.Point(105, 115);
            this.txtEmplacement.Name = "txtEmplacement";
            this.txtEmplacement.Size = new System.Drawing.Size(243, 20);
            this.txtEmplacement.TabIndex = 7;
            this.txtEmplacement.Text = "La Gariguette";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Emplacement";
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Location = new System.Drawing.Point(105, 141);
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(243, 20);
            this.txtCommentaire.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Commentaire";
            // 
            // lvEpandages
            // 
            this.lvEpandages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvEpandages.FullRowSelect = true;
            this.lvEpandages.GridLines = true;
            this.lvEpandages.Location = new System.Drawing.Point(6, 19);
            this.lvEpandages.Name = "lvEpandages";
            this.lvEpandages.Size = new System.Drawing.Size(540, 230);
            this.lvEpandages.TabIndex = 11;
            this.lvEpandages.UseCompatibleStateImageBehavior = false;
            this.lvEpandages.View = System.Windows.Forms.View.Details;
            this.lvEpandages.DoubleClick += new System.EventHandler(this.lvEpandages_DoubleClick);
            this.lvEpandages.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lvEpandages_KeyUp);
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Type";
            this.columnHeader0.Width = 87;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Description";
            this.columnHeader1.Width = 139;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantité totale";
            this.columnHeader2.Width = 109;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 80;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(242, 470);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 12;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // cbCulture
            // 
            this.cbCulture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCulture.Enabled = false;
            this.cbCulture.FormattingEnabled = true;
            this.cbCulture.Items.AddRange(new object[] {
            "Maïs",
            "Blé",
            "Seigle",
            "Riz",
            "Orge"});
            this.cbCulture.Location = new System.Drawing.Point(105, 63);
            this.cbCulture.Name = "cbCulture";
            this.cbCulture.Size = new System.Drawing.Size(243, 21);
            this.cbCulture.TabIndex = 14;
            // 
            // btnCultures
            // 
            this.btnCultures.ImageIndex = 0;
            this.btnCultures.Location = new System.Drawing.Point(363, 61);
            this.btnCultures.Name = "btnCultures";
            this.btnCultures.Size = new System.Drawing.Size(21, 21);
            this.btnCultures.TabIndex = 15;
            this.btnCultures.UseVisualStyleBackColor = true;
            this.btnCultures.Click += new System.EventHandler(this.btnCultures_Click);
            // 
            // cbCategorie
            // 
            this.cbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategorie.Enabled = false;
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Items.AddRange(new object[] {
            "Vignes",
            "Céréales",
            "Oléagineux",
            "Protéagineux"});
            this.cbCategorie.Location = new System.Drawing.Point(105, 36);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(243, 21);
            this.cbCategorie.TabIndex = 14;
            // 
            // btnCategories
            // 
            this.btnCategories.ImageIndex = 0;
            this.btnCategories.Location = new System.Drawing.Point(363, 35);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(21, 21);
            this.btnCategories.TabIndex = 16;
            this.btnCategories.UseVisualStyleBackColor = true;
            // 
            // btnNouvelleParcelle
            // 
            this.btnNouvelleParcelle.Location = new System.Drawing.Point(426, 36);
            this.btnNouvelleParcelle.Name = "btnNouvelleParcelle";
            this.btnNouvelleParcelle.Size = new System.Drawing.Size(120, 23);
            this.btnNouvelleParcelle.TabIndex = 12;
            this.btnNouvelleParcelle.Text = "Nouvelle parcelle";
            this.btnNouvelleParcelle.UseVisualStyleBackColor = true;
            this.btnNouvelleParcelle.Click += new System.EventHandler(this.btnNouvelleParcelle_Click);
            // 
            // btnValiderParcelle
            // 
            this.btnValiderParcelle.Enabled = false;
            this.btnValiderParcelle.Location = new System.Drawing.Point(426, 110);
            this.btnValiderParcelle.Name = "btnValiderParcelle";
            this.btnValiderParcelle.Size = new System.Drawing.Size(75, 23);
            this.btnValiderParcelle.TabIndex = 12;
            this.btnValiderParcelle.Text = "Valider";
            this.btnValiderParcelle.UseVisualStyleBackColor = true;
            this.btnValiderParcelle.Click += new System.EventHandler(this.btnValiderParcelle_Click);
            // 
            // btnAnnulerParcelle
            // 
            this.btnAnnulerParcelle.Enabled = false;
            this.btnAnnulerParcelle.Location = new System.Drawing.Point(426, 139);
            this.btnAnnulerParcelle.Name = "btnAnnulerParcelle";
            this.btnAnnulerParcelle.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerParcelle.TabIndex = 12;
            this.btnAnnulerParcelle.Text = "Annuler";
            this.btnAnnulerParcelle.UseVisualStyleBackColor = true;
            this.btnAnnulerParcelle.Click += new System.EventHandler(this.btnAnnulerParcelle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCategories);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCultures);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbCategorie);
            this.groupBox1.Controls.Add(this.txtSurface);
            this.groupBox1.Controls.Add(this.cbCulture);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEmplacement);
            this.groupBox1.Controls.Add(this.btnAnnulerParcelle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnValiderParcelle);
            this.groupBox1.Controls.Add(this.txtCommentaire);
            this.groupBox1.Controls.Add(this.btnNouvelleParcelle);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 177);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parcelle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvEpandages);
            this.groupBox2.Location = new System.Drawing.Point(15, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 255);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste des traitements";
            // 
            // FormParcelle
            // 
            this.AcceptButton = this.btnFermer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 498);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFermer);
            this.Name = "FormParcelle";
            this.Text = "Détails d\'une parcelle";
            this.Load += new System.EventHandler(this.FormParcelle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSurface;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmplacement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCommentaire;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvEpandages;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.ComboBox cbCulture;
        private System.Windows.Forms.Button btnCultures;
        private System.Windows.Forms.ComboBox cbCategorie;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnNouvelleParcelle;
        private System.Windows.Forms.Button btnValiderParcelle;
        private System.Windows.Forms.Button btnAnnulerParcelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}