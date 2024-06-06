﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Coffee
    {
        public abstract string GetDescription();
        public abstract double GetCost();
    }
}
