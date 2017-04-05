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
    
    public partial class medico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public medico()
        {
            this.citas = new HashSet<cita>();
        }
    
        public int id { get; set; }
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public int especialidad { get; set; }
        public Nullable<System.DateTime> fechaNacimiento { get; set; }
        public System.DateTime fechaAlta { get; set; }
        public Nullable<System.DateTime> fechaBaja { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cita> citas { get; set; }
        public virtual especialidad especialidad1 { get; set; }
        public virtual bool all { get; set; }
        public Boolean ShouldSerializemedico()
        {
            return all;
        }
        public Boolean ShouldSerializepaciente()
        {
            return all;
        }
    }
}
