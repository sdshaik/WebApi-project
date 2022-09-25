using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_project.Models
{
    public class BusinessObjects
    {
        public string customer_Name  { get; set; }

        public string customer_pswd{ get; set; }
    }

    public class OrderModel
    {
        public int orderid { get; set; }

        public DateTime orderdate{ get; set; }

        public string itemorder { get; set; }
    }
}