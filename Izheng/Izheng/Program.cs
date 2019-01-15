using System;
using System.Collections.Generic;
using System.IO;
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
            Console.WriteLine("欢迎进入四则运算出题系统");
            Console.WriteLine("请选择所要进行的操作：（输入相应数字选择）");
            Console.WriteLine("1.输出试题1000道，2.进入答题系统");
            Console.Write("我选择：");
            string str = Console.ReadLine();
            if(str == "1")
            {
                string fileName = "小学生难题1000道.txt";
                string newPath = AppDomain.CurrentDomain.BaseDirectory + fileName;
                StreamWriter streamWriter = new StreamWriter(newPath, false, Encoding.Default);
                for (int i = 0; i < 1000; i++)
                {
                    problem.GenerateProblem();
                    streamWriter.WriteLine(problem.Problem);
                    //Console.WriteLine(problem.Result);
                }
                Console.WriteLine("导出成功！");
            }
            else if (str == "2")
            {
                int right = 0;
                Console.WriteLine("一共五道题，每题20分");
                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                sw.Start();
                for (int i = 0; i < 5; i++)
                {
                    problem.GenerateProblem();
                    Console.WriteLine(problem.Problem);
                    Console.Write("你的答案是：");
                    string ans = Console.ReadLine();
                    if(ans == problem.Result)
                    {
                        right++;
                        Console.WriteLine("你答对了！");
                    }
                    else
                    {
                        Console.WriteLine("你答错了！");
                    }
                }
                sw.Stop();
                TimeSpan ts2 = sw.Elapsed;
                Console.WriteLine("答题结束，你答对了{0}题，总分{1}/100", right, right * 20);         
                Console.WriteLine("花费{0}s", ts2.TotalSeconds);
            }
            else
            {
                Console.WriteLine("你个撒子，你输入有误！请进入系统重新来过");
            }
            Console.ReadKey();
        }
    }
}
