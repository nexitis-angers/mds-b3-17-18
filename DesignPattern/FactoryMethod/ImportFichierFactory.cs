using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    public class ImportFichierFactory : Factory
    {
        public override TraitementAbstrait InstancierMoteurTraitement(string cheminFichier)
        {
            switch (Path.GetExtension(cheminFichier))
            {
                case ".json":
                    return new ImportFichierJSON(cheminFichier);
                case ".csv":
                    return new ImportFichierCSV(cheminFichier);
                case ".xml":
                    return new ImportFichierXML(cheminFichier);
                default:
                    throw new SystemException($"Aucun moteur d'import n'est à instancier pour le fichier d'extension {Path.GetExtension(cheminFichier)}.");
            }
        }
    }
}
