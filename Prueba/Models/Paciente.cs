using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Prueba.Models;

namespace Prueba.Models
{
    public class Paciente
    {
        public int idPaciente { get; set; }
        public string Documento { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}