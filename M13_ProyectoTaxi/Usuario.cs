//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace M13_ProyectoTaxi
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string telefono { get; set; }
        public string dni { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> fechaNacimiento { get; set; }
        public Nullable<decimal> horaEntrada { get; set; }
        public Nullable<decimal> horaSalida { get; set; }
    }
}
