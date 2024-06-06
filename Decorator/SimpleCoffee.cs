using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SimpleCoffee : Coffee
    {
        public override string GetDescription()
        {
            return "Prosta kawa";
        }

        public override double GetCost()
        {
            return 5.0; // podstawowa cena kawy
        }
    }
}
