using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccesoDatos;
using Logica;

namespace ServicioRestHospital.Controllers
{
    public class HospitalController : ApiController
    {
        logicaHospital lh = new logicaHospital();
        // GET: api/Hospital
        public List<Hospital> Get()
        {
            return lh.seleccionarHospitales();
        }

        // GET: api/Hospital/5
        public Hospital Get(int id)
        {
            return lh.seleccionarHospital(id);
        }

        // POST: api/Hospital
        public int Post([FromBody]Hospital nuevoHospital)
        {
            return lh.insertarHos(nuevoHospital);

        }

        // PUT: api/Hospital/5
        public bool Put(int id, [FromBody]Hospital hospitalModificado)
        {
            return lh.actualizarHos(hospitalModificado);
        }

        // DELETE: api/Hospital/5
        public bool Delete(int id)
        {
            return lh.eliminarHos(id);
        }
    }
}
