using SecondeApplication.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondeApplication
{
    public static class CsvHelper
    {
        /// <summary>
        /// Lit le fichier de personnes dont le chemin est passé en paramètre
        /// </summary>
        /// <param name="path">Chemin du fichier</param>
        /// <exception cref="FileNotFoundException">Cette exception sera déclenchée si le fichier n'a pas été trouvé à l'emplacement spécifié</exception>
        /// <returns>Liste de personnes</returns>
        public static IEnumerable<Personne> LireFichier(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Le fichier n'existe pas à l'emplacement spécifié", path);

            // Collection de retour
            List<Personne> personnes = new List<Personne>();
            
            using (StreamReader sr = new StreamReader(path: path))
            {
                string ligne = null;
                int numeroLigne = 0;

                while ((ligne = sr.ReadLine()) != null)
                {
                    if(numeroLigne > 0)
                    {
                        string[] ligneDecoupee = ligne.Split(';');
                        Personne maPersonne = new Personne()
                        {
                            Nom = ligneDecoupee[0],
                            Prenom = ligneDecoupee[1],
                            Civilite = ligneDecoupee[2],
                            Adresse = ligneDecoupee[3],
                            CodePostal = ligneDecoupee[4],
                            Ville = ligneDecoupee[5],
                            Email = ligneDecoupee[6]
                        };
                        //maPersonne.Nom = ligneDecoupee[0];

                        // Ajout de la personne à la liste qui sera retournée à la fin de la méthode
                        personnes.Add(maPersonne);
                    }

                    numeroLigne++;
                }
            }
            
            return personnes;
        }
    }
}
