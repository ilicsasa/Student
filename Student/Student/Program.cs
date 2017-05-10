using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Student
{
    class Program
    {
        public static SqlConnection conn;

        static void LoadConnection()
        {
            try
            {
                // konekcija
                conn = new SqlConnection(
                    "Data Source=E302-02\\SQLEXPRESS;Initial Catalog=DotNetKurs;User ID=sa;Password=singidunum;MultipleActiveResultSets=True");
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
