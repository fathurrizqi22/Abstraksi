using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraksi.Interface2
{
    public class Programmer : IManusia
    {
        public void Bekerja()
        {
            Console.WriteLine("Programmer bekerja membuat code program dan aplikasi");
            Console.WriteLine("Programmer membuat code menggunakan Visual studio");
        }
    }
}
