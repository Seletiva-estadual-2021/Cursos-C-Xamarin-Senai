﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PessoasAPI.Controllers
{
    public class PessoaController : ApiController
    {
        testeEntities en = new testeEntities();

        // GET api/<controller>
        public IEnumerable<pessoa> Get()
        {
            return en.pessoa.ToList();
        }

        // GET api/<controller>/5
        public pessoa Get(int id)
        {
            return en.pessoa.Find(id);
        }

        // POST api/<controller>
        public pessoa Post([FromBody] pessoa value)
        {
            en.pessoa.Add(value);
            en.SaveChanges();
            return value;
        }

        // PUT api/<controller>/5
        public pessoa Put(int id, [FromBody] pessoa value)
        {
            pessoa p = en.pessoa.Find(id);
            p.nome = value.nome;
            p.idade = value.idade;
            p.foto = value.foto;
            en.SaveChanges();
            return value;
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            pessoa p = en.pessoa.Find(id);
            en.pessoa.Remove(p);
            en.SaveChanges();
        }
    }
}