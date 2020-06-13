using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraksi.AbstractClass
{
    public class Programmer : Manusia
    {
        public override void Bekerja()
        {
            Console.WriteLine("Programmer bekerja membuat code program dan aplikasi");
            Console.WriteLine("Programmer membuat code menggunakan Visual studio");
        }
    }
}
