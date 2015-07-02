using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelleLibraryJSON.Gestions
{
    public class GestionTraitementPhytosanitaire
    {
        #region Attributs
        private List<TraitementPhytosanitaire> liste = new List<TraitementPhytosanitaire>();
        #endregion

        public List<TraitementPhytosanitaire> Traitements
        {
            get { return liste; }
            set { liste = value; }
        }

        #region Méthodes CRUD
        // Ajouter, lire, modifier, supprimer

        public void Ajouter(TraitementPhytosanitaire p)
        {
            liste.Add(p);
        }

        public void Supprimer(int id)
        {
            foreach (TraitementPhytosanitaire p in liste)
            {
                if (p.Id == id)
                {
                    liste.Remove(p);
                    return;
                }
            }
        }

        public TraitementPhytosanitaire GetTraitement(int id)
        {
            return liste.Find(
                delegate(TraitementPhytosanitaire p)
                {
                    return p.Id == id;
                }
            );
        }
        #endregion

        #region Méthodes Lecture/Ecriture sur fichier
        #endregion
    }
}
