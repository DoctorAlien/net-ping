namespace net_ping
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.listIPs = new System.Windows.Forms.ListBox();
            this.listPing = new System.Windows.Forms.ListBox();
            this.combNum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 40);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(300, 25);
            this.txtInput.TabIndex = 0;
            // 
            // txtHostname
            // 
            this.txtHostname.Location = new System.Drawing.Point(12, 110);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(300, 25);
            this.txtHostname.TabIndex = 1;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(333, 80);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(300, 55);
            this.btnClick.TabIndex = 2;
            this.btnClick.Text = "确定";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // listIPs
            // 
            this.listIPs.FormattingEnabled = true;
            this.listIPs.ItemHeight = 15;
            this.listIPs.Location = new System.Drawing.Point(12, 159);
            this.listIPs.Name = "listIPs";
            this.listIPs.Size = new System.Drawing.Size(300, 229);
            this.listIPs.TabIndex = 3;
            // 
            // listPing
            // 
            this.listPing.FormattingEnabled = true;
            this.listPing.ItemHeight = 15;
            this.listPing.Location = new System.Drawing.Point(333, 159);
            this.listPing.Name = "listPing";
            this.listPing.Size = new System.Drawing.Size(765, 229);
            this.listPing.TabIndex = 4;
            // 
            // combNum
            // 
            this.combNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combNum.FormattingEnabled = true;
            this.combNum.Location = new System.Drawing.Point(333, 40);
            this.combNum.Name = "combNum";
            this.combNum.Size = new System.Drawing.Size(300, 23);
            this.combNum.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "请输入IP地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "源地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ping次数";
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(653, 40);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(445, 95);
            this.btnPing.TabIndex = 9;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 400);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combNum);
            this.Controls.Add(this.listPing);
            this.Controls.Add(this.listIPs);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.txtHostname);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Net-Ping";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.ListBox listIPs;
        private System.Windows.Forms.ListBox listPing;
        private System.Windows.Forms.ComboBox combNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPing;
    }
}

