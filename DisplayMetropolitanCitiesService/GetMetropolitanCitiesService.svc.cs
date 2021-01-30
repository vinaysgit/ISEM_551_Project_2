using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DataAccess;

namespace DisplayMetropolitanCitiesService
{
    public class Service1 : IGetMetropolitanCitiesService
    {
       
        //Implementatin of the interface class.
        public DataSet GetMetropolitanCities()
        {
            Console.WriteLine("Printing from WCF Web Service");
            return MetropolitanCitiesDAO.getAllMetropolitanCitiesUsingDBConfig();
        }
    }
}
