using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Student
{
    public class IO
    {
        public static string OcitajTekst()
        {
            string tekst = "";
            while (tekst == null || tekst.Equals(""))
                tekst = Console.ReadLine();

            return tekst;
        }

        public static int OcitajCeoBroj()
        {
            int ceoBroj = 0;
            string tekst;
            while (true)
            {
                tekst = Console.ReadLine();
                if (int.TryParse(tekst, out ceoBroj) == true)
                {
                    break;
                }
            }
            return ceoBroj;
        }

        public static double OcitajDouble()
        {
            double realanBroj = 0;
            string tekst;
            while (true)
            {
                tekst = Console.ReadLine();
                if (double.TryParse(tekst, out realanBroj) == true)
                {
                    break;
                }
            }
            return realanBroj;
        }
    }
}
