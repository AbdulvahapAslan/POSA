using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSA.Dto
{
    public class SaleProduct
    {
        public int ID { get; set; }
        public decimal SALEPRICE { get; set; }
        public string BARCODE { get; set; }
        public string NAME { get; set; }
    }
}
