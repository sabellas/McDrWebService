using McDrWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace McDrWebService.Controllers
{
    public class McDrController : ApiController
    {

        // GET: api/pacientes
        [Route("api/pacientes")]
        public HttpResponseMessage Get()
        {
            var pacientes = McDrRepository.GetAllPacientes();
            foreach (var _paciente in pacientes)
            {
                _paciente.all = false;
            }
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, pacientes);
            return response;
        }

        // GET: api/pacientes
        [Route("api/pacientesAll")]
        public HttpResponseMessage GetAll()
        {
            var pacientes = McDrRepository.GetAllPacientes();
            foreach (var _paciente in pacientes)
            {
                _paciente.all = true;
            }
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, pacientes);
            return response;
        }

        // GET: api/medicos
        [Route("api/medicos")]
        public HttpResponseMessage GetMedicos()
        {
            var medicos = McDrRepository.GetAllMedicos();
            foreach (var _medico in medicos)
            {
                _medico.all = false;
            }
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, medicos);
            return response;
        }

        // GET: api/medicos
        [Route("api/medicosAll")]
        public HttpResponseMessage GetAllMedicos()
        {
            var medicos = McDrRepository.GetAllMedicos();
            foreach (var _medico in medicos)
            {
                _medico.all = true;
            }
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, medicos);
            return response;
        }
        // GET: api/citas
        [Route("api/citas")]
        public HttpResponseMessage GetCitas()
        {
            var citas = McDrRepository.GetAllCitas();
            foreach (var _cita in citas)
            {
                _cita.all = false;
            }
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, citas);
            return response;
        }
        // GET: api/citas
        [Route("api/citasAll")]
        public HttpResponseMessage GetAllCitas()
        {
            var citas = McDrRepository.GetAllCitas();
            foreach (var _cita in citas)
            {
                _cita.all = true;
            }
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, citas);
            return response;
        }

        [Route("api/pacientes/{name:alpha}")]
        public HttpResponseMessage GetPacientes(string name)
        {
            var pacientes = McDrRepository.SearchPacientesByName(name);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, pacientes);
            return response;
        }

        [Route("api/medicos/{name:alpha}")]
        public HttpResponseMessage GetMedicos(string name)
        {
            var medicos = McDrRepository.SearchMedicosByName(name);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, medicos);
            return response;
        }

        // PUT: api/pacientes/5
        public HttpResponseMessage Put(int id, [FromBody]paciente val)
        {
            var paciente = McDrRepository.UpdatePaciente(id, val);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, paciente);
            return response;
        }
    }
}
