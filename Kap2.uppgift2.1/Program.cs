using System;
namespace Uppgift_2._1
{
    class Program
    {
        static void Main(string[] args)
            {
                Console.WriteLine("vilken stad du komemr från");
                string stad = Console.ReadLine();
                Console.WriteLine("Vilken är den dromsresmål");
                string resmål = Console.ReadLine();
            
                Console.WriteLine("Hej " +stad+ "s bo. Jag hoppas att du får resa till " +resmål+ ".");
            }
    }
}
