using System;

namespace Coba
{
    public class Mahasiswa : Manusia
    {
        //constructor

        public Mahasiswa()
        {

        }
        // property
        int umur;
        string npm;
        string nama;

        //function

        public void menulis()
        {
            Console.WriteLine("menulis");
        }

        public string membaca()
        {
            return "buku";
        }
    }
}