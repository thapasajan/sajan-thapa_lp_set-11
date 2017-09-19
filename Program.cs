using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Server=nsd-sajan;Database=testingDatabase;Integrated Security=SSPI");
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT uid, uFirstName FROM [dbo].[user_data]", conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("{1}, {0}", reader.GetInt32(0), reader.GetString(1));
                
            }
            reader.Close();
            conn.Close();
            if (Debugger.IsAttached)
            {
                Console.ReadLine();
            }
            

        }
    }
}
