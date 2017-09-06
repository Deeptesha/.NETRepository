using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemo.Models
{
    public class Cars
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public string VariantName { get; set; }
        public int Price { get; set; }
        public string fuel { get; set; }
    }
}