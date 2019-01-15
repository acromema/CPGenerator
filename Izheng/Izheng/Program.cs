using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izheng
{
    class Program
    {
        static void Main(string[] args)
        {
            IntGen problem = new IntGen
            {
                Mod = 0
            };
            problem.GenerateProblem();
            Console.WriteLine(problem.Problem);
            Console.WriteLine(problem.result);
        }
    }
}
