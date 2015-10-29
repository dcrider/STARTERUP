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
    [RoutePrefix("api/Categories")]
    public class CategoriesController : ApiController
    {
     //   [Authorize]
        [HttpGet, Route("get/{id}")]
        public IHttpActionResult Get(int id)
        {
            var result = Categories.getCategories(id);
            return Ok(result);
        }

    }
}