namespace WindowsFormsParcelles
{
    partial class FormCulture
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
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lvCultures = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.txtDescritpion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProduit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Location = new System.Drawing.Point(127, 272);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(89, 23);
            this.btnSauvegarder.TabIndex = 0;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(280, 272);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 0;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // lvCultures
            // 
            this.lvCultures.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.Description,
            this.columnHeader1,
            this.columnHeader3});
            this.lvCultures.FullRowSelect = true;
            this.lvCultures.GridLines = true;
            this.lvCultures.Location = new System.Drawing.Point(-2, -1);
            this.lvCultures.Name = "lvCultures";
            this.lvCultures.Size = new System.Drawing.Size(576, 171);
            this.lvCultures.TabIndex = 12;
            this.lvCultures.UseCompatibleStateImageBehavior = false;
            this.lvCultures.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Catégorie";
            this.columnHeader2.Width = 129;
            // 
            // Description
            // 
            this.Description.Text = "Produit";
            this.Description.Width = 199;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Description";
            this.columnHeader1.Width = 98;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Commentaire";
            this.columnHeader3.Width = 142;
            // 
            // cbCategorie
            // 
            this.cbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Items.AddRange(new object[] {
            "Céréales",
            "Vin"});
            this.cbCategorie.Location = new System.Drawing.Point(160, 176);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(243, 21);
            this.cbCategorie.TabIndex = 26;
            // 
            // txtDescritpion
            // 
            this.txtDescritpion.Location = new System.Drawing.Point(160, 228);
            this.txtDescritpion.Name = "txtDescritpion";
            this.txtDescritpion.Size = new System.Drawing.Size(243, 20);
            this.txtDescritpion.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Description";
            // 
            // txtProduit
            // 
            this.txtProduit.Location = new System.Drawing.Point(160, 202);
            this.txtProduit.Name = "txtProduit";
            this.txtProduit.Size = new System.Drawing.Size(243, 20);
            this.txtProduit.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Catégorie";
            // 
            // FormCulture
            // 
            this.AcceptButton = this.btnSauvegarder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(577, 301);
            this.ControlBox = false;
            this.Controls.Add(this.cbCategorie);
            this.Controls.Add(this.txtDescritpion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProduit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvCultures);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSauvegarder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormCulture";
            this.Text = "Gestion des cultures";
            this.Load += new System.EventHandler(this.FormCulture_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ListView lvCultures;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox cbCategorie;
        private System.Windows.Forms.TextBox txtDescritpion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProduit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}