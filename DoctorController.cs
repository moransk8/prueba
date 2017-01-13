using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Logica;
using AccesoDatos;

namespace ServicioRestHospital.Controllers
{
    public class DoctorController : ApiController
    {
        logicaDoctor ld = new logicaDoctor();
        // GET: api/Doctor
        public List<Doctorcito> Get()
        {
            return ld.seleccionarDoctores();
        }

        // GET: api/Doctor/5
        public Doctorcito Get(string id)
        {
            return ld.seleccionarDoctor(id);
        }

        // POST: api/Doctor
        public string Post([FromBody]Doctorcito nuevoDoctor)
        {
            return ld.insertarDoc(nuevoDoctor);

        }

        // PUT: api/Doctor/5
        public bool Put(string id, [FromBody]Doctorcito doctorModificado)
        {
            return ld.actualizarDoc(doctorModificado);
        }

        // DELETE: api/Doctor/5
        public bool Delete(string id)
        {
            return ld.eliminarDoc(id);
        }
    }
}
