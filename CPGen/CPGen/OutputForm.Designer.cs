namespace CPGen
{
    partial class OutputForm
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
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Out = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Erabu = new System.Windows.Forms.ComboBox();
            this.cmb_SelectMod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Back.Location = new System.Drawing.Point(232, 318);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(84, 29);
            this.btn_Back.TabIndex = 0;
            this.btn_Back.Text = "返回";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // btn_Out
            // 
            this.btn_Out.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Out.Location = new System.Drawing.Point(442, 318);
            this.btn_Out.Name = "btn_Out";
            this.btn_Out.Size = new System.Drawing.Size(81, 29);
            this.btn_Out.TabIndex = 1;
            this.btn_Out.Text = "导出";
            this.btn_Out.UseVisualStyleBackColor = true;
            this.btn_Out.Click += new System.EventHandler(this.Btn_Out_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(267, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "试卷导出系统";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(126, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(469, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "请选择生成条件，系统会为你自动生成1000道试题。";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(126, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(519, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "输出文件格式格式为txt文件，且与该程序在同一文件夹。";
            // 
            // cmb_Erabu
            // 
            this.cmb_Erabu.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_Erabu.FormattingEnabled = true;
            this.cmb_Erabu.Location = new System.Drawing.Point(360, 159);
            this.cmb_Erabu.Name = "cmb_Erabu";
            this.cmb_Erabu.Size = new System.Drawing.Size(121, 24);
            this.cmb_Erabu.TabIndex = 5;
            this.cmb_Erabu.SelectedIndexChanged += new System.EventHandler(this.Cmb_Erabu_SelectedIndexChanged);
            // 
            // cmb_SelectMod
            // 
            this.cmb_SelectMod.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_SelectMod.FormattingEnabled = true;
            this.cmb_SelectMod.Location = new System.Drawing.Point(360, 227);
            this.cmb_SelectMod.Name = "cmb_SelectMod";
            this.cmb_SelectMod.Size = new System.Drawing.Size(121, 24);
            this.cmb_SelectMod.TabIndex = 6;
            this.cmb_SelectMod.SelectedIndexChanged += new System.EventHandler(this.Cmb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(250, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "选择题型：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(250, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "是否带乘方：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(235, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "*注：真分数运算中无乘方运算。";
            // 
            // OutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_SelectMod);
            this.Controls.Add(this.cmb_Erabu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Out);
            this.Controls.Add(this.btn_Back);
            this.Name = "OutputForm";
            this.Text = "OutputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Out;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Erabu;
        private System.Windows.Forms.ComboBox cmb_SelectMod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}