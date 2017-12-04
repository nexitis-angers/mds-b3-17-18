using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory.Carosserie
{
    public class CarosseMotoRoute : AbstractCarosserie
    {
        public CarosseMotoRoute() : base(true,true, true)
        {
        }
    }
}
