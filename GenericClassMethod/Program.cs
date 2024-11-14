using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericClass<int> gc=new GenericClass<int>();
            gc.Add(1);
            Console.WriteLine(gc.Get());

            GenericClass<string>gc2=new GenericClass<string>();
            gc2.Add("Pratik");
            Console.WriteLine(gc2.Get());

            GenericClass<Product>gc3= new GenericClass<Product>();
            gc3.Add(new Product(1, "milk"));
            Console.WriteLine(gc3.Get());

            Console.WriteLine("--------------------------------------");

            GenericMethod gm=new GenericMethod();
            gm.Swipe(5, 10);
            Console.WriteLine();
        }
    }
}
