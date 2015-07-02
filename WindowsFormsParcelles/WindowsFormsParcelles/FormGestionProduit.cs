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
    public partial class FormGestionProduit : Form
    {
        public FormGestionProduit()
        {
            InitializeComponent();
        }

        private void FormGestionProduit_Load(object sender, EventArgs e)
        {
            //btnTypes.ImageList = FormExploitant.imageList;
            btnTypes.ImageIndex = 0;

            cbCategorie.SelectedIndex = 0;
            cbParHectare.SelectedIndex = 0;
        }
    }
}
