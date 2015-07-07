using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using ParcelleLibraryJSON.Gestions;

namespace ParcelleLibraryJSON
{
    public class Parcelle
    {
        #region Attributs
        private int id;
        private double surface;
        private GestionTraitementPhytosanitaire gestion = new GestionTraitementPhytosanitaire();

        #endregion

        #region Propriétés
        public int Id
        {
            get { return id; }
        }
        public double Surface
        {
            get { return surface; }
            set
            {
                if (value < 1)
                    throw new Exception("La surface d'une parcelle soit être supérieure à 1");
                else
                    surface = value;
            }
        }

        public string Description { get; set; }
        public string Emplacement { get; set; }
        public DateTime DateRecoltePrevue { get; set; }
        public DateTime DateSemis { get; set; }
        public double QuantiteRecoltee { get; set; }

        public EspeceCultivee Culture { get; set; }
        public Exploitant Exploitant { get; set; }


        public List<TraitementPhytosanitaire> Traitements
        {
            get { return gestion.Traitements; }
        }
        #endregion

        public Parcelle(int id, double surface, Exploitant ex)
        {
            this.id = id;
            this.surface = surface;
            this.Exploitant = ex;
        }

        #region Gestion parcelles
        public void AjouterTraitement(TraitementPhytosanitaire t)
        {
            t.Parcelle = this;
            gestion.Ajouter(t);
        }
        public void SupprimerTraitement(int num)
        {
            gestion.Supprimer(num);
        }
        public TraitementPhytosanitaire ObtenirTraitement(int num)
        {
            return gestion.GetTraitement(num);
        }
        public List<TraitementPhytosanitaire> ObtenirTraitements()
        {
            return gestion.Traitements;
        }

        #endregion

        public void ResolveReferences()
        {
            foreach (TraitementPhytosanitaire tp in gestion.Traitements)
            {
                tp.Parcelle = this;
                tp.ResolveReferences();
            }
        }

        /*public string Serialize()
        {
            string xml = "";
            xml += "<parcelle>";

            xml += string.Format("<id>{0}</id>", id);
            xml += string.Format("<surface>{0}</surface>", surface);

            xml += "</parcelle>";
            return xml;
        }*/
    }
}
