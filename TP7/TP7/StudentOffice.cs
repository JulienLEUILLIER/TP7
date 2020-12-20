using System;
using System.Collections.Generic;
using System.Text;

namespace TP7
{
    public class StudentOffice
    {
        private static StudentOffice instance = new StudentOffice();

        static StudentOffice()
        { 
        }

        private StudentOffice()
        {
            _currentStock = new Stock();
        }

        public static StudentOffice Instance
        {
            get
            {
                return instance;
            }
        }

        public static void DestructStudentOffice()
        {
            instance = null;
        }

        public readonly Dictionary<Client, decimal> _ClientList = new Dictionary<Client, decimal>();

        public readonly Stock _currentStock;

        public decimal _currentBalance;

        public void AddClient(Client client, decimal balance)
        {
            
        }
    }
}
