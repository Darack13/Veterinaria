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
    [RoutePrefix("api/Paciente")]
    public class PacienteController : ApiController
    {

        [HttpGet]
        [Route("ConsultarPaciente")]
        public Paciente ConsultarPaciente(int IdPaciente)
        {
            clsPacientes _paciente = new clsPacientes();
            return _paciente.GetPacienteByID(IdPaciente);
        }


        [HttpGet]
        [Route("ConsultarPacientes")]
        public List<Paciente> ConsultarPacientes()
        {
            clsPacientes new clsPacientes();
            return _paciente.GetPacientes();
        }


        [HttpPost]
        [Route("AgregarPaciente")]
        public string InsertarPaciente([FromBody] Paciente DataPaciente)
        {
            clsPacientes _paciente = new clsPacientes();
            _paciente.paciente = DataPaciente; 

            return _paciente.InsertPaciente();
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
