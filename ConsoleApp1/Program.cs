using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Please enter two numbers for addition");
                Myservice.WebService1 obj = new Myservice.WebService1();
                int n1 = Convert.ToInt16(Console.ReadLine());
                int n2 = Convert.ToInt16(Console.ReadLine());

                string res = obj.Add(n1, n2);
                Console.WriteLine(res);
            }
            {
                Console.WriteLine("Please enter two numbers for subtraction");
                int n1 = Convert.ToInt16(Console.ReadLine());
                int n2 = Convert.ToInt16(Console.ReadLine());
                Myservice.WebService1 obj = new Myservice.WebService1();
                Console.WriteLine(obj.Subtarct(n1, n2));
            }
            {
                Console.WriteLine("Please enter two numbers for multiplication");
                int n1 = Convert.ToInt16(Console.ReadLine());
                int n2 = Convert.ToInt16(Console.ReadLine());
                Myservice.WebService1 obj = new Myservice.WebService1();
                Console.WriteLine(obj.Multiply(n1, n2));

            }
            Console.WriteLine("Thanks for trying ,visit again");

            Console.ReadKey();
            
     

        }
    }
}
