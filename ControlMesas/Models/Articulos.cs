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
    
    public partial class Articulos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Articulos()
        {
            this.MesasItems = new HashSet<MesasItems>();
        }
    
        public int ID { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> Stock { get; set; }
        public Nullable<double> Precio { get; set; }
        public Nullable<int> IDCategoria { get; set; }
        public Nullable<bool> Activo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MesasItems> MesasItems { get; set; }
    }
}
