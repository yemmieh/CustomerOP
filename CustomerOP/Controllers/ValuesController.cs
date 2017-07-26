using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CustomerOP.Controllers
{
    public class ValuesController : ApiController
    {
        private yemiatworkdbEntities db = new yemiatworkdbEntities();
        // GET api/<controller>
        public List<Customer> Get()
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<Customer> Customers = new List<Customer>()
                ;
            //return new string[] { "value1", "value2" };
            Customers = db.Customers.ToList();
            foreach(Customer cust in db.Customers.ToList())
            {
                Customers.Add(cust);
            }
            return Customers;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}