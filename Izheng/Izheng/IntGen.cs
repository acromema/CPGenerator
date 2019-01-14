using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izheng
{
    class IntGen
    {
        public IntGen()
        {
            Problem = "";
            rand = new Random(GetRandomSeed());
            opera[0] = new string[4] { "+", "-", "*", "/" };
            //opera[1] = new string[5] { "+", "-", "*", "/" ,"**"};
            //opera[2] = new string[5] { "+", "-", "*", "/" ,"^"};
        }
        private readonly Random rand;
        public string Problem { get; set; }
        private readonly string[][] opera = new string[3][];
        private int operaNum;
        public int Mod { get; set; } = 0;

        private string[] operaList = new string[10];
        private int[] numList = new int[11];

        private void GetOperaNum()
        {
            operaNum = rand.Next(10) + 1;
        }

        private void GetOperaList()
        {
            //GetOperaNum();
            for (int i = 0; i < operaNum; i++)
            {
                string temp = opera[Mod][rand.Next(opera[Mod].Length)];
                if (i > 0 && operaList[i - 1] == "/" && temp == "/")
                {
                    i--;
                }
                else
                {
                    operaList[i] = temp;
                }
            }
        }

        private void GetNumList()
        {
            //GetOperaList();
            int tempNum;
            for (int i = 0; i < operaNum; i++)
            {
                if (operaList[i] == "/")
                {
                    tempNum = rand.Next(1, 31);
                    numList[i + 1] = tempNum;
                    if (tempNum >= 25)
                    {
                        numList[i] = rand.Next(5) * tempNum;
                    }
                    else if (tempNum >= 15)
                    {
                        numList[i] = rand.Next(7) * tempNum;
                    }
                    else if (tempNum >= 10)
                    {
                        numList[i] = rand.Next(9) * tempNum;
                    }
                    else
                    {
                        numList[i] = rand.Next(11) * tempNum;
                    }
                }
                else if (operaList[i] == "*")
                {
                    if (i == 0)
                    {
                        numList[i] = rand.Next(31);
                        numList[i + 1] = rand.Next(31);
                    }
                    else
                    {
                        if(operaList[i - 1] == "*")
                        {
                            numList[i + 1] = rand.Next(10);
                        }
                        else
                        {
                            numList[i + 1] = rand.Next(31);
                        }
                    }

                    while (numList[i] * numList[i + 1] > 100)
                    {
                        numList[i + 1] /= 2;
                    }
                }
                else if (operaList[i] == "+" || operaList[i] == "-")
                {
                    if (i == 0)
                    {
                        numList[i] = rand.Next(31);
                        numList[i + 1] = rand.Next(31);
                    }
                    else
                    {
                        numList[i + 1] = rand.Next(31);
                    }
                }
            }
        }

        public void GenerateProblem()
        {
            GetOperaNum();
            GetOperaList();
            GetNumList();

            Problem = numList[0].ToString() + " ";
            for (int i = 0; i < operaNum; i++)
            {
                Problem += operaList[i] + " " + numList[i+1].ToString() + " ";
            }
        }

        private int GetRandomSeed()
        {
            byte[] bytes = new byte[10];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }
    }
}
