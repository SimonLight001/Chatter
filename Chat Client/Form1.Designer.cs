namespace Chat_Client
{
    partial class Form1
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
            this.Client1 = new System.Windows.Forms.GroupBox();
            this.textBoxCl1ip = new System.Windows.Forms.TextBox();
            this.textBoxCl1port = new System.Windows.Forms.TextBox();
            this.Client2 = new System.Windows.Forms.GroupBox();
            this.textBoxCl2port = new System.Windows.Forms.TextBox();
            this.textBoxCl2ip = new System.Windows.Forms.TextBox();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.Client1.SuspendLayout();
            this.Client2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Client1
            // 
            this.Client1.Controls.Add(this.label2);
            this.Client1.Controls.Add(this.label1);
            this.Client1.Controls.Add(this.textBoxCl1port);
            this.Client1.Controls.Add(this.textBoxCl1ip);
            this.Client1.Location = new System.Drawing.Point(12, 12);
            this.Client1.Name = "Client1";
            this.Client1.Size = new System.Drawing.Size(220, 100);
            this.Client1.TabIndex = 0;
            this.Client1.TabStop = false;
            this.Client1.Text = "Client 1";
            // 
            // textBoxCl1ip
            // 
            this.textBoxCl1ip.Location = new System.Drawing.Point(47, 20);
            this.textBoxCl1ip.Name = "textBoxCl1ip";
            this.textBoxCl1ip.Size = new System.Drawing.Size(150, 20);
            this.textBoxCl1ip.TabIndex = 0;
            // 
            // textBoxCl1port
            // 
            this.textBoxCl1port.Location = new System.Drawing.Point(47, 52);
            this.textBoxCl1port.Name = "textBoxCl1port";
            this.textBoxCl1port.Size = new System.Drawing.Size(150, 20);
            this.textBoxCl1port.TabIndex = 1;
            // 
            // Client2
            // 
            this.Client2.Controls.Add(this.label4);
            this.Client2.Controls.Add(this.label3);
            this.Client2.Controls.Add(this.textBoxCl2port);
            this.Client2.Controls.Add(this.textBoxCl2ip);
            this.Client2.Location = new System.Drawing.Point(257, 12);
            this.Client2.Name = "Client2";
            this.Client2.Size = new System.Drawing.Size(220, 100);
            this.Client2.TabIndex = 2;
            this.Client2.TabStop = false;
            this.Client2.Text = "Client 2";
            // 
            // textBoxCl2port
            // 
            this.textBoxCl2port.Location = new System.Drawing.Point(50, 45);
            this.textBoxCl2port.Name = "textBoxCl2port";
            this.textBoxCl2port.Size = new System.Drawing.Size(150, 20);
            this.textBoxCl2port.TabIndex = 1;
            // 
            // textBoxCl2ip
            // 
            this.textBoxCl2ip.Location = new System.Drawing.Point(50, 19);
            this.textBoxCl2ip.Name = "textBoxCl2ip";
            this.textBoxCl2ip.Size = new System.Drawing.Size(150, 20);
            this.textBoxCl2ip.TabIndex = 0;
            // 
            // listMessage
            // 
            this.listMessage.FormattingEnabled = true;
            this.listMessage.Location = new System.Drawing.Point(12, 147);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(465, 95);
            this.listMessage.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(402, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Port";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(12, 250);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(384, 20);
            this.textBoxMessage.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 290);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.Client2);
            this.Controls.Add(this.Client1);
            this.Name = "Form1";
            this.Text = "Chat Client";
            this.Client1.ResumeLayout(false);
            this.Client1.PerformLayout();
            this.Client2.ResumeLayout(false);
            this.Client2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Client1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCl1port;
        private System.Windows.Forms.TextBox textBoxCl1ip;
        private System.Windows.Forms.GroupBox Client2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCl2port;
        private System.Windows.Forms.TextBox textBoxCl2ip;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxMessage;
    }
}

