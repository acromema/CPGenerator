namespace CPGen
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Output = new System.Windows.Forms.Button();
            this.btn_Test = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Output
            // 
            this.btn_Output.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Output.Location = new System.Drawing.Point(334, 203);
            this.btn_Output.Name = "btn_Output";
            this.btn_Output.Size = new System.Drawing.Size(96, 51);
            this.btn_Output.TabIndex = 0;
            this.btn_Output.Text = "导出试题";
            this.btn_Output.UseVisualStyleBackColor = true;
            this.btn_Output.Click += new System.EventHandler(this.Btn_Output_Click);
            // 
            // btn_Test
            // 
            this.btn_Test.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Test.Location = new System.Drawing.Point(334, 290);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(96, 51);
            this.btn_Test.TabIndex = 1;
            this.btn_Test.Text = "在线答题";
            this.btn_Test.UseVisualStyleBackColor = true;
            this.btn_Test.Click += new System.EventHandler(this.Btn_Test_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(246, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "四则运算生成器";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(308, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "请选择操作按钮";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Test);
            this.Controls.Add(this.btn_Output);
            this.Name = "Form1";
            this.Text = "四则运算生成器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Output;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

