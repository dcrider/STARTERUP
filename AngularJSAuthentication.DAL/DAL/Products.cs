using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using AngularJSAuthentication.EDMX;
using AngularJSAuthentication.DAL.Models;

namespace AngularJSAuthentication.DAL
{
    public static class Products
    {

        public static List<ProductDTO> MapEntity(List<AngularJSAuthentication.EDMX.Products> data)
        {
            if (data == null) return null;

            var result = new List<ProductDTO>();
            data.ForEach(o =>
            {
                var r = MapEntity(o);

                result.Add(r);

            });

            return result;
        }

        public static ProductDTO MapEntity(AngularJSAuthentication.EDMX.Products data)
        {
            if (data == null) return null;

            var result = new ProductDTO()
            {
                ProductID = data.ProductID,
                ProductName = data.ProductName,
                OnSale = data.OnSale,
                SupplierID = (int)data.SupplierID,
                DateCreated = data.DateCreated,
                AccountID = data.AccountID,
                CategoryID = data.CategoryID,
                IsActive = data.IsActive,
                Price = (decimal)data.Price,
                SalePrice = (decimal)data.SalePrice,
                Description = data.Description

            };

            return result;
        }

        public static List<ProductDTO> getProducts (int id) 
        {
            using (StarterUpEntities db = new StarterUpEntities())
            {
                var result = db.Products.Where(o => o.ProductID == id).ToList();
                return MapEntity(result);
            }
        }

        public static List<ProductDTO> getAllProducts()
        {
            using (StarterUpEntities db = new StarterUpEntities())
            {
                var result = db.Products.ToList();
                return MapEntity(result);
            }
        }
    }
}
