using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using WebApi_project.Models;
using System.Web.WebSockets;
using System.Configuration;

namespace WebApi_project.Models
{
    public class Dataaccesslayer
    {
        string cs = ConfigurationManager.ConnectionStrings["constr"].ToString();
        BusinessObjects bo=new BusinessObjects();
       public string getlogin(BusinessObjects bo)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_sologin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerName", bo.customer_Name);
                cmd.Parameters.AddWithValue("@CustomerPass", bo.customer_pswd);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    return "LoggedIn";
                }
                else
                {
                    return "LogIn Failed";
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
           

        }

        public bool AddOrder(OrderModel om)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("AddOrder", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(" @orderdate", om.orderdate);
                cmd.Parameters.AddWithValue("@itemorder", om.itemorder);
                int i = cmd.ExecuteNonQuery();
                    con.Close();
                if(i>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        
        }
        public bool UpdateOrder(OrderModel om)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("updateOrder", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(" @orderid", om.orderid);
                cmd.Parameters.AddWithValue(" @orderdate", om.orderdate);
                cmd.Parameters.AddWithValue("@itemorder", om.itemorder);
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public bool deleteOrder(OrderModel om)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("deleteOrder", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(" @orderid", om.orderid);
               
          
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataSet getorder()
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlDataAdapter da=new SqlDataAdapter("getorder",con);
                DataSet ds = new DataSet();
                da.Fill(ds,"tbl_order");
                return ds;
               
                
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }










    }
}