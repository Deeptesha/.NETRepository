using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    public class ValuesController : ApiController
    {
       static List<string> list= new List<string>{"SDMT", "Java Core","Advanced Java","Programming in C" };
        // GET api/values
        public List<string> Get()
        {

            return list;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return list[id];
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            list.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            list.Insert(id, value);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            list.RemoveAt(id);
        }
    }
}
