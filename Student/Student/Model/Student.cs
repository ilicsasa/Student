using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Student
{

    public class Student
    {
        public int id { set; get; }
        public string ime { set; get; }
        public string prezime { set; get; }
        public double prosek { set; get; }
        public string indeks { set; get; }


        public Student(int id, string indeks, string ime, string prezime,
                string prosek)
        {
            this.id = id;
            this.indeks = indeks;
            this.ime = ime;
            this.prezime = prezime;
            this.prosek = prosek;
        }

        // prebacivanje objekta Student u string reprezentaciju
        public override string ToString()
        {
            string s = "Student [" + indeks + " " + ime + " " + prezime + " sa prosekom "
                    + prosek + "]";
        }
    }
}
