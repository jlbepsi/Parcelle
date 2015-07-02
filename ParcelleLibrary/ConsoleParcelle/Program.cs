using System;
using System.Collections.Generic;

using LibraryUtilitaires;
using ParcelleLibraryJSON;
using ParcelleLibraryJSON.Gestions;

namespace ConsoleParcelle
{
    class Program
    {
        static void TestXML()
        {
            GestionExploitants gestion = new GestionExploitants();
            // Remplissage avec des valeurs quelconques
            gestion.InitializeDummyData();

            // Test sauvegarde JSON
            gestion.SerializeToJSON();
        }

        static void TestJSON()
        {
            GestionExploitants gestion = new GestionExploitants();
            gestion.ConfigFile = @"D:\Temp\parcelles.config";
            // Remplissage avec des valeurs quelconques
            gestion.InitializeDummyData();

            // Test sauvegarde JSON
            gestion.SerializeToJSON();

            //gestion.DeserializeFromJSON();
        }

        static void Main(string[] args)
        {
            TestJSON();
        }
    }
}
