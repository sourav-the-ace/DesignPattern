using System;

namespace SingletonPattern
{
    //*****The class is sealed because sealed class can not be inherited. 
    //*****If a class can be inherited it may violates sigleton pattern.
    public sealed class Singleton
    {
        private static int counter=0; //static int can be accessed from other class without creating new object
        //*****Lazy initialization of new instance
        private static readonly Lazy<Singleton> instance=new Lazy<Singleton>(()=>new Singleton());

        //*****Eager Loading example of creating instances where CLR takes care of tread management
        //private static readonly Singleton instance=new Singleton();

        //private static Singleton instance=null; 

        //*****A constructor created for counting how many instanced are made
        private Singleton()
        {
            counter++;
            Console.WriteLine("Total Count "+counter.ToString());
        }

        //*****Creating property to create instance but only if the instance were not made before
        public static Singleton GetInstance
        {
            get
            {
                //*****using value for lazy initialization
                return instance.Value;
            }
        }

        public void printDetail(string message)
        {
            Console.WriteLine(message);
        }
    }
}