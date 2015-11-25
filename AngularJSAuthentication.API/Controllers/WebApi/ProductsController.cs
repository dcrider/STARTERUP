using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;
using AngularJSAuthentication.DAL;

namespace AngularJSAuthentication.API.Controllers
{
    public class ProductsController : ApiController
    {
        [HttpGet, Route("get/{id}")]
        public IHttpActionResult Get(int id)
        {
            var result = Products.getProducts(id);
            return Ok(result);
        }

        [HttpGet, Route("getAll")]
        public IHttpActionResult GetAll()
        {
            var result = Products.getAllProducts();
            return Ok(result);
        }
    }
}
