using KazanTestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KazanTestAPI.Controllers
{
    public class DepartmentoController : ApiController
    {
        Session1Entities bd = new Session1Entities();

        // GET: api/Departmento
        public List<Departments> Get()
        {
            return bd.Departments.ToList();
        }

        // GET: api/Departmento/5
        public Departments Get(int id)
        {
            return bd.Departments.Find(id);
        }

        // POST: api/Departmento
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Departmento/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Departmento/5
        public void Delete(int id)
        {
        }
    }
}
