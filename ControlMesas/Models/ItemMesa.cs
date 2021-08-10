using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlMesas.Models
{
    public class ItemMesa
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
    }
}