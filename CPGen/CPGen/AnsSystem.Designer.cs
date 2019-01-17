namespace CPGen
{
    partial class AnsSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_SelectMod = new System.Windows.Forms.ComboBox();
            this.cmb_Erabu = new System.Windows.Forms.ComboBox();
            this.cmb_Num = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(263, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "在线答题系统";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(215, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "请选择题型和题目数量。";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(217, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "*注：真分数运算中无乘方运算。";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(232, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "是否带乘方：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(232, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "选择题型：";
            // 
            // cmb_SelectMod
            // 
            this.cmb_SelectMod.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_SelectMod.FormattingEnabled = true;
            this.cmb_SelectMod.Location = new System.Drawing.Point(342, 191);
            this.cmb_SelectMod.Name = "cmb_SelectMod";
            this.cmb_SelectMod.Size = new System.Drawing.Size(121, 24);
            this.cmb_SelectMod.TabIndex = 11;
            this.cmb_SelectMod.SelectedIndexChanged += new System.EventHandler(this.Cmb_SelectMod_SelectedIndexChanged);
            // 
            // cmb_Erabu
            // 
            this.cmb_Erabu.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_Erabu.FormattingEnabled = true;
            this.cmb_Erabu.Location = new System.Drawing.Point(342, 161);
            this.cmb_Erabu.Name = "cmb_Erabu";
            this.cmb_Erabu.Size = new System.Drawing.Size(121, 24);
            this.cmb_Erabu.TabIndex = 10;
            this.cmb_Erabu.SelectedIndexChanged += new System.EventHandler(this.Cmb_Erabu_SelectedIndexChanged);
            // 
            // cmb_Num
            // 
            this.cmb_Num.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_Num.FormattingEnabled = true;
            this.cmb_Num.Location = new System.Drawing.Point(342, 131);
            this.cmb_Num.Name = "cmb_Num";
            this.cmb_Num.Size = new System.Drawing.Size(121, 24);
            this.cmb_Num.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(232, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "选择数量：";
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Back.Location = new System.Drawing.Point(169, 297);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(84, 29);
            this.btn_Back.TabIndex = 17;
            this.btn_Back.Text = "返回";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(460, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "进入系统";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(217, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "*注：每小题你有20s时间来作答。";
            // 
            // AnsSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_Num);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_SelectMod);
            this.Controls.Add(this.cmb_Erabu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AnsSystem";
            this.Text = "AnsSystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cmb_SelectMod;
        public System.Windows.Forms.ComboBox cmb_Erabu;
        public System.Windows.Forms.ComboBox cmb_Num;
    }
}