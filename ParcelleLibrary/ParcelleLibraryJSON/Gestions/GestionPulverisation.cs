using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelleLibraryJSON.Gestions
{
    public class GestionPulverisation
    {
        #region Attributs
        private List<Pulverisation> liste = new List<Pulverisation>();
        #endregion

        public List<Pulverisation> Pulverisations
        {
            get { return liste; }
            set { liste = value; }
        }

        #region Méthodes CRUD
        // Ajouter, lire, modifier, supprimer

        public void Ajouter(Pulverisation p)
        {
            liste.Add(p);
        }

        public void Supprimer(int id)
        {
            foreach (Pulverisation p in liste)
            {
                if (p.Id == id)
                {
                    liste.Remove(p);
                    return;
                }
            }
        }

        public Pulverisation GetTraitement(int id)
        {
            return liste.Find(
                delegate(Pulverisation p)
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
