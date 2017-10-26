using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiereApplication.Exceptions
{
    public class HighPowerException : Exception 
    {
        public HighPowerException(int puissance) : base($"La puissance {puissance} cv est supérieure à 106 cv.")
        {
        }
    }
}
