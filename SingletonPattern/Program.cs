using System.Threading.Tasks;
using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*****Traditional Way of creating object every time******
            Singleton firstObject=new Singleton();
            firstObject.printDetail("This is first object");
            Singleton SecondObject=new Singleton();
            SecondObject.printDetail("This is Second object");
            */

            //Calling GetInstance to create instance only once and using it everywhere
            // FirstObject();
            // SecondObject();

            //Parallel Invoking the GetInstance property to hit at the exact same time for both instances
            Parallel.Invoke(
                ()=>FirstObject(),
                ()=>SecondObject()
            );

            Console.ReadLine();
            //Console.WriteLine("Hello World!");
        }

        private static void SecondObject()
        {
            Singleton SecondObject = Singleton.GetInstance;
            SecondObject.printDetail("This is second object");
        }

        private static void FirstObject()
        {
            Singleton firstObject = Singleton.GetInstance;
            firstObject.printDetail("This is first object");
        }
    }
}
