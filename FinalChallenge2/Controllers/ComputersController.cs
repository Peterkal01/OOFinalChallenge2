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
    public class ComputersController : ApiController
    {
        // GET: api/Computers
        public IEnumerable<Computer> Get()
        {         

            {

                SqlConnection conn = DBConnection.GetConnection();
                SqlCommand cmd;
                SqlDataReader rdr;
                String query;
                List<Computer> output = new List<Computer>();

                try
                {
                    conn.Open();
                    query = "select * from Computer";
                    cmd = new SqlCommand(query, conn);
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        output.Add(new Computer(Int32.Parse(rdr.GetValue(0).ToString()),
                            Int32.Parse(rdr.GetValue(1).ToString()),
                            rdr.GetValue(2).ToString(),
                            Int32.Parse(rdr.GetValue(3).ToString())));
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
}
