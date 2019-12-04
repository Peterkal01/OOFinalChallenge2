using FinalChallenge2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI;

namespace FinalChallenge2.Controllers
{
    public class ClassController : ApiController
    {
        // GET: api/Class
        public Class Get(string id)
        {

            SqlConnection conn = DBConnection.GetConnection();
            SqlCommand cmd;
            SqlDataReader rdr;
            String query;
            Class output = new Class();
            try
            {
                conn.Open();
                query = "select * from Class where ClassCode = '" + id +"'";
                cmd = new SqlCommand(query, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    output = new Class(rdr.GetValue(0).ToString(),
                        rdr.GetValue(1).ToString(),
                        rdr.GetValue(2).ToString(),
                        Int32.Parse(rdr.GetValue(3).ToString()));
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return output;
        }
    }
}
