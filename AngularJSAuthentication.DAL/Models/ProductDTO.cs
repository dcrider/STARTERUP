using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularJSAuthentication.DAL.Models
{
    public class ProductDTO
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public bool OnSale { get; set; }
        public int SupplierID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int AccountID { get; set; }
        public int CategoryID { get; set; }
        public bool IsActive { get; set; }
        public decimal Price { get; set; }
        public decimal SalePrice { get; set; }
        public string Description { get; set; }
    }
}
