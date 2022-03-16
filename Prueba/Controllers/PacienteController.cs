using Prueba.Funciones;
using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba.Controllers
{
    public class PacienteController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public bool Post([FromBody] Paciente res)
        {
            return FuncionesPaciente.RegistrarPaciente(res);
        }

        // PUT api/<controller>/5
        public bool Put([FromBody] Paciente res)
        {
            return FuncionesPaciente.ModificarPaciente(res);
        }

        // DELETE api/<controller>/5
        public bool Delete(int id)
        {
            return FuncionesPaciente.EliminarPaciente(id);
        }
    }
}