using System;
using System.Collections.Generic;

namespace FactoryPattern2
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("What database would you like to create? List, SQL, Mongo?");
            var response = Console.ReadLine();


            var database = DataAccessFactory.GetDataAccesst(response);

            List<Product> products = database.LoadData();

            Console.WriteLine("Here are the items in your collection");


            foreach (var prod in products) 
            {
                Console.WriteLine($"Product Name: { prod.name}");
                Console.WriteLine($"Price: ${prod.Price}\n");
                database.SaveData();
            }

            database.SaveData();
        }

       
        
    }
}
