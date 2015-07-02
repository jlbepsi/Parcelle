using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelleLibraryJSON
{
    public class TraitementSemence : TraitementPhytosanitaire
    {
        #region Attributs
        private double dosage;
        #endregion

        #region Propriétés
        public double Dosage
        {
            get { return dosage; }
            set
            {
                if (value < 1)
                    throw new Exception("La surface d'une parcelle soit être supérieure à 1");
                else
                    dosage = value;
            }
        }
        public DateTime DateTraitement { get; set; }
        #endregion

        public TraitementSemence(int id)
            : base (id)
        {
        }

        public override double QuantiteAppliquee()
        {
            return Parcelle.Surface * Dosage;
        }

        public override void ResolveReferences()
        {
        }
    }
}
