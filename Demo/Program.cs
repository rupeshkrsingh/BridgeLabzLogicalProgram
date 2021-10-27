using System;

namespace Demo
{
   public class Program
    {
       
        public static int isSum(int a,int b)
        {
            int c = a + b;
            return c;
        }
        
       public static void Main(string[] args)
       {
            Console.WriteLine("C# Basic Concept");
            Console.WriteLine("A+B=C value is:" + Program.isSum(20, 30));
            Console.WriteLine();
        }
    }
}
