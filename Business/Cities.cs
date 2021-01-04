using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DataAccess;
using System.Data;

namespace Business
{
    public class Cities
    {
        public static List<MetropolitanCity> getAllMetropolitanCities()
        {
            MetropolitanCity metropolitanCity = new MetropolitanCity();
            var metropolitanCitiesList = new List<MetropolitanCity>();
            DataSet dsMetropolitanCities = new DataSet();
            dsMetropolitanCities = MetropolitanCitiesDAO.getAllMetropolitanCitiesUsingDBConfig();

            if (dsMetropolitanCities.Tables.Count > 0)
            {
                metropolitanCitiesList = dsMetropolitanCities.Tables[0].AsEnumerable().Select(sqlrow => new MetropolitanCity
                {
                    Name = Convert.ToString(sqlrow["name"]),
                    Country=Convert.ToString(sqlrow["country"]),
                    Population = Convert.ToInt64(sqlrow["population"]),
                    Area = Convert.ToInt64(sqlrow["area"])
                }).ToList();
            }

            return metropolitanCitiesList;
        }
    }
}
