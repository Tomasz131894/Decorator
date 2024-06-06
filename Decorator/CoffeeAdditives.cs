using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(Coffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + ", Cukier";
        }

        public override double GetCost()
        {
            return _coffee.GetCost() + 0.5;
        }
    }

    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(Coffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + ", Mleko";
        }

        public override double GetCost()
        {
            return _coffee.GetCost() + 1.5;
        }
    }

    public class ChocolateDecorator : CoffeeDecorator
    {
        public ChocolateDecorator(Coffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + ", Czekolada";
        }

        public override double GetCost()
        {
            return _coffee.GetCost() + 2.0;
        }
    }
}
