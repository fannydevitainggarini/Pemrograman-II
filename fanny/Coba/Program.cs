using System;

namespace Coba
{
    class Program
    {
        static void Main(string[] args)
        {
             int angka = 0;

            Console.WriteLine("Masukan angka");
            string inputan = Console.ReadLine();

            int.TryParse(inputan, out angka);

            //angka = angka < angka;
            
            for (int i = 0; i < angka; i++)
            {
                Console.WriteLine("angka= " + i + ", kuadrat=" + Math.Pow(i, 2));
            }

            Mahasiswa isa = new Mahasiswa();
            Mahasiswa adi = new Mahasiswa();
            Mahasiswa wida = new Mahasiswa();
            Mahasiswa jugo = new Mahasiswa();
            isa.menulis();
            Console.WriteLine(jugo.membaca());
            jugo.bernafas();

            Irc wins = new Irc();
            Console.WriteLine(wins.membaca());
            wins.mempromosikan();
        }
    }
}
