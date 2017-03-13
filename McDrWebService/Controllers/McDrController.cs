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

    }
}
