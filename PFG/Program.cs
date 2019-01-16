using System;
using PFGen;

namespace PFG
{
    class Program
    {
        static void Main(string[] args)
        {
           Problem P = new Problem();
           Console.WriteLine(P.problem); 
           PF result = P.CalValue();
           result.Display();
        //    PF p1 = new PF();
        //    p1.Display();
            // for (int i = 0; i < 10; i++)
            // {
            //     P = new Problem();
            //     result = P.CalValue();
            //     Console.WriteLine(P.problem);
            //     result.Display();
            //     Console.Write("\n");
            // }  
        }
    }
}
