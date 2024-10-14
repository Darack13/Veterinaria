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
    [RoutePrefix("api/Raza")]
    public class RazaController : ApiController
    {

        [HttpGet]
        [Route("ConsultarRaza")]
        public Raza ConsultarRaza(int IdRaza)
        {
            clsRaza _raza = new clsRaza();
            return _raza.GetRazaByID(IdRaza);
        }


        [HttpGet]
        [Route("ConsultarRazas")]
        public List<Raza> ConsultarRazas()
        {
            clsRaza _raza = new clsRaza();
            return _raza.GetRazas();
        }


        [HttpGet]
        [Route("ConsultarRazasPorEspecie")]
        public List<Raza> ConsultarRazasPorEspecie(int IdEspecie)
        {
            clsRaza _raza = new clsRaza();
            return _raza.GetRazasBySpecy(IdEspecie);
        }


        [HttpPost]
        [Route("AgregarRaza")]
        public string InsertarRaza([FromBody] Raza DataRaza)
        {
            clsRaza _raza = new clsRaza();
            _raza.raza = DataRaza; 

            return _raza.InsertRaza();
        }


        [HttpDelete]
        [Route("EliminarRaza")]
        public string EliminarRaza([FromBody] Raza DataRaza)
        {
            clsRaza _raza = new clsRaza();
            _raza.raza = DataRaza;

            return _raza.DeleteRaza(); 
        }


        [HttpPut]
        [Route("ActualizarRaza")]
        public string ActualizarRaza([FromBody] Raza DataRaza)
        {
            clsRaza _raza = new clsRaza();
            _raza.raza = DataRaza;

            return _raza.UpdateRaza();
        }

    }
}
