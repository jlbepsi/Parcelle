using System;
using System.Collections.Generic;
using System.Text;

using ParcelleLibraryJSON;

namespace ParcelleLibraryJSON.Gestions
{
    public class GestionParcelles
    {
        #region Attributs
        private List<Parcelle> liste = new List<Parcelle>();
        #endregion

        public List<Parcelle> Parcelles
        {
            get { return liste; }
            //set { liste = value; }
        }

        #region Méthodes CRUD
        // Ajouter, lire, modifier, supprimer

        public void Ajouter(Parcelle p)
        {
            liste.Add(p);
        }

        public void Supprimer(int id)
        {
            foreach (Parcelle p in liste)
            {
                if (p.Id == id)
                {
                    liste.Remove(p);
                    return;
                }
            }
        }

        public Parcelle GetParcelle(int id)
        {
            return liste.Find(
                delegate(Parcelle p)
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
