using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ParcelleLibraryJSON;
using ParcelleLibraryJSON.Gestions;

namespace WindowsFormsParcelles
{
    public partial class FormConfiguration : Form
    {
        private GestionExploitants gestion;

        public FormConfiguration(GestionExploitants gestion)
        {
            InitializeComponent();
            this.gestion = gestion;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            gestion.ConfigFile = txtFileName.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormConfiguration_Load(object sender, EventArgs e)
        {
            txtFileName.Text = gestion.ConfigFile;
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = Path.GetDirectoryName(gestion.ConfigFile);

            if (file.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = file.FileName;
            }
        }
    }
}
