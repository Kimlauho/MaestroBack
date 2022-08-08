using DataModels.DataManagers;
using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRules
{
    public class SellerBR
    {
        public static List<SellerModel> GetSellers(int code)
        {
            return SellerManager.GetSellers(code);
        }

        public static SellerModel CreateEditSeller(SellerModel seller)
        {
            return SellerManager.CreateEditSeller(seller);
        }

        public static SellerModel DeleteSeller(int code)
        {
            return SellerManager.DeleteSeller(code);
        }
    }
}
