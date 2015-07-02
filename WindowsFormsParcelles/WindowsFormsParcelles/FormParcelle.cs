using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsParcelles
{
    public partial class FormParcelle : Form
    {
        public FormParcelle()
        {
            InitializeComponent();
        }

        private void FormParcelle_Load(object sender, EventArgs e)
        {
            cbCulture.SelectedIndex = 0;
            cbCategorie.SelectedIndex = 0;
            lvEpandages.Items.Clear();

            lvEpandages.Items.Add(new ListViewItem(new string[] { "Semance", "Rouille jaune du blé", "3 litres", "22/02/214", "" }));
            lvEpandages.Items.Add(new ListViewItem(new string[] { "Semance", "Mageos MD/Clameur", "280 g", "22/02/214", "" }));
            lvEpandages.Items.Add(new ListViewItem(new string[] { "Semance", "Carto Rouille brune", "1 litre", "22/02/214", "" }));
            lvEpandages.Items.Add(new ListViewItem(new string[] { "En champs", "multiple", "1 litre", "multiple", "" }));
        }

        private void btnCultures_Click(object sender, EventArgs e)
        {
            FormCulture frm = new FormCulture();
            frm.ShowDialog();
        }

        private void btnNouvelleParcelle_Click(object sender, EventArgs e)
        {
            cbCulture.Enabled = cbCategorie.Enabled = true;
            btnValiderParcelle.Enabled = btnAnnulerParcelle.Enabled = true;

            btnNouvelleParcelle.Enabled = btnFermer.Enabled = false;
        }

        private void btnValiderParcelle_Click(object sender, EventArgs e)
        {
            cbCulture.Enabled = cbCategorie.Enabled = false;
            btnValiderParcelle.Enabled = btnAnnulerParcelle.Enabled = false;

            btnNouvelleParcelle.Enabled = btnFermer.Enabled = true;
        }

        private void btnAnnulerParcelle_Click(object sender, EventArgs e)
        {
            cbCulture.Enabled = cbCategorie.Enabled = false;
            btnValiderParcelle.Enabled = btnAnnulerParcelle.Enabled = false;

            btnNouvelleParcelle.Enabled = btnFermer.Enabled = true;
        }

        private void lvEpandages_DoubleClick(object sender, EventArgs e)
        {
            FormEpendage frm = new FormEpendage();
            frm.ShowDialog();
        }

        private void lvEpandages_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Subtract:
                case Keys.Delete:
                    MessageBox.Show("Vous ne pouvez pas supprimer un épandage", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Keys.Add:
                    MessageBox.Show("Ajout d'un épandage");
                    break;
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
