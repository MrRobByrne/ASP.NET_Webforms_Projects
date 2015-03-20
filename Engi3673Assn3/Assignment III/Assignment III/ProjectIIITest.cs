using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;
using System.Diagnostics;

namespace Assignment_III_Test
{
    /// <summary>
    /// Data Access Code
    /// </summary>
    public class Project_III_Test
    {

        public int Counter()
        {

            string sqlcmd = "SELECT *FROM Ottawa";
            int count = 0;


            using (NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=astronauta;Database=Assignment III;"))
            {
                conn.Open();
                Stopwatch sw = new Stopwatch();
                sw.Start();

                using (NpgsqlCommand cmdCount = new NpgsqlCommand(sqlcmd, conn))
                {

                    // count = (int)cmdCount.ExecuteScalar(); 
                    //  MessageBox.Show(sw.Elapsed.ToString());
                }
                sw.Stop();

                //System.Diagnostics.Debug.WriteLine(sw.Elapsed);

                // System.Diagnostics.Debug.WriteLine("sososos");

            }

            return count;










            /*   public class Project_III
              {
                      static Int64 Connect()
                       {
                          //NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1; Port=5432; Database=Assignment III; Integrated Security=true;");
                         NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=astronauta;Database=Assignment III;");
                         conn.Open();

                         Int64 rows = 0;
                        NpgsqlCommand cmd = new NpgsqlCommand("SELECT *FROM  Ottawa",conn);

                         try
                         {
                             NpgsqlDataReader dr = cmd.ExecuteReader();
                             while (dr.Read())
                             {
                                 rows++;
                             }
                             Console.WriteLine();
                  
                         }
                           finally
                         {
                   
                             conn.Close();
                         }

                            return rows; 
                    }
                     */
        }

    }

}
