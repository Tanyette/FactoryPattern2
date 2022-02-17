using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern2
{
    
     public class ListDataAccess : IDataAccess
     {
        public ListDataAccess() 
        { 
        }


        public static List<Product> Products = new List<Product>()
        {
            new Product() { name = "Pogo stick", Price = 25.00},
            new Product() { name = "Skateboard", Price = 35.00}
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from your list");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine(" I am saving data to your {GetType().Name}");
                
        }
    }
}


