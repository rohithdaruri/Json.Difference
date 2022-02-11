using System;

namespace Json.Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Json.Difference!");
            Comparer comparer = new Comparer();
            comparer.Compare();
            Console.ReadKey();
        }
    }
}
