using System;
using System.Collections.Generic;
using System.Text;
using TP7;

namespace TestsUnitaires.GenerationDeDonnees
{
    internal static class Clients
    {
        public static Student John()
        {
            return new Student("Doe", "John", 30, 1985);
        }

        public static OtherClient Jane()
        {
            return new OtherClient("Doe", "Jane", 25);
        }

        public static Client Underage()
        {
            return new OtherClient("Thomson", "Timmy", 15);
        }
    }
}
