using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Student
{
    public class StudentDAO
    {
        public static List<Student> GetAll(SqlConnection conn)
        {
            List<Student> retVal = new List<Student>();
            try
            {
                string query = "SELECT * FROM studenti ";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    int id = (int)rdr["id"];
                    string indeks = (string)rdr["indeks"];
                    string ime = (string)rdr["ime"];
                    string prezime = (string)rdr["prezime"];
                    double prosek = (double)rdr["prosek"];
                                    

                    Student student = new Student(id, indeks, ime, prezime, prosek);
                    retVal.Add(student);
                }
                rdr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return retVal;
        }

        public static bool Add(SqlConnection conn, Student student)
        {
            bool retVal = false;
            try
            {
                string update = "INSERT INTO studenti (id, ime, prezime, indeks, prosek) values (@id, @ime, @prezime, @indeks, @prosek)";
                SqlCommand cmd = new SqlCommand(update, conn);

                cmd.Parameters.AddWithValue("@id", student.id);
                cmd.Parameters.AddWithValue("@indeks", student.indeks);
                cmd.Parameters.AddWithValue("@ime", student.ime);
                cmd.Parameters.AddWithValue("@prezime", student.prezime);
                cmd.Parameters.AddWithValue("@grad", student.grad);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    retVal = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return retVal;
        }
    }
}
