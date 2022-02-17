using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern2
{
    interface IDataAccess
    {


        public void SaveData();

        public List<Product> LoadData();

    }
}
