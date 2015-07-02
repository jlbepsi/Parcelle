using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelleLibraryJSON
{
    public class CategorieProduit
    {
        private int id;

        public int Id
        {
            get { return id; }
        }

        public string Libelle { get; set; }

        public CategorieProduit(int id, string libelle)
        {
            this.id = id;
            this.Libelle = libelle;
        }
    }
}
