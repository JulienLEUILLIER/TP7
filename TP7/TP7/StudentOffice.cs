using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TP7
{
    public sealed class StudentOffice
    {
        //private static StudentOffice instance = new StudentOffice();

        //static StudentOffice()
        //{ 
        //}

        //private StudentOffice()
        //{
        //    _currentStock = new Stock();
        //}

        //public static StudentOffice Instance
        //{
        //    get
        //    {
        //        return instance;
        //    }
        //}

        //public static void DestructStudentOffice()
        //{
        //    instance = null;
        //}

        public readonly Dictionary<Client, decimal> _ClientList = new Dictionary<Client, decimal>();

        public readonly Stock _currentStock;

        public bool GetClientByName(string name)
        {
            return _ClientList.Any(KeyValuePair => KeyValuePair.Key.GetName().ToUpper().Equals(name.ToUpper()));
        }

        public void AddClient(Client client, decimal balance)
        {
            if (!GetClientByName(client.GetName()))
            {
                _ClientList.Add(client, balance);
            }
        }
    }
}
