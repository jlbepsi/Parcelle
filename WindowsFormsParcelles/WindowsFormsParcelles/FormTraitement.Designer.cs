namespace WindowsFormsParcelles
{
    partial class FormTraitement
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtQuantiteTotale = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelEnChamps = new System.Windows.Forms.Panel();
            this.panelSemences = new System.Windows.Forms.Panel();
            this.upDownDosage = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeDosage = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lvEpandages = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.cbProduit = new System.Windows.Forms.ComboBox();
            this.panelEnChamps.SuspendLayout();
            this.panelSemences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownDosage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(472, 391);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Description :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(166, 10);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(337, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // txtQuantiteTotale
            // 
            this.txtQuantiteTotale.Location = new System.Drawing.Point(166, 36);
            this.txtQuantiteTotale.Name = "txtQuantiteTotale";
            this.txtQuantiteTotale.Size = new System.Drawing.Size(337, 20);
            this.txtQuantiteTotale.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantité totale :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelEnChamps
            // 
            this.panelEnChamps.Controls.Add(this.lvEpandages);
            this.panelEnChamps.Controls.Add(this.label5);
            this.panelEnChamps.Location = new System.Drawing.Point(12, 109);
            this.panelEnChamps.Name = "panelEnChamps";
            this.panelEnChamps.Size = new System.Drawing.Size(502, 254);
            this.panelEnChamps.TabIndex = 7;
            // 
            // panelSemences
            // 
            this.panelSemences.Controls.Add(this.dateTimeDosage);
            this.panelSemences.Controls.Add(this.label4);
            this.panelSemences.Controls.Add(this.upDownDosage);
            this.panelSemences.Controls.Add(this.label2);
            this.panelSemences.Location = new System.Drawing.Point(551, 109);
            this.panelSemences.Name = "panelSemences";
            this.panelSemences.Size = new System.Drawing.Size(335, 127);
            this.panelSemences.TabIndex = 8;
            // 
            // upDownDosage
            // 
            this.upDownDosage.Location = new System.Drawing.Point(90, 20);
            this.upDownDosage.Name = "upDownDosage";
            this.upDownDosage.Size = new System.Drawing.Size(93, 20);
            this.upDownDosage.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Dosage";
            // 
            // dateTimeDosage
            // 
            this.dateTimeDosage.Location = new System.Drawing.Point(90, 46);
            this.dateTimeDosage.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dateTimeDosage.MinDate = new System.DateTime(2014, 8, 29, 0, 0, 0, 0);
            this.dateTimeDosage.Name = "dateTimeDosage";
            this.dateTimeDosage.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDosage.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Liste des traitements :";
            // 
            // lvEpandages
            // 
            this.lvEpandages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2});
            this.lvEpandages.FullRowSelect = true;
            this.lvEpandages.GridLines = true;
            this.lvEpandages.Location = new System.Drawing.Point(23, 43);
            this.lvEpandages.Name = "lvEpandages";
            this.lvEpandages.Size = new System.Drawing.Size(468, 189);
            this.lvEpandages.TabIndex = 13;
            this.lvEpandages.UseCompatibleStateImageBehavior = false;
            this.lvEpandages.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Dosage";
            this.columnHeader0.Width = 105;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date trait.";
            this.columnHeader1.Width = 141;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 207;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Produit :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbProduit
            // 
            this.cbProduit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduit.FormattingEnabled = true;
            this.cbProduit.Location = new System.Drawing.Point(167, 62);
            this.cbProduit.Name = "cbProduit";
            this.cbProduit.Size = new System.Drawing.Size(336, 21);
            this.cbProduit.TabIndex = 9;
            // 
            // FormTraitement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 427);
            this.ControlBox = false;
            this.Controls.Add(this.cbProduit);
            this.Controls.Add(this.panelSemences);
            this.Controls.Add(this.panelEnChamps);
            this.Controls.Add(this.txtQuantiteTotale);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Name = "FormTraitement";
            this.Text = "Traitement";
            this.panelEnChamps.ResumeLayout(false);
            this.panelEnChamps.PerformLayout();
            this.panelSemences.ResumeLayout(false);
            this.panelSemences.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownDosage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtQuantiteTotale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelEnChamps;
        private System.Windows.Forms.Panel panelSemences;
        private System.Windows.Forms.NumericUpDown upDownDosage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeDosage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvEpandages;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbProduit;
    }
}