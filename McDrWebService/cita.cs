//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace McDrWebService
{
    using System;
    using System.Collections.Generic;
    
    public partial class cita
    {
        public System.DateTime fecha_Hora { get; set; }
        public int Medico_id { get; set; }
        public int Paciente_id { get; set; }
    
        public virtual medico medico { get; set; }
        public virtual paciente paciente { get; set; }
    }
}
