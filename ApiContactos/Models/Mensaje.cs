//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiContactos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mensaje
    {
        public int id { get; set; }
        public int idOrigen { get; set; }
        public int idDestino { get; set; }
        public string asunto { get; set; }
        public string contenido { get; set; }
        public bool leido { get; set; }
        public System.DateTime fecha { get; set; }
    
        public virtual Usuario Origen { get; set; }
        public virtual Usuario Destino { get; set; }
    }
}
