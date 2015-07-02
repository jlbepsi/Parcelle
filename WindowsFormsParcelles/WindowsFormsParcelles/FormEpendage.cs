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
    public partial class FormEpendage : Form
    {
        public FormEpendage()
        {
            InitializeComponent();
        }

        private void FormEpendage_Load(object sender, EventArgs e)
        {
            cbType.SelectedIndex = 0;
            cbProduit.SelectedIndex = 1;

            //btnTypes.ImageList = FormExploitant.imageList;
            btnTypes.ImageIndex = 0;
            //btnProduits.ImageList = FormExploitant.imageList;
            btnProduits.ImageIndex = 0;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {

        }

        private void uDownQuantiteReelle_ValueChanged(object sender, EventArgs e)
        {
            decimal value = uDownQuantiteReelle.Value * 4; // 4 hectares pour cette parcelle
            txtQuantiteTotale.Text = value.ToString() + " g";
        }

        private void btnProduits_Click(object sender, EventArgs e)
        {

        }
    }
}
