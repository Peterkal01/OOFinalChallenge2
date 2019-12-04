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
    public class RoomsController : ApiController
    {
        // GET: api/Rooms
        public IEnumerable<Rooms> Get()

        {

            SqlConnection conn = DBConnection.GetConnection();
            SqlCommand cmd;
            SqlDataReader rdr;
            String query;
            List<Rooms> output = new List<Rooms>();

            try
            {
                conn.Open();
                query = "select * from Room";
                cmd = new SqlCommand(query, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    output.Add(new Rooms(rdr.GetValue(0).ToString(),
                        Int32.Parse(rdr.GetValue(1).ToString()),
                        Int32.Parse(rdr.GetValue(2).ToString())));
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
