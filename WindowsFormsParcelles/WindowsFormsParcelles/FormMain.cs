using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

using ParcelleLibraryJSON;
using ParcelleLibraryJSON.Gestions;

namespace WindowsFormsParcelles
{
    public partial class FormMain : Form
    {
        private const int TypeListeExploitant = 0;
        private const int TypeExploitant = 1;
        private const int TypeParcelle = 2;
        private const int TypeTraitement = 3;
        private const int TypePulverisation = 4;

        private Panel currentPanel = null;
        private int currentType = -1;

        private GestionExploitants gestion = new GestionExploitants();

        public FormMain()
        {
            InitializeComponent();
            gestion.ConfigFile = Directory.GetCurrentDirectory() + @"\parcelles.config";
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfiguration frm = new FormConfiguration(gestion);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadExploitants();
            }
        }

        
        private void LoadExploitants()
        {
            try
            {
                gestion.DeserializeFromJSON();
            }
            catch (ParcelleException ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Les exploitants
            TreeNode root = new TreeNode("Exploitants", TypeListeExploitant, TypeListeExploitant);
            root.ImageIndex = TypeListeExploitant;
            treeView.Nodes.Add(root);

            foreach (Exploitant exploitant in gestion.Liste)
            {
                TreeNode newNode = new TreeNode(exploitant.NomAffiche, TypeExploitant, TypeExploitant);
                newNode.Tag = exploitant;
                newNode.ImageIndex = TypeExploitant;
                // Add a dummy data
                newNode.Nodes.Add("dummy");

                root.Nodes.Add(newNode);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormConnexion form = new FormConnexion();
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Ajout des données dans le TreeView
                LoadExploitants();

                this.treeView.Enabled = this.listView.Enabled = true;

            }
            else
                this.Close();
        }
        #region TreeView
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (currentPanel != null)
                currentPanel.Visible = false;

            listView.Clear();
            listView.Columns.Clear();
            listView.BeginUpdate();
            
            // ToolStrip
            toolStripProgressBar.Value = 0;
            toolStripBtnCancel.Visible = true;
            toolStripLabel.Visible = true;
            toolStripProgressBar.Visible = true;

            switch (e.Node.ImageIndex)
            {
                case TypeListeExploitant:
                    ShowListViewExploitants();

                    break;
                case TypeExploitant:
                    ShowListViewParcelles(e.Node.Tag as Exploitant);
                    break;
                case TypeParcelle:
                    ShowListViewTraitements(e.Node.Tag as Parcelle);
                    break;
                case TypeTraitement:
                    ShowListViewPulverisations(e.Node.Tag as TraitementPhytosanitaire);
                    break;
            }

            toolStripBtnCancel.Visible = false;
            toolStripLabel.Visible = false;
            toolStripProgressBar.Visible = false;
            toolStripLabel.Text = "";

            listView.EndUpdate();
        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            treeView.BeginUpdate();

            // ToolStrip
            toolStripProgressBar.Value = 0;
            toolStripBtnCancel.Visible = true;
            toolStripLabel.Visible = true;
            toolStripProgressBar.Visible = true;

            switch (e.Node.ImageIndex)
            {
                case TypeExploitant:
                    toolStripLabel.Text = "Chargements des exploitants";
                    // Suppression du "dummy" node
                    e.Node.Nodes.Clear();

                    // Obtention de l'exploitant
                    Exploitant exploitant = (e.Node.Tag as Exploitant);
                    toolStripProgressBar.Maximum = exploitant.Parcelles.Count;

                    // Chargement des parcelles
                    foreach (Parcelle parcelle in exploitant.Parcelles)
                    {
                        TreeNode newNode = new TreeNode(parcelle.Description, TypeParcelle, TypeParcelle);
                        newNode.Tag = parcelle;
                        newNode.ImageIndex = TypeParcelle;
                        // Add a dummy data
                        newNode.Nodes.Add("dummy");

                        e.Node.Nodes.Add(newNode);

                        toolStripProgressBar.Value++;
                    }
                    break;
                case TypeParcelle:
                    toolStripLabel.Text = "Chargements des traitements";
                    // Suppression du "dummy" node
                    e.Node.Nodes.Clear();

                    // Obtention de la parcelle
                    Parcelle p = (e.Node.Tag as Parcelle);
                    toolStripProgressBar.Maximum = p.Traitements.Count;

                    // Chargement des traitements
                    foreach (TraitementPhytosanitaire t in p.Traitements)
                    {
                        TreeNode newNode = new TreeNode(t.Description, TypeTraitement, TypeTraitement);
                        newNode.Tag = t;
                        newNode.ImageIndex = TypeTraitement;
                        // Add a dummy data
                        if (t is TraitementEnChamp)
                            newNode.Nodes.Add("dummy");

                        e.Node.Nodes.Add(newNode);

                        toolStripProgressBar.Value++;
                    }
                    break;
                case TypeTraitement:
                    toolStripLabel.Text = "Chargements des pulvérisations";
                    // Suppression du "dummy" node
                    e.Node.Nodes.Clear();

                    // Obtention du traitement
                    TraitementEnChamp ct = (e.Node.Tag as TraitementEnChamp);
                    toolStripProgressBar.Maximum = ct.Pulverisations.Count;

                    // Chargement des pulvérisations
                    if (ct != null)
                    {
                        foreach (Pulverisation p1 in ct.Pulverisations)
                        {
                            TreeNode newNode = new TreeNode(p1.Description, TypePulverisation, TypePulverisation);
                            newNode.Tag = p1;
                            newNode.ImageIndex = TypePulverisation;

                            e.Node.Nodes.Add(newNode);

                            toolStripProgressBar.Value++;
                        }
                    }
                    break;
            }

            toolStripBtnCancel.Visible = false;
            toolStripLabel.Visible = false;
            toolStripProgressBar.Visible = false;
            toolStripLabel.Text = "";

            treeView.EndUpdate();
        }
        #endregion


        #region ListView
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentPanel != null)
                currentPanel.Visible = false;

            if (listView.SelectedIndices.Count == 1)
            {
                ListViewItem lvi = listView.SelectedItems[0];
                if (lvi.Tag != null)
                {
                    switch (currentType)
                    {
                        case TypeExploitant:
                            currentPanel = panelExploitant;

                            Exploitant exploitant = (lvi.Tag as Exploitant);
                            break;
                        case TypeParcelle:
                            currentPanel = panelParcelle;

                            Parcelle parcelle = (lvi.Tag as Parcelle);
                            break;
                        default:
                            currentPanel = null;
                            break;
                    }
                }
                if (currentPanel != null)
                {
                    currentPanel.Dock = DockStyle.Fill;
                    currentPanel.Visible = true;
                }
            }
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            if (listView.SelectedIndices.Count == 1)
            {
                Form frm = null;

                ListViewItem lvi = listView.SelectedItems[0];
                if (lvi.Tag != null)
                {
                    switch (currentType)
                    {
                        case TypeExploitant:
                            frm = new FormExploitant(lvi.Tag as Exploitant);
                            break;

                        case TypeParcelle:
                            frm = new FormParcelle();
                            break;

                        case TypeTraitement:
                            break;

                        case TypePulverisation:
                            frm = new FormEpendage();
                            break;
                    }

                    if (frm != null)
                        frm.ShowDialog();
                }
            }

        }

        private void ShowListViewExploitants()
        {
            currentType = TypeExploitant;

            toolStripLabel.Text = "Chargements des exploitants";
            // Affichage des parcelles dans le listView
            listView.Columns.Add("Nom", 100);
            listView.Columns.Add("Prénom", 100);
            listView.Columns.Add("Téléphone", 100);
            listView.Columns.Add("Email", 100);
            listView.Columns.Add("Parcelles", 100);

            toolStripProgressBar.Maximum = gestion.Liste.Count;
            foreach (Exploitant exploitant in gestion.Liste)
            {
                ListViewItem lvi = new ListViewItem(new string[] { exploitant.Nom, exploitant.Prenom, exploitant.Telephone, exploitant.Mail, exploitant.Parcelles.Count.ToString() }, TypeParcelle);
                lvi.Tag = exploitant;
                lvi.ImageIndex = TypeExploitant;
                listView.Items.Add(lvi);

                toolStripProgressBar.Value++;
            }


        }
        private void ShowListViewParcelles(Exploitant exp)
        {
            currentType = TypeParcelle;
            
            toolStripLabel.Text = "Chargements des parcelles";
            // Affichage des parcelles dans le listView
            listView.Columns.Add("Description", 100);
            listView.Columns.Add("Emplacement", 100);
            listView.Columns.Add("Surface", 100);
            listView.Columns.Add("Traitements", 100);

            toolStripProgressBar.Maximum = exp.Parcelles.Count;
            foreach (Parcelle parcelle in exp.Parcelles)
            {
                ListViewItem lvi = new ListViewItem(new string[] { parcelle.Description, parcelle.Emplacement, parcelle.Surface.ToString(), parcelle.Traitements.Count.ToString() }, TypeParcelle);
                lvi.Tag = parcelle;
                lvi.ImageIndex = TypeParcelle;
                listView.Items.Add(lvi);

                toolStripProgressBar.Value++;
            }
        }
        private void ShowListViewTraitements(Parcelle p)
        {
            currentType = TypeTraitement;

            toolStripLabel.Text = "Chargements des traitements";
            // Affichage des traitements dans le listView
            listView.Columns.Add("Description", 100);
            listView.Columns.Add("Quantité appliquée", 100);
            listView.Columns.Add("Pulvérisations", 100);

            toolStripProgressBar.Maximum = p.Traitements.Count;
            foreach (TraitementPhytosanitaire t in p.Traitements)
            {
                int nbPulverisations = 0;
                if (t is TraitementEnChamp)
                    nbPulverisations = (t as TraitementEnChamp).Pulverisations.Count;

                ListViewItem lvi = new ListViewItem(new string[] { t.Description, Convert.ToString(t.QuantiteAppliquee()), nbPulverisations.ToString() }, TypeTraitement);
                lvi.Tag = t;
                lvi.ImageIndex = TypeTraitement;
                listView.Items.Add(lvi);

                toolStripProgressBar.Value++;
            }
        }
        private void ShowListViewPulverisations(TraitementPhytosanitaire tp)
        {
            currentType = TypePulverisation;

            toolStripLabel.Text = "Chargements des pulvérisations";
            // Affichage des traitements dans le listView

            if (tp is TraitementEnChamp)
            {
                TraitementEnChamp tec = (tp as TraitementEnChamp);

                listView.Columns.Add("Description", 100);
                listView.Columns.Add("Date", 100);
                toolStripProgressBar.Maximum = tec.Pulverisations.Count;

                foreach (Pulverisation pu in tec.Pulverisations)
                {
                    ListViewItem lvi = new ListViewItem(new string[] { pu.Description, pu.DatePulverisation.ToShortDateString() }, TypePulverisation);
                    lvi.Tag = pu;
                    lvi.ImageIndex = TypePulverisation;
                    listView.Items.Add(lvi);

                    toolStripProgressBar.Value++;
                }
            }
            else
            {
                listView.Columns.Add("Informations", 400);
                listView.Items.Add("Ce traitement ne gère pas les pulvérisations");
            }
        }
        #endregion


    }
}
