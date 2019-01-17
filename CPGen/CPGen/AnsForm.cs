using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PFGen;
using Izheng;

namespace CPGen
{
    public partial class AnsForm : Form
    {
        public AnsForm()
        {
            InitializeComponent();

            this.ControlBox = false;

            lb_Time.Text = timeCount.ToString();
            problem1.Mod = AnsSystem.ans.cmb_SelectMod.SelectedIndex;
            num = nums[AnsSystem.ans.cmb_Num.SelectedIndex];
            type = AnsSystem.ans.cmb_Erabu.SelectedIndex;
            lb_Problem.Text = "";
            btn_Save.Enabled = false;
        }
        int timeCount = 20;
        IntGen problem1 = new IntGen();
        Problem problem2 = new Problem();
        int num;
        int type;
        string answer;
        int probCount = 0;
        int correctCount = 0;
        int[] nums = new int[5] { 5, 10, 20, 25, 50 };

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            AnsSystem.ans.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            this.timer1.Enabled = true;
            //this.timer1.Start();     
            lb_Time.Text = timeCount.ToString();
            timeCount--;
            if (timeCount == -1)
            {
                string show = lb_Problem.Text + " = " + txb_Answer.Text;
                show += "   错误，正确答案为" + answer;
                listBox1.Items.Add(show);
                timeCount = 20;
                if (probCount == num)
                {
                    this.timer1.Stop();
                    MessageBox.Show("你一共答对了" + correctCount.ToString() + "/" + num.ToString() + "道题，总分" + 100 / num * correctCount + "分");
                    this.btn_Save.Enabled = false;
                }
                else
                {
                    GenProb();
                }
                txb_Answer.Text = "";
            }
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            GenProb();
            this.btn_Start.Enabled = false;
            this.btn_Save.Enabled = true;
        }

        private void GenProb()
        {
            probCount++;
            if (type == 0)
            {
                problem1.GenerateProblem();
                lb_Problem.Text = problem1.Problem;
                answer = problem1.Result;
            }
            else if (type == 1)
            {
                problem2.GenerateProblem();
                lb_Problem.Text = problem2.problem;
                answer = problem2.CalValue().ConvertString();
            }
            else
            {
                Random rand = new Random(GetRandomSeed());
                int a = rand.Next(2);
                if (a == 1)
                {
                    problem1.GenerateProblem();
                    lb_Problem.Text = problem1.Problem;
                    answer = problem1.Result;
                }
                else
                {
                    problem2.GenerateProblem();
                    lb_Problem.Text = problem2.problem;
                    answer = problem2.CalValue().ConvertString();
                }
            }
        }

        private int GetRandomSeed()
        {
            byte[] bytes = new byte[10];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            string show = lb_Problem.Text + " = " + txb_Answer.Text;
            if (answer == txb_Answer.Text)
            {
                show += "   正确";
                correctCount++;
            }
            else
            {
                show += "   错误，正确答案为" + answer;
            }
            listBox1.Items.Add(show);
            timeCount = 20;
            if (probCount == num)
            {
                this.timer1.Stop();
                MessageBox.Show("你一共答对了" + correctCount.ToString() + "/" + num.ToString() + "道题，总分" + 100 / num * correctCount + "分");
                this.btn_Save.Enabled = false;
            }
            else
            {
                GenProb();
            }
            txb_Answer.Text = "";
        }
    }
}
