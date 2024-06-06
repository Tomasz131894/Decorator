using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class CoffeeDecorator : Coffee
    {
        protected Coffee _coffee;

        public CoffeeDecorator(Coffee coffee)
        {
            _coffee = coffee;
        }

        public override string GetDescription()
        {
            return _coffee.GetDescription();
        }

        public override double GetCost()
        {
            return _coffee.GetCost();
        }
    }
}
