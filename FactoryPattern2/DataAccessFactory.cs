using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern2
{

    static class DataAccessFactory
    {


        public static IDataAccess GetDataAccess(string databaseType)
        {

            switch (databaseType.ToLower())
            {
                case "list":
                    return new ListDataAccess();
                case "sql":
                    return new SQLDataAccess();
                case "mongo":
                case "mongodb":
                    return new MongoDataAccess();
                default:
                    return new ListDataAccess();
            }



        }
    }
}
