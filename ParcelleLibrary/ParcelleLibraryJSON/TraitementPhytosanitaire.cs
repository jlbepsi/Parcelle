using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ParcelleLibraryJSON
{
    public abstract class TraitementPhytosanitaire
    {
        #region Attributs
        private int id;
        #endregion

        #region Propriétés
        public int Id
        {
            get { return id; }
        }
        public string Description { get; set; }

        public Parcelle Parcelle { get; set; }

        #endregion

        public TraitementPhytosanitaire(int id)
        {
            this.id = id;
        }

        public abstract double QuantiteAppliquee();

        public abstract void ResolveReferences();
    }
}
