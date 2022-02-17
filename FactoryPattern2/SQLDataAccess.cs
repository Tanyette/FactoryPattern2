using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern2
{
    public class SQLDataAccess : IDataAccess
    {


        public List<Product> LoadData() 
        {
            Console.WriteLine("I am reading data from your SQL database");
            return ListDataAccess.Products;
        } 

                   
             
        
        public void SaveData()
        {
            Console.WriteLine("I am saving data to your {GetType().Name}database");
        }
    }
}
