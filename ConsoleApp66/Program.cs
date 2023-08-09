using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp66
{
    class Program
    {
        static void Main(string[] args)
        {
            sayHi("mike", 78);
            sayHi("john", 34);
            sayHi("max", 23);
            Console.ReadLine();
        }

        static void sayHi(string name,int age)
        {
            Console.WriteLine(" Hello " + name + " you are " + age );
            Console.ReadLine();
              
        }
    }
}
