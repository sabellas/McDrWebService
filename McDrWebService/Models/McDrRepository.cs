using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace McDrWebService.Models
{
    public class McDrRepository
    {
        private static mcdrEntities db = new mcdrEntities();

        //Listar pacientes
        public static List<paciente> GetAllPacientes()
        {
            var query = from c in db.pacientes
                        select c;
            return query.ToList();
        }

    }
}