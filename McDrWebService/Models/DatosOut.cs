using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace McDrWebService.Models
{
    public class DatosOut
    {
        public List<cita> citas { get; set; }

        public DatosOut(Boolean n)
        {
            this.citas = McDrRepository.GetAllCitas();
            foreach (var cita in citas)
            {
                cita.all = n;
            }
        }
    }
}