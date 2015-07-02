namespace WindowsFormsParcelles
{
    partial class FormEpendage
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
            this.btnTypes = new System.Windows.Forms.Button();
            this.btnProduits = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbProduit = new System.Windows.Forms.ComboBox();
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantitePreconise = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantiteTotale = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.uDownQuantiteReelle = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uDownQuantiteReelle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTypes
            // 
            this.btnTypes.ImageIndex = 0;
            this.btnTypes.Location = new System.Drawing.Point(348, 11);
            this.btnTypes.Name = "btnTypes";
            this.btnTypes.Size = new System.Drawing.Size(21, 21);
            this.btnTypes.TabIndex = 2;
            this.btnTypes.UseVisualStyleBackColor = true;
            // 
            // btnProduits
            // 
            this.btnProduits.ImageIndex = 0;
            this.btnProduits.Location = new System.Drawing.Point(348, 37);
            this.btnProduits.Name = "btnProduits";
            this.btnProduits.Size = new System.Drawing.Size(21, 21);
            this.btnProduits.TabIndex = 4;
            this.btnProduits.UseVisualStyleBackColor = true;
            this.btnProduits.Click += new System.EventHandler(this.btnProduits_Click);
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Semence"});
            this.cbType.Location = new System.Drawing.Point(90, 12);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(243, 21);
            this.cbType.TabIndex = 1;
            // 
            // cbProduit
            // 
            this.cbProduit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduit.FormattingEnabled = true;
            this.cbProduit.Items.AddRange(new object[] {
            "Rouille jaune du blé",
            "Mageos MD/Clameur",
            "Carto Rouille brune"});
            this.cbProduit.Location = new System.Drawing.Point(90, 39);
            this.cbProduit.Name = "cbProduit";
            this.cbProduit.Size = new System.Drawing.Size(243, 21);
            this.cbProduit.TabIndex = 3;
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Location = new System.Drawing.Point(90, 168);
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(243, 20);
            this.txtCommentaire.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Commentaire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Date";
            // 
            // txtQuantitePreconise
            // 
            this.txtQuantitePreconise.Enabled = false;
            this.txtQuantitePreconise.Location = new System.Drawing.Point(90, 65);
            this.txtQuantitePreconise.Name = "txtQuantitePreconise";
            this.txtQuantitePreconise.Size = new System.Drawing.Size(243, 20);
            this.txtQuantitePreconise.TabIndex = 5;
            this.txtQuantitePreconise.Text = "70 g / ha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Qté préconisée";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Produit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Type";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(243, 203);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Location = new System.Drawing.Point(90, 203);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(89, 23);
            this.btnSauvegarder.TabIndex = 10;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = true;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(90, 143);
            this.dateTimePicker.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2014, 8, 29, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Qté totale";
            // 
            // txtQuantiteTotale
            // 
            this.txtQuantiteTotale.Enabled = false;
            this.txtQuantiteTotale.Location = new System.Drawing.Point(90, 117);
            this.txtQuantiteTotale.Name = "txtQuantiteTotale";
            this.txtQuantiteTotale.Size = new System.Drawing.Size(243, 20);
            this.txtQuantiteTotale.TabIndex = 7;
            this.txtQuantiteTotale.Text = "280 g";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Qté réelle";
            // 
            // uDownQuantiteReelle
            // 
            this.uDownQuantiteReelle.Location = new System.Drawing.Point(90, 91);
            this.uDownQuantiteReelle.Name = "uDownQuantiteReelle";
            this.uDownQuantiteReelle.Size = new System.Drawing.Size(120, 20);
            this.uDownQuantiteReelle.TabIndex = 6;
            this.uDownQuantiteReelle.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.uDownQuantiteReelle.ValueChanged += new System.EventHandler(this.uDownQuantiteReelle_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "par hectare";
            // 
            // FormEpendage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 235);
            this.ControlBox = false;
            this.Controls.Add(this.uDownQuantiteReelle);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(this.btnTypes);
            this.Controls.Add(this.btnProduits);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cbProduit);
            this.Controls.Add(this.txtCommentaire);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantiteTotale);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQuantitePreconise);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormEpendage";
            this.Text = "Ependage";
            this.Load += new System.EventHandler(this.FormEpendage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uDownQuantiteReelle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTypes;
        private System.Windows.Forms.Button btnProduits;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbProduit;
        private System.Windows.Forms.TextBox txtCommentaire;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantitePreconise;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantiteTotale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown uDownQuantiteReelle;
        private System.Windows.Forms.Label label8;
    }
}