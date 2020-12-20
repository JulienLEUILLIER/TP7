using System;
using System.Collections.Generic;
using System.Text;
using TP7;

namespace TestsUnitaires.GenerationDeDonnees
{
    internal static class Products
    {
        internal static Product Water()
        {
            return new Beverage("Water", 0.5m, 0.75m, 1.0m);
        }

        internal static Product Chips()
        {
            return new Food("Chips", 0.75m, 1.0m, 1.25m);
        }

        internal static Product Beer()
        {
            return new AlcoholicBeverage("Beer", 2.0m, 3.0m, 4.0m, 5.2f);
        }
    }
}
