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
using System.IO;

namespace CPGen
{
    public partial class OutputForm : Form
    {
        public OutputForm()
        {
            InitializeComponent();

            this.ControlBox = false;

            this.cmb_Erabu.Items.Add("整数运算");
            this.cmb_Erabu.SelectedIndex = 0;
            this.cmb_Erabu.Items.Add("真分数运算");
            this.cmb_Erabu.SelectedIndex = 1;
            this.cmb_Erabu.Items.Add("两者都有");
            this.cmb_Erabu.SelectedIndex = 2;
            this.cmb_Erabu.SelectedIndex = this.cmb_Erabu.Items.IndexOf("整数运算");
            this.cmb_Erabu.DropDownStyle = ComboBoxStyle.DropDownList;

            this.cmb_SelectMod.Items.Add("不带乘方");
            this.cmb_SelectMod.SelectedIndex = 0;
            this.cmb_SelectMod.Items.Add("用**表示乘方");
            this.cmb_SelectMod.SelectedIndex = 1;
            this.cmb_SelectMod.Items.Add("用^表示乘方");
            this.cmb_SelectMod.SelectedIndex = 2;
            this.cmb_SelectMod.SelectedIndex = this.cmb_SelectMod.Items.IndexOf("不带乘方");
            this.cmb_SelectMod.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        IntGen problem1 = new IntGen();
        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.f.Show();
        }

        private void Cmb_Erabu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cmb_Erabu.SelectedIndex == 1)
            {
                this.cmb_SelectMod.SelectedIndex = this.cmb_SelectMod.Items.IndexOf("不带乘方");
            }
        }

        private void Btn_Out_Click(object sender, EventArgs e)
        {
            string fileName = "小学生难题1000道.txt";
            string newPath = AppDomain.CurrentDomain.BaseDirectory + fileName;
            StreamWriter streamWriter = new StreamWriter(newPath, false, Encoding.Default);

            if (this.cmb_Erabu.SelectedIndex==0)
            {
                
                for (int i = 0; i < 1000; i++)
                {
                    problem1.GenerateProblem();
                    streamWriter.WriteLine(problem1.Problem);
                    //streamWriter.WriteLine(i);
                }
               
            }
            else if(this.cmb_Erabu.SelectedIndex == 1)
            {
                Problem problem = new Problem();
                for (int i = 0; i < 1000; i++)
                {
                    problem.GenerateProblem();
                    streamWriter.WriteLine(problem.problem);
                    //streamWriter.WriteLine(i);
                }
            }
            else
            {
                //IntGen problem1 = new IntGen();
                Problem problem2 = new Problem();
                for (int i = 0; i < 1000; i++)
                {
                    Random rand = new Random(GetRandomSeed());
                    int a = rand.Next(2);
                    if(a == 1)
                    {
                        problem1.GenerateProblem();
                        streamWriter.WriteLine(problem1.Problem);
                    }
                    else
                    {
                        problem2.GenerateProblem();
                        streamWriter.WriteLine(problem2.problem);
                    }
                    //streamWriter.WriteLine(i);
                }
            }
            streamWriter.Flush();
            streamWriter.Close();
            MessageBox.Show("导出成功！");
            this.Close();
            Form1.f.Show();
        }

        private int GetRandomSeed()
        {
            byte[] bytes = new byte[10];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }

        private void Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmb_Erabu.SelectedIndex == 1)
            {
                if(this.cmb_SelectMod.SelectedIndex == 1|| this.cmb_SelectMod.SelectedIndex == 2)
                {
                    this.cmb_SelectMod.SelectedIndex = this.cmb_SelectMod.Items.IndexOf("不带乘方");
                }
                problem1.Mod = 0;
            }
            else
            {
                if(this.cmb_SelectMod.SelectedIndex == 0)
                {
                    problem1.Mod = 0;
                }
                else if (this.cmb_SelectMod.SelectedIndex == 1)
                {
                    problem1.Mod = 1;
                }
                else
                {
                    problem1.Mod = 2;
                }
            }
        }
    }
}
