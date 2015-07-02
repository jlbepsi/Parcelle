using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ParcelleLibraryJSON
{
    public class Pulverisation
    {
        #region Attributs
        private int id;
        private double dosage;
        #endregion

        #region Propriétés
        public int Id
        {
            get { return id; }
        }
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
        public DateTime DatePulverisation { get; set; }
        public string Description { get; set; }

       // [JsonIgnore]
        public TraitementEnChamp Traitement { get; set; }
        #endregion

        public Pulverisation(int id)
        {
            this.id = id;
        }
    }
}
