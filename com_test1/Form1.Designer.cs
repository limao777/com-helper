namespace com_test1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.com1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_send = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tb2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_set_com = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_set_com = new System.Windows.Forms.Button();
            this.btn_close_com = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // com1
            // 
            this.com1.ReadTimeout = 100;
            this.com1.WriteTimeout = 2000;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(204, 8);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "发送";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(10, 10);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(188, 21);
            this.tb1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.t1_tick);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(10, 76);
            this.tb2.Multiline = true;
            this.tb2.Name = "tb2";
            this.tb2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb2.Size = new System.Drawing.Size(260, 133);
            this.tb2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // tb_set_com
            // 
            this.tb_set_com.Location = new System.Drawing.Point(10, 42);
            this.tb_set_com.Name = "tb_set_com";
            this.tb_set_com.Size = new System.Drawing.Size(43, 21);
            this.tb_set_com.TabIndex = 4;
            this.tb_set_com.Text = "COM1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "COM1";
            // 
            // btn_set_com
            // 
            this.btn_set_com.Location = new System.Drawing.Point(59, 40);
            this.btn_set_com.Name = "btn_set_com";
            this.btn_set_com.Size = new System.Drawing.Size(44, 23);
            this.btn_set_com.TabIndex = 6;
            this.btn_set_com.Text = "打开";
            this.btn_set_com.UseVisualStyleBackColor = true;
            this.btn_set_com.Click += new System.EventHandler(this.btn_set_com_Click);
            // 
            // btn_close_com
            // 
            this.btn_close_com.Location = new System.Drawing.Point(109, 40);
            this.btn_close_com.Name = "btn_close_com";
            this.btn_close_com.Size = new System.Drawing.Size(85, 23);
            this.btn_close_com.TabIndex = 7;
            this.btn_close_com.Text = "关闭";
            this.btn_close_com.UseVisualStyleBackColor = true;
            this.btn_close_com.Click += new System.EventHandler(this.btn_close_com_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_close_com);
            this.Controls.Add(this.btn_set_com);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_set_com);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.btn_send);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort com1;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_set_com;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_set_com;
        private System.Windows.Forms.Button btn_close_com;
    }
}

