using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelleLibraryJSON
{
    public class ProduitPhytosanitaire
    {
        private int id;
        private double qtePreconise;
        private string unite;
        private string format;

        public int Id
        {
            get { return id; }
        }

        public string Libelle { get; set; }

        public string Commentaire { get; set; }

        public double QtePreconise
        {
            get { return qtePreconise; }
            set { qtePreconise = value; }
        }
        public double Unite
        {
            get { return qtePreconise; }
            set { qtePreconise = value; }
        }
        public double Format
        {
            get { return qtePreconise; }
            set { qtePreconise = value; }
        }


        public ProduitPhytosanitaire()
        {
        }

        public CategorieProduit categorieProduit;
    }
}
