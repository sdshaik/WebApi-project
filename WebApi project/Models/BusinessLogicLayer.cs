using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


namespace WebApi_project.Models
{
    public class BusinessLogicLayer
    {
        BusinessObjects objbs=new BusinessObjects();
        Dataaccesslayer objdal=new Dataaccesslayer();
        public string getlogin()
        {
            string ds = objdal.getlogin(objbs);
            return ds;
        }
        public bool AddOrder(OrderModel om)
        {
            bool bl=objdal.AddOrder(om);
            return bl;
        }
        public bool UpdateOrder(OrderModel om)
        {
            bool bl = objdal.UpdateOrder(om);
            return bl;
        }
        public DataSet getorder()
        {
            DataSet ds = objdal.getorder();
            return ds;
        }

    }
}