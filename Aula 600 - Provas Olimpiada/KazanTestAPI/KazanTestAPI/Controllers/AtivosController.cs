using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KazanTestAPI.Models;

namespace KazanTestAPI.Controllers
{
    public class AtivosController : ApiController
    {
        Session1Entities bd = new Session1Entities();

        // GET: api/Ativos
        public List<AssetsResult> Get()
        {
            var assts = from asset in bd.Assets
                        join dli in bd.DepartmentLocations on asset.DepartmentLocationID equals dli.ID
                        join dpt in bd.Departments on dli.DepartmentID equals dpt.ID
                        where asset.EmployeeID > 10
                        select new { asset.AssetSN, asset.AssetName, dpt.Name };

            return assts.AsEnumerable().Select(a => new AssetsResult(a.AssetSN, a.AssetName, a.Name)).ToList();
        }

        // GET: api/Ativos/5
        public Assets Get(int id)
        {
            return bd.Assets.Find(id);
        }

        // POST: api/Ativos
        public void Post([FromBody]Assets value)
        {
            bd.Assets.Add(value);
            bd.SaveChanges();
        }

        // PUT: api/Ativos/5
        public void Put(int id, [FromBody]Assets value)
        {
            Assets atual = bd.Assets.Find(id);
            atual.AssetName = value.AssetName;
            bd.SaveChanges();
        }

        // DELETE: api/Ativos/5
        public void Delete(int id)
        {
            bd.Assets.Remove(bd.Assets.Find(id));
            bd.SaveChanges();
        }
    }
}
