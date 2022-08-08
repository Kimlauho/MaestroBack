using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.DataManagers
{
    public class CityManager
    {
        public static List<CityModel> GetCities()
        {
            try
            {
                using (MaestroEntities db = new MaestroEntities())
                {
                    return db.sp_GetCities().AsEnumerable().Select(x => new CityModel()
                    {
                        code = x.CODE,
                        description = x.DESCRIPTION
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static CityModel CreateEditCity(CityModel c)
        {
            try
            {
                using (MaestroEntities db = new MaestroEntities())
                {
                    return db.sp_CreateEditCity(c.code, c.description).AsEnumerable().Select(x => new CityModel()
                    {
                        code = x.CODE,
                        description = x.DESCRIPTION
                    }).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static CityModel DeleteCity(int code)
        {
            try
            {
                using (MaestroEntities db = new MaestroEntities())
                {
                    return db.sp_DeleteCity(code).AsEnumerable().Select(x => new CityModel()
                    {
                        nota = x.NOTA
                    }).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
