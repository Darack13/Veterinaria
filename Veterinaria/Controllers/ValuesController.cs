using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Veterinaria.Clases;
using Veterinaria.Models;

namespace Veterinaria.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [HttpGet]
        public List<Raza> ConsultarRazas()
        {
            clsRaza _raza = new clsRaza();
            return _raza.GetRazas();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
