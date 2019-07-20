namespace RDPdemo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.remoteUsernameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.remotePasswordTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.remoteConnectionAddressCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdpFileNameTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IPAddress:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "UserName:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // remoteUsernameTB
            // 
            this.remoteUsernameTB.Location = new System.Drawing.Point(155, 136);
            this.remoteUsernameTB.Name = "remoteUsernameTB";
            this.remoteUsernameTB.Size = new System.Drawing.Size(150, 20);
            this.remoteUsernameTB.TabIndex = 1;
            this.remoteUsernameTB.Text = "admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // remotePasswordTB
            // 
            this.remotePasswordTB.Location = new System.Drawing.Point(155, 183);
            this.remotePasswordTB.Name = "remotePasswordTB";
            this.remotePasswordTB.Size = new System.Drawing.Size(150, 20);
            this.remotePasswordTB.TabIndex = 1;
            this.remotePasswordTB.Text = "admin";
            this.remotePasswordTB.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // remoteConnectionAddressCB
            // 
            this.remoteConnectionAddressCB.FormattingEnabled = true;
            this.remoteConnectionAddressCB.Location = new System.Drawing.Point(155, 40);
            this.remoteConnectionAddressCB.Name = "remoteConnectionAddressCB";
            this.remoteConnectionAddressCB.Size = new System.Drawing.Size(150, 21);
            this.remoteConnectionAddressCB.TabIndex = 3;
            this.remoteConnectionAddressCB.Text = "10.0.2.15";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "FileName:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdpFileNameTB
            // 
            this.rdpFileNameTB.Location = new System.Drawing.Point(156, 88);
            this.rdpFileNameTB.Name = "rdpFileNameTB";
            this.rdpFileNameTB.Size = new System.Drawing.Size(150, 20);
            this.rdpFileNameTB.TabIndex = 1;
            this.rdpFileNameTB.Text = "ceshi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Generate a rdp file which name is filename under bin folder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 284);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.remoteConnectionAddressCB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.remotePasswordTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdpFileNameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.remoteUsernameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Connection demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox remoteUsernameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox remotePasswordTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox remoteConnectionAddressCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rdpFileNameTB;
        private System.Windows.Forms.Label label5;
    }
}

