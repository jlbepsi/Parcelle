using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ParcelleLibraryJSON.Gestions;

namespace ParcelleLibraryJSON
{
    public class TraitementEnChamp : TraitementPhytosanitaire
    {
        #region Attributs
        private GestionPulverisation gestion = new GestionPulverisation();
        #endregion

        #region Propriétés
        public List<Pulverisation> Pulverisations
        {
            get { return gestion.Pulverisations; }
        }
        #endregion


        public TraitementEnChamp(int id)
            : base(id)
        {
        }

        public override double QuantiteAppliquee()
        {
            double quantite = 0;

            List<Pulverisation> liste = gestion.Pulverisations;
            foreach (Pulverisation p in liste)
            {
                quantite += (p.Dosage * Parcelle.Surface);
            }

            return quantite;
        }

        #region Gestion Pulverisation
        public void AjouterPulverisation(Pulverisation p)
        {
            p.Traitement = this;
            gestion.Ajouter(p);
        }
        public void SupprimerPulverisation(int num)
        {
            gestion.Supprimer(num);
        }
        public Pulverisation ObtenirPulverisation(int num)
        {
            return gestion.GetTraitement(num);
        }
        public List<Pulverisation> ObtenirPulverisations()
        {
            return gestion.Pulverisations;
        }

        #endregion

        public override void ResolveReferences()
        {
            foreach (Pulverisation p in gestion.Pulverisations)
            {
                p.Traitement = this;
            }
        }
    }
}
