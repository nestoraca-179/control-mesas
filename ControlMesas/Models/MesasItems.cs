//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlMesas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MesasItems
    {
        public int IDMesaItem { get; set; }
        public Nullable<int> IDMesa { get; set; }
        public Nullable<int> IDArticulo { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<double> TotalArticulo { get; set; }
        public Nullable<int> IDUsuario { get; set; }
        public Nullable<System.DateTime> FechaHora { get; set; }
    }
}
