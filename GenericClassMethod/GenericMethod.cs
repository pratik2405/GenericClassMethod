using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassMethod
{
    public class GenericMethod
    {

        public void Swipe<T>(T a , T b)
        {
           Console.WriteLine($"a={a} b={b}");
            T temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"a={a}  b={b}");
        }
    }
}
