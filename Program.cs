using System;
using Abstraksi.Interface2;

namespace Abstraksi
{
    class Program
    {
        static void Main(string[] args)
        {
            IManusia manusia;

            manusia = new Programmer();
            manusia.Bekerja();

            Console.WriteLine();
            manusia = new Dokter();
            manusia.Bekerja();
           
            Console.ReadKey();
        }
    }
}
