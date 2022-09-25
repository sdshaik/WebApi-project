using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_project.Models;

namespace WebApi_project.Controllers
{

    public class ValuesController : ApiController

    {
        // GET api/values

        BusinessLogicLayer objbll = new BusinessLogicLayer();
        BusinessObjects objbo = new BusinessObjects();

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
        [Route("api/Values/getlogin")]
        [System.Web.Http.HttpGet]
        public string getlogin()
        {
            string ds = objbll.getlogin();
            return ds;

        }
        [Route("api/Values/AddOrder")]
        [HttpPost]
        public bool AddOrder(OrderModel om)
        {
            bool bl = objbll.AddOrder(om);
            return bl;
        }

        [Route("api/Values/updateOrder")]
        [HttpPut]
        public bool updateOrder(OrderModel om)
        {
            bool bl = objbll.UpdateOrder(om);
            return bl;
        }
        [Route("api/Values/getorder")]
        [System.Web.Http.HttpGet]
        public DataSet getorder()
        {
            DataSet ds = objbll.getorder();
            return ds;

        }
    }
}
