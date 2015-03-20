//-----------------------------------------------------------------------
// <copyright file="Class1.cs" company="The Boys">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
// <author>Robert & Levi</author>
//-----------------------------------------------------------------------

/// <summary> 
/// Gets or sets the name of the customer. 
/// </summary> 
namespace ProjectIII
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Npgsql;

    /// <summary> 
    /// Gets or sets the name of the customer.
    /// </summary> 
    /// <returns>The count of the rows in the table</returns>
    public static class Class1
    {
        /// <summary>
        /// <param name="count">Count the number of rows in the table.</param> 
        /// </summary>
        public static long count;

        /// <summary>
        /// <param name="count1">Count the number of rows in the table.</param> 
        /// </summary>
        public static long count2;

        /// <summary>
        /// <param name="count2">Count the number of rows in the table.</param> 
        /// </summary>
        public static long count3 = 0;

        /// <summary>
        /// Main function has as return void. 
        /// In this function we user Count, Count2 and Count 3 to return the number of rows. We also use  System.Diagnostics.Debug.WriteLine
        /// to print the time elapsed with stopwatch. 
        /// </summary>
        [STAThread]

        public static void Main()
        {
            // Using Npgsql to connect with the database
            // using (NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=elbatl00P;Database=Assignment III;"))
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1; Port=5432; Database=Assignment III; Integrated Security=true;"))
            {
                // Stopwatch will give the elapsed time
                conn.Open();
                Stopwatch sw = new Stopwatch();
                sw.Start();

                string sqlcmd = "SELECT *FROM Ottawa";
                NpgsqlCommand cmd = new NpgsqlCommand(sqlcmd, conn);
                NpgsqlDataReader reader = cmd.ExecuteReader();

                // While there is data in the database
                while (reader.Read())
                {
                    count++;
                }

                conn.Close();

                sw.Stop();

                Console.Write("Table Ottawa\n");
                Console.WriteLine("Elapsed={0}", sw.Elapsed);

                // System.Diagnostics.Debug.WriteLine(sw.Elapsed);
                Console.Write("Number of Rows\n");
                Console.Write(count);
                Console.Write("\n\n");
            }

            using (NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1; Port=5432; Database=Assignment III; Integrated Security=true;"))
            {
                conn.Open();
                Stopwatch sw = new Stopwatch();
                sw.Start();

                string sqlcmd2 = "SELECT *FROM Ottawa_indexed";
                NpgsqlCommand cmd = new NpgsqlCommand(sqlcmd2, conn);
                NpgsqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    count2++;
                }

                conn.Close();

                sw.Stop();

                Console.Write("Table Ottawa_Indexed\n");
                Console.WriteLine("Elapsed={0}", sw.Elapsed);

                // System.Diagnostics.Debug.WriteLine(sw.Elapsed);
                Console.Write("Number of Rows\n");
                Console.Write(count2);
                Console.Write("\n\n");
            }

            using (NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1; Port=5432; Database=Assignment III; Integrated Security=true;"))
            {
                conn.Open();

                Stopwatch sw = new Stopwatch();
                sw.Start();

                string sqlcmd3 = "SELECT *FROM ottawa_indexed where roadtype='AVE'";
                NpgsqlCommand cmd = new NpgsqlCommand(sqlcmd3, conn);
                NpgsqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    count3++;
                }

                conn.Close();

                sw.Stop();

                Console.Write("Table Ottawa using a Where\n");
                Console.WriteLine("Elapsed={0}", sw.Elapsed);

                // System.Diagnostics.Debug.WriteLine(sw.Elapsed);
                Console.Write("Number of Rows:\n");
                Console.Write(count3);
                Console.Write("\n\n");
            }

            using (NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=elbatl00P;Database=Assignment III;"))
            {
                conn.Open();

                string sqlcmd4 = "ANALYSE ottawa_indexed; EXPLAIN ANALYSE SELECT * FROM ottawa_indexed where roadtype='AVE'";
                NpgsqlCommand cmd = new NpgsqlCommand(sqlcmd4, conn);

                NpgsqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine("Query Plan:");

                while (reader.Read())
                {
                    Console.WriteLine("{0}", (string)reader[0]);
                }

                conn.Close();
            }

            return;
        }
    }
}
