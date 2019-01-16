using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFGen
{
    class PF
    {
        public int mother { get; set; }
        public int son { get; set; }

        public PF()
        {
        	Random rand = new Random(GetRandomSeed());
        	mother = rand.Next(3,10);
            son = rand.Next(1,2);
            int maxDivisor = MaxComDivisor(Math.Abs(mother), Math.Abs(son));
            mother /= maxDivisor;
            son /= maxDivisor;
        }
        public PF(int _mother, int _son)
        {
        	mother = _mother;
            son = _son;
            int maxDivisor = MaxComDivisor(Math.Abs(mother), Math.Abs(son));
            mother /= maxDivisor;
            son /= maxDivisor;
        }
        public void Display()
        {
            Console.WriteLine("{0}/{1}", son, mother);
        }

        public string ConvertString()
        {
            string temp = son.ToString() + "/" + mother.ToString();
            return temp;
        }

        private static int GetRandomSeed()//Random rand = new Random(GetRandomSeed());  rand.Next(1000)
        {
            byte[] bytes = new byte[10];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }

        private int MaxComDivisor(int x, int y)
        {
            while (true)
            {
                if (x > y)
                {
                    x -= y;
                }
                else if(x < y)
                {
                    y -= x;
                }
                else
                {
                    return x;
                }
            }
        }

        public static PF operator+ (PF p1,PF p2)  
        {  
           int mother = p1.mother * p2.mother;
           int son1 = p1.son * p2.mother;
           int son2 = p2.son * p1.mother;
           int son = son1 + son2;
           PF sum = new PF(mother, son);
           return sum;
        }

        public static PF operator- (PF p1,PF p2)  
        {  
           int mother = p1.mother * p2.mother;
           int son1 = p1.son * p2.mother;
           int son2 = p2.son * p1.mother;
           int son = son1 - son2;
           PF result = new PF(mother, son);
           return result;
        }

        public static PF operator* (PF p1,PF p2)  
        {  
           int mother = p1.mother * p2.mother;
           int son = p1.son * p2.son;
           PF result = new PF(mother, son);
           return result;
        }

        public static PF operator/ (PF p1,PF p2)  
        {  
           int mother = p1.mother * p2.son;
           int son = p1.son * p2.mother;
           PF result = new PF(mother, son);
           return result;
        }
    }
    class Problem
    {
        private string op1;
        private string op2;
        private string op3;
        private PF p1;
        private PF p2;
        private PF p3;
        private PF p4;
        public string problem;

        public Problem()
        {
            string[] op = new string[]{"+", "-", "*", "/", "-", "+"};
            Random rand = new Random(GetRandomSeed());
            op1 = op[rand.Next(6)];
            op2 = op[rand.Next(6)];
            op3 = op[rand.Next(6)];
            p1 = new PF();
            int baseMother = rand.Next(2,5)*p1.mother;
            p2 = new PF(baseMother,rand.Next(1,baseMother));
            baseMother = rand.Next(2,5)*p1.mother;
            p3 = new PF(baseMother,rand.Next(1,baseMother));
            baseMother = rand.Next(2,5)*p1.mother;
            p4 = new PF(baseMother,rand.Next(1,baseMother));
            problem = p1.ConvertString() + " " + op1 + " " + p2.ConvertString() + " " + op2 + " " + p3.ConvertString() + " " + op3 + " " + p4.ConvertString();
        }

        private int GetOpLevel(string op)
        {
            if (op == "+" || op == "-")
            {
                return 1;
            }
            if (op == "*" || op == "/")
            {
                return 2;
            }
            return 0;
        }
        public PF CalValue()
        {
            string[] symbols = {"1", op1, "2", op2, "3", op3, "4"};
            Stack<string> operaStack = new Stack<string>();
            Queue<string> valueQueue = new Queue<string>();
            Stack<PF> numStack = new Stack<PF>();
            for (int i = 0; i < symbols.Length; i++)
            {
                if (IsInt(symbols[i]))
                {
                    valueQueue.Enqueue(symbols[i]);
                }
                else if (IsOperator(symbols[i]))
                {
                    while (operaStack.Count != 0 && GetOpLevel(operaStack.Peek())>=GetOpLevel(symbols[i]))
                    {
                        valueQueue.Enqueue(operaStack.Pop());
                    }
                    operaStack.Push(symbols[i]);
                }
            }            
            while (operaStack.Count != 0)
            {
                valueQueue.Enqueue(operaStack.Pop());
            }
            while(valueQueue.Count != 0)
            {
                if(IsInt(valueQueue.Peek()))
                {
                    switch (valueQueue.Peek())
                    {
                        case "1":
                            numStack.Push(p1);
                            break;
                        case "2":
                            numStack.Push(p2);
                            break;
                        case "3":
                            numStack.Push(p3);
                            break;
                        case "4":
                            numStack.Push(p4);
                            break;
                        default:
                            break;
                    }  
                    valueQueue.Dequeue();
                    // numStack.Peek().Display();
                    // Console.WriteLine(" ");
                }
                else
                {
                    string operation = valueQueue.Dequeue();
                    numStack.Push(GetOptionValue(operation, numStack.Pop(), numStack.Pop()));
                }   
            }
            PF result = numStack.Pop();
            return result;
        }
        private PF GetOptionValue(string operation, PF b, PF a)
        {
            PF result = new PF();
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
            }
            return result;
        }

        private bool IsOperator(string str)
        {
            if (str == "+" || str == "-" || str == "*" || str == "/")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool IsInt(string str)
        {
            if (str == "1" || str == "2" || str == "3" || str == "4")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Display()
        {
            Console.WriteLine(problem);
        }

        private static int GetRandomSeed()//Random rand = new Random(GetRandomSeed());  rand.Next(1000)
        {
            byte[] bytes = new byte[10];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }

    }

}