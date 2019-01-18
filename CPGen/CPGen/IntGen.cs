using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            opera[1] = new string[5] { "+", "-", "*", "/" ,"**"};
            opera[2] = new string[5] { "+", "-", "*", "/" ,"^"};
        }
        private readonly Random rand;
        public string Problem { get; set; }
        private readonly string[][] opera = new string[3][];
        private int operaNum;
        public string Result { get; set; }
        public int Mod { get; set; } = 0;
        private Queue<string> valueQueue = new Queue<string>();
        private Stack<string> operaStack = new Stack<string>();
        private string[] operaList = new string[10];
        private int[] numList = new int[11];

        private void GetOperaNum()
        {
            operaNum = rand.Next(10) + 1;
        }

        private void GetOperaList()
        {
            //GetOperaNum();
            int multNum = 0;
            int powNum = 0;
            for (int i = 0; i < operaNum; i++)
            {

                string temp = opera[Mod][rand.Next(opera[Mod].Length)];
                if(powNum == 1 && (temp == "**" || temp == "^"))
                {
                    i--;
                    continue;
                }
                if(temp == "**" || temp == "^")
                {
                    powNum++;
                }
                if (multNum == 2 && temp == "*")
                {
                    i--;
                    continue;
                }
                if (temp == "*")
                {
                    multNum++;
                }
                if (i > 0 && operaList[i - 1] == "/" && temp == "/")
                {
                    i--;
                    continue;
                }
                operaList[i] = temp;
            }
            if(powNum ==1)
            {
                for (int i = 0; i < operaNum; i++)
                {
                    if(operaList[i] == "*")
                    {
                        operaList[i] = "+";
                    }
                    if (operaList[i] == "/")
                    {
                        operaList[i] = "-";
                    }
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
                        if (operaList[i - 1] == "*")
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
                    }
                    numList[i + 1] = rand.Next(31);
                }
                else if(operaList[i] == "**"||operaList[i]=="^")
                {
                    numList[i] = rand.Next(21);
                    if(numList[i]==0)
                    {
                        numList[i+1] = rand.Next(1,101);
                    }
                    else if (numList[i]==1)
                    {
                        numList[i + 1] = rand.Next(101);
                    }
                    else if(numList[i]<=4)
                    {
                        numList[i + 1] = rand.Next(6);
                    }
                    else
                    {
                        numList[i + 1] = rand.Next(3);
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
                Problem += operaList[i] + " " + numList[i + 1].ToString() + " ";
            }
            CalculateValue();
        }

        private void TransRpn()
        {
            string[] symbols = Problem.Split(' ');
            for (int i = 0; i < symbols.Length; i++)
            {
                if (IsInt(symbols[i]))
                {
                    valueQueue.Enqueue(symbols[i]);
                }
                else if (IsOperator(symbols[i]))
                {
                    while (operaStack.Count != 0&&GetOptionLevel(operaStack.Peek())>=GetOptionLevel(symbols[i]))
                    {
                        valueQueue.Enqueue(operaStack.Pop());
                    }
                    operaStack.Push(symbols[i]);
                }
                else if(symbols[i]=="(")
                {
                    operaStack.Push(symbols[i]);
                }
                else if(symbols[i] == ")")
                {
                    while (operaStack.Count!=0&&operaStack.Peek()!="(")
                    {
                        valueQueue.Enqueue(operaStack.Pop());
                    }
                    operaStack.Pop();
                }
            }

            while (operaStack.Count != 0)
            {
                valueQueue.Enqueue(operaStack.Pop());
            }
        }

        private void CalculateValue()
        {
            TransRpn();
            Stack<int> numStack = new Stack<int>();
            while(valueQueue.Count!=0)
            {
                if(IsInt(valueQueue.Peek()))
                {
                    numStack.Push(int.Parse(valueQueue.Dequeue()));
                }
                else
                {
                    string operation = valueQueue.Dequeue();
                    numStack.Push(GetOptionValue(operation, numStack.Pop(), numStack.Pop()));
                }
            }
            Result = numStack.Pop().ToString();
        }

        private int GetOptionLevel(string operation)
        {
            int result = 0;
            switch (operation)
            {
                case "+":
                    result = 1;
                    break;
                case "-":
                    result = 1;
                    break;
                case "*":
                    result = 2;
                    break;
                case "/":
                    result = 2;
                    break;
                case "**":
                    result = 3;
                    break;
                case "^":
                    result = 3;
                    break;
            }
            return result;
        }

        private int GetOptionValue(string operation, int b, int a)
        {
            int result = 0;
            switch (operation)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
                case "**":
                    result = int.Parse(Math.Pow(a,b).ToString());
                    break;
                case "^":
                    result = int.Parse(Math.Pow(a, b).ToString());
                    break;
            }
            return result;
        }

        private bool IsOperator(string str)
        {
            if (str == "+" || str == "-" || str == "*" || str == "/" || str == "**" || str == "^")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsInt(string value)
        {
            return Regex.IsMatch(value, @"^\d+$");
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
