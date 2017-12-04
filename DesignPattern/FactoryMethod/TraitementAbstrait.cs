using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    public abstract class TraitementAbstrait
    {
        /// <summary>
        /// Chemin du fichier à traiter
        /// </summary>
        public string CheminFichier { get; private set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="cheminFichier">chemin du fichier à traiter</param>
        public TraitementAbstrait(string cheminFichier)
        {
            this.CheminFichier = cheminFichier;
        }

        /// <summary>
        /// Traitement à définir dans la classe fille
        /// </summary>
        public abstract void Execute();
    }
}
