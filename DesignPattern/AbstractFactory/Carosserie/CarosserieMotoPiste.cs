using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory.Carosserie
{
    public class CarosserieMotoPiste : AbstractCarosserie
    {
        public CarosserieMotoPiste() : base(true, false, true)
        {
        }
    }
}
