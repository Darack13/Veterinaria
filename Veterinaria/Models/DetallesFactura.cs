//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Veterinaria.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetallesFactura
    {
        public int id_detalle { get; set; }
        public int id_factura { get; set; }
        public int id_servicio { get; set; }
        public int cantidad { get; set; }
        public decimal precio_unitario { get; set; }
    
        public virtual Factura Factura { get; set; }
        public virtual Servicio Servicio { get; set; }
    }
}
