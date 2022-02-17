using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern2
{
    public class MongoDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I'm reading data from Mongo database");

            return ListDataAccess. Products;
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data to your {GetType().Name} database");
        }
    }
}

