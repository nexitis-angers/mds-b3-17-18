using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    public abstract class Factory
    {
        /// <summary>
        /// Instancie le bon moteur de traitement
        /// </summary>
        /// <param name="cheminFichier">Fichier à traiter</param>
        /// <exception cref="SystemException">Exception déclenchée si le format du fichier d'entrée n'est pas correct</exception>
        /// <returns>L'instance du moteur de traitement qui correspond au fichier d'entrée</returns>
        public abstract TraitementAbstrait InstancierMoteurTraitement(string cheminFichier);
    }
}
