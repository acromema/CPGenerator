namespace CPGen
{
    partial class AnsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Back = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_Time = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.lb_Problem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Answer = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Back.Location = new System.Drawing.Point(27, 135);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 0;
            this.btn_Back.Text = "返回";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Location = new System.Drawing.Point(61, 34);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(41, 12);
            this.lb_Time.TabIndex = 1;
            this.lb_Time.Text = "label1";
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Start.Location = new System.Drawing.Point(27, 91);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "开始";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // lb_Problem
            // 
            this.lb_Problem.AutoSize = true;
            this.lb_Problem.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Problem.Location = new System.Drawing.Point(108, 127);
            this.lb_Problem.Name = "lb_Problem";
            this.lb_Problem.Size = new System.Drawing.Size(56, 16);
            this.lb_Problem.TabIndex = 3;
            this.lb_Problem.Text = "label1";
            this.lb_Problem.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(533, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // txb_Answer
            // 
            this.txb_Answer.Location = new System.Drawing.Point(570, 122);
            this.txb_Answer.Name = "txb_Answer";
            this.txb_Answer.Size = new System.Drawing.Size(100, 21);
            this.txb_Answer.TabIndex = 5;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Save.Location = new System.Drawing.Point(692, 120);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "确认";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(111, 196);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(556, 242);
            this.listBox1.TabIndex = 8;
            // 
            // AnsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txb_Answer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Problem);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.lb_Time);
            this.Controls.Add(this.btn_Back);
            this.Name = "AnsForm";
            this.Text = "AnsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label lb_Problem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_Answer;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ListBox listBox1;
    }
}