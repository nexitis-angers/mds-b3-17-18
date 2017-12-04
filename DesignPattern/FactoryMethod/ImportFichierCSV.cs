using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    public class ImportFichierCSV : TraitementAbstrait
    {
        public ImportFichierCSV(string cheminFichier) : base(cheminFichier)
        {

        }

        public override void Execute()
        {
            Console.WriteLine($"On importe un fichier de type CSV {Path.GetFileName(CheminFichier)}");
        }

    }
}
