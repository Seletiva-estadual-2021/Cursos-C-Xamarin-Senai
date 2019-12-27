using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KazanTestAPI.Models;

namespace KazanTestAPI.Controllers
{
    public class GrupoAtivosController : ApiController
    {
        Session1Entities bd = new Session1Entities();

        // GET: api/GrupoAtivos
        public List<AssetGroups> Get()
        {
            return bd.AssetGroups.ToList();
        }

        // GET: api/GrupoAtivos/5
        public AssetGroups Get(int id)
        {
            return bd.AssetGroups.Find(id);
        }

        // POST: api/GrupoAtivos
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/GrupoAtivos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/GrupoAtivos/5
        public void Delete(int id)
        {
        }
    }
}
