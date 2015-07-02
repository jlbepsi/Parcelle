using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelleLibraryJSON
{
    public class EspeceCultivee
    {
        #region Attributs
        private int id;
        private string libelle;
        private string categorie;
        #endregion

        #region Propriétés
        public int Id
        {
            get { return id; }
        }
        public string Libelle
        {
            get { return libelle; }
        }
        public string Categorie
        {
            get { return categorie; }
        }
        #endregion

        public EspeceCultivee(int id, string libelle, string categorie)
        {
            this.id = id;
            this.libelle = libelle;
            this.categorie = categorie;
        }
    }
}
