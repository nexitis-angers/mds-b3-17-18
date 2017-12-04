using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory.LieuRoulage
{
    public class AbstractLieuRoulage
    {
        public override string ToString()
        {
            return $"Je roule sur des {this.GetType().Name.ToLower()}";
        }
    }
}
