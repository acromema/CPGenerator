using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPGen
{
    public partial class Form1 : Form
    {
        public static Form f;
        public Form1()
        {
            InitializeComponent();
            f = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Output_Click(object sender, EventArgs e)
        {
            OutputForm form = new OutputForm();
            form.Show();
            this.Hide();
        }

        private void Btn_Test_Click(object sender, EventArgs e)
        {
            AnsSystem form = new AnsSystem();
            form.Show();
            this.Hide();
        }
    }
}
