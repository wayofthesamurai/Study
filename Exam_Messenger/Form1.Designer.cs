
namespace Exam_Messenger
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SendMessenge = new System.Windows.Forms.Button();
            this.textBoxMessege = new System.Windows.Forms.TextBox();
            this.SaveAddresses = new System.Windows.Forms.ListBox();
            this.Connect = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.Nickname = new System.Windows.Forms.TextBox();
            this.Disconnect = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SendMessenge
            // 
            this.SendMessenge.Location = new System.Drawing.Point(713, 340);
            this.SendMessenge.Name = "SendMessenge";
            this.SendMessenge.Size = new System.Drawing.Size(75, 92);
            this.SendMessenge.TabIndex = 0;
            this.SendMessenge.Text = "Send";
            this.SendMessenge.UseVisualStyleBackColor = true;
            this.SendMessenge.Click += new System.EventHandler(this.SendMessenge_Click);
            // 
            // textBoxMessege
            // 
            this.textBoxMessege.Location = new System.Drawing.Point(166, 340);
            this.textBoxMessege.Multiline = true;
            this.textBoxMessege.Name = "textBoxMessege";
            this.textBoxMessege.Size = new System.Drawing.Size(541, 92);
            this.textBoxMessege.TabIndex = 1;
            this.textBoxMessege.Text = "Messege";
            // 
            // SaveAddresses
            // 
            this.SaveAddresses.FormattingEnabled = true;
            this.SaveAddresses.ItemHeight = 16;
            this.SaveAddresses.Location = new System.Drawing.Point(12, 12);
            this.SaveAddresses.Name = "SaveAddresses";
            this.SaveAddresses.Size = new System.Drawing.Size(148, 420);
            this.SaveAddresses.TabIndex = 2;
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(697, 9);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(91, 23);
            this.Connect.TabIndex = 3;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(167, 67);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(621, 260);
            this.listBox2.TabIndex = 4;
            // 
            // Nickname
            // 
            this.Nickname.Location = new System.Drawing.Point(584, 10);
            this.Nickname.Name = "Nickname";
            this.Nickname.Size = new System.Drawing.Size(107, 22);
            this.Nickname.TabIndex = 5;
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(697, 38);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(91, 23);
            this.Disconnect.TabIndex = 6;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(584, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(107, 22);
            this.textBox3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nickname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "IP-Address";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Disconnect);
            this.Controls.Add(this.Nickname);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.SaveAddresses);
            this.Controls.Add(this.textBoxMessege);
            this.Controls.Add(this.SendMessenge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendMessenge;
        private System.Windows.Forms.TextBox textBoxMessege;
        private System.Windows.Forms.ListBox SaveAddresses;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox Nickname;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

