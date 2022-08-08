using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.DataManagers
{
    public class SellerManager
    {
        public static List<SellerModel> GetSellers(int code)
        {
            try
            {
                using (MaestroEntities db = new MaestroEntities())
                {
                    return db.sp_GetSellers(code).AsEnumerable().Select(x => new SellerModel()
                    {
                        code = x.CODE,
                        name = x.NAME,
                        lastName = x.LAST_NAME,
                        document = x.DOCUMENT,
                        cityId = x.CITY_ID,
                        nameCity = x.DESCRIPTION
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static SellerModel CreateEditSeller(SellerModel s)
        {
            try
            {
                using (MaestroEntities db = new MaestroEntities())
                {
                    return db.sp_CreateEditSeller(s.code, s.name, s.lastName, s.document, s.cityId).AsEnumerable().Select(x => new SellerModel()
                    {
                        code = x.CODE,
                        name = x.NAME,
                        lastName = x.LAST_NAME,
                        document = x.DOCUMENT,
                        cityId = x.CITY_ID,
                    }).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static SellerModel DeleteSeller(int code)
        {
            try
            {
                using (MaestroEntities db = new MaestroEntities())
                {
                    return db.sp_DeleteSeller(code).AsEnumerable().Select(x => new SellerModel()
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
