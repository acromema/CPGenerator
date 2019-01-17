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
    public partial class AnsSystem : Form
    {
        public AnsSystem()
        {
            InitializeComponent();

            this.ControlBox = false;
            ans = this;

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

            this.cmb_Num.Items.Add("5");
            this.cmb_Num.SelectedIndex = 0;
            this.cmb_Num.Items.Add("10");
            this.cmb_Num.SelectedIndex = 1;
            this.cmb_Num.Items.Add("20");
            this.cmb_Num.SelectedIndex = 2;
            this.cmb_Num.Items.Add("25");
            this.cmb_Num.SelectedIndex = 3;
            this.cmb_Num.Items.Add("50");
            this.cmb_Num.SelectedIndex = 4;
            this.cmb_Num.SelectedIndex = this.cmb_Num.Items.IndexOf("5");
            this.cmb_Num.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public static AnsSystem ans;
        IntGen problem1 = new IntGen();
        private void Cmb_Erabu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmb_Erabu.SelectedIndex == 1)
            {
                this.cmb_SelectMod.SelectedIndex = this.cmb_SelectMod.Items.IndexOf("不带乘方");
            }
        }

        private void Cmb_SelectMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmb_Erabu.SelectedIndex == 1)
            {
                if (this.cmb_SelectMod.SelectedIndex == 1 || this.cmb_SelectMod.SelectedIndex == 2)
                {
                    this.cmb_SelectMod.SelectedIndex = this.cmb_SelectMod.Items.IndexOf("不带乘方");
                }
                problem1.Mod = 0;
            }
            else
            {
                if (this.cmb_SelectMod.SelectedIndex == 0)
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

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.f.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnsForm ansForm = new AnsForm();
            ansForm.Show();
        }
    }
}
