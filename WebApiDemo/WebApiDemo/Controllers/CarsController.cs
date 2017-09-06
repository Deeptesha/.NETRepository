using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    public class CarsController : ApiController
    {

        static List<Cars> car = new List<Cars> {
           new Cars {Id=1,CarName="Maruti Suzuki Swift", VariantName="Maruti Suzuki Swift LDi(O)",Price=490000,fuel="Diesel" },
           new Cars {Id=2,CarName="Hyundai Grand I10", VariantName="Hyundai Grand I10 1.2 CRDi Asta",Price=731000,fuel="Diesel" },
           new Cars {Id=3,CarName="Hyundai Creta", VariantName="Hyundai Creta 1.6 VTVT E Plus",Price=959000,fuel="Petrol" },

        };
        // GET api/values
        public List<Cars> Get()
        {

            return car;
        }

        // GET api/values/5
        public Cars Get(int id)
        {
            Cars car1 = car.FirstOrDefault(p => p.Id == id);
            return car1;
        } 

        // POST api/values
        public void Post([FromBody]Cars c)
        {
            car.Add(c);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Cars c)
        {
            car.Insert(id, c);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            car.RemoveAt(id);
        }
    }
}