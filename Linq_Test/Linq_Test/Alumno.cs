//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Linq_Test
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alumno
    {
        public string rut { get; set; }
        public string ap_paterno { get; set; }
        public string ap_materno { get; set; }
        public string nombres { get; set; }
        public int genero { get; set; }
        public string direccion { get; set; }
        public int ciudad { get; set; }
    
        public virtual Ciudad Ciudad1 { get; set; }
        public virtual Genero Genero1 { get; set; }
    }
}