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
    public static class Categories
    {

        public static List<CategoryDTO> MapEntity(List<AngularJSAuthentication.EDMX.Categories> data)
        {
            if (data == null) return null;

            var result = new List<CategoryDTO>();
            data.ForEach( o => 
            {
                var r = MapEntity(o);

                result.Add(r);

            });

            return result;
        }

        public static CategoryDTO MapEntity(AngularJSAuthentication.EDMX.Categories data)
        {
            if (data == null) return null;

            var result = new CategoryDTO()
            {
                CategoryID = data.CategoryID,
                CategoryName = data.CategoryName,
                IsActive = data.IsActive,
                DateCreated = data.DateCreated,
                Description = data.Description
            };

            return result;
        }

        public static List<CategoryDTO> getCategories(int id) {

            using (StarterUpEntities db = new StarterUpEntities())
            {
                var result = db.Categories.Where(o => o.CategoryID == id).ToList();
                return MapEntity(result);
            }
        }
    }
}
