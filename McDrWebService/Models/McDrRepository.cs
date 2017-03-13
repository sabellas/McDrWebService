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
        public static List<medico> GetAllMedicos() {
            var query = from c in db.medicos
                        select c;
            return query.ToList();
        }
        public static List<cita> GetAllCitas()
        {
            var query = from c in db.citas
                        select c;
            return query.ToList();
        }
        public static List<paciente> SearchPacientesByName(string pacienteName)
        {
            var query = from c in db.pacientes
                        where (c.nombre.Contains(pacienteName) || c.apellidos.Contains(pacienteName))
                        select c;
            return query.ToList();
        }
        public static List<medico> SearchMedicosByName(string medicoName)
        {
            var query = from c in db.medicos
                        where (c.nombre.Contains(medicoName) || c.apellidos.Contains(medicoName))
                        select c;
            return query.ToList();
        }
        public static paciente GetPaciente(int pacienteID)
        {
            var query = from c in db.pacientes
                        where c.id == pacienteID
                        select c;
            return query.SingleOrDefault();
        }
        public static paciente InsertPaciente(paciente c)
        {
            try
            {
                db.pacientes.Add(c);
                db.SaveChanges();
                return GetPaciente(c.id);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static paciente UpdatePaciente(int id, paciente c)
        {
            paciente c0;
            try
            {
                var query = from cAux in db.pacientes
                            where cAux.id == id
                            select cAux;
                c0 = query.SingleOrDefault();
                if (c.nombre != null) c0.nombre = c.nombre;
                if (c.apellidos != null) c0.apellidos = c.apellidos;

                db.SaveChanges();
                return GetPaciente(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void DeletePaciente(int id)
        {
            var query = from c in db.pacientes
                        where c.id == id
                        select c;
            paciente q = query.SingleOrDefault();
            if (q != null)
            {
                db.pacientes.Remove(q);
                db.SaveChanges();
            }
        }
    }
}