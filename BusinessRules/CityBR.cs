using DataModels.DataManagers;
using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRules
{
    public class CityBR
    {
        public static List<CityModel> GetCities()
        {
            return CityManager.GetCities();
        }

        public static CityModel CreateEditCity(CityModel city)
        {
            return CityManager.CreateEditCity(city);
        }

        public static CityModel DeleteCity(int code)
        {
            return CityManager.DeleteCity(code);
        }
    }
}
