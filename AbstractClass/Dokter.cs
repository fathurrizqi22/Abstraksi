using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraksi.AbstractClass
{
    public class Dokter : Manusia
    {
        public override void Bekerja()
        {
            Console.WriteLine("Dokter menggunakan stetoskop untuk memeriksa detak jantung");
            Console.WriteLine("Dokter melakukan operasi");
            Console.WriteLine("Dokter memberikan resep obat");

        }
    }
}
