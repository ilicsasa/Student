using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student;
using Student;
using System.IO;


namespace Student
{
    class StudentUI
    {
        public static void Menu()
        {
            int odluka = -1;
            while (odluka != 0)
            {
                IspisiMenu();
                Console.Write("opcija:");
                odluka = IO.OcitajCeoBroj();
                switch (odluka)
                {
                    case 0:
                        Console.WriteLine("Izlaz");
                        break;
                    case 1:
                        IspisiSveStudente();
                        break;
                    case 2:
                        UnosNovogStudenta();
                        break;

                    default:
                        Console.WriteLine("Nepostojeca komanda");
                        break;
                }
            }
        }

        public static void IspisiMenu()
        {
            Console.WriteLine("Rad sa studentima - opcije:");
            Console.WriteLine("\tOpcija broj 1 - ispis svih Studenata");
            Console.WriteLine("\tOpcija broj 2 - unos novog Studenta");
            Console.WriteLine("\t\t ...");
            Console.WriteLine("\tOpcija broj 0 - IZLAZ");
        }

        /** METODE ZA ISPIS STUDENATA ****/
        // ispisi sve studente
        public static void IspisiSveStudente()
        {
            List<Student> sviStudenti = StudentiDAO.GetAll(Program.conn);
            for (int i = 0; i < sviStudenti.Count; i++)
            {
                Console.WriteLine(sviStudenti[i]);
            }
        }


        // unos novog studenta
        public static void UnosNovogStudenta()
        {
            Console.Write("Unesi indeks:");
            string stIndex = IO.OcitajTekst();
            Console.Write("Unesi ime:");
            string stIme = IO.OcitajTekst();
            Console.Write("Unesi prezime:");
            string stPrezime = IO.OcitajTekst();
            Console.Write("Unesi grad:");
            double stProsek = IO.OcitajDouble();

            Student st = new Student(0, stIndex, stIme, stPrezime, stProsek);
            // ovde se moze proveravati i povratna vrednost i onda ispisivati poruka
            StudentDAO.Add(Program.conn, st);
        }


    }


}

