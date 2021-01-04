using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccess
{
    public class MetropolitanCitiesDAO
    {
        public static DataSet getAllMetropolitanCitiesUsingDBConfig()
        {

            SqlConnection sqlConnection;
            String sql = null;
            SqlCommand sqlCommand;
            SqlDataReader sqlDataReader;

            DataTable dataTable = new DataTable();
            DataSet dsGetListOfMetroloittanCities = new DataSet();

            var connectionString = ConfigurationManager.ConnectionStrings["MetropolitanCities_DB"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            sql = "Select * from metropolitan_city";

            sqlConnection.Open();
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);
            dsGetListOfMetroloittanCities.Tables.Add(dataTable);
            sqlDataReader.Close();
            sqlCommand.Dispose();
            sqlConnection.Close();

            return dsGetListOfMetroloittanCities;
        }
    }
}
