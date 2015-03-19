using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace paintmodelASP
{
    /// <summary>
    /// Paitn_input is the class tha contains implementation of the project
    /// </summary>
    public class Paint_input
    {

        /// <summary>
        /// getWhileLoopData gets arguments from Values fuction and copying the values int htmlStr
        /// </summary>
        /// <returns>htmlStr which contains all database values</returns>
        public static string getWhileLoopData()
        {
            string htmlStr = "";
            int count = 4, x = 0;
            List<float> Quantity = new List<float>();
            List<string> Paint_Name = new List<string>();
            Values(out Paint_Name, out Quantity);



            while (x < count)
            {

                htmlStr += "<tr><td>" + Paint_Name[x] + "</td><td>" + Quantity[x] + "</td><td>";

                x++;
            }

            return htmlStr;


        }
        /// <summary>
        /// Values connects to database, gets the values and stores them in the appropriate lists
        /// </summary>
        /// <param name="Paint_Name">Column name in database</param>
        /// <param name="Quantity">Column name in database</param>
        public static void Values(out List<string> Paint_Name, out List<float> Quantity)
        {
            int count = 0;
            Quantity = new List<float>();
            Paint_Name = new List<string>();

            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;" +
                "IntegratedSecurity=True;Database=table;");

            conn.Open();

            NpgsqlCommand thisCommand = conn.CreateCommand();

            thisCommand.CommandText = "SELECT * from \"Paint\"";
            NpgsqlDataReader reader = thisCommand.ExecuteReader();

            while (reader.Read())
            {

                Quantity.Add((float)reader["Quantity"]);
                Paint_Name.Add((string)reader["Paint_Name"]);
                count++;
            }

            conn.Close();


        }
    }
}