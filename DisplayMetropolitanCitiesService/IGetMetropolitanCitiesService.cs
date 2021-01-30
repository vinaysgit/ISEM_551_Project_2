using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DisplayMetropolitanCitiesService
{
    [ServiceContract]
    public interface IGetMetropolitanCitiesService
    {
        [OperationContract]
        DataSet GetMetropolitanCities();

    }
}
