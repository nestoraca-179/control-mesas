using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlMesas.Models
{
    public class ControlMesasResponse
    {
        public string Estatus { get; set; }
        public object Resultado { get; set; }
        public string Mensaje { get; set; }
    }
}