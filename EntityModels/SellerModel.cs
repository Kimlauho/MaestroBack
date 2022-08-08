using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class SellerModel
    {
        public int? code { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string document { get; set; }
        public int? cityId { get; set; }
        public string nameCity { get; set; }
        public string nota { get; set; }
    }

    
}
