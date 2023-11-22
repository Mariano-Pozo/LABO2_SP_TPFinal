namespace Form1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label_exit = new Label();
            label_clear = new Label();
            textBox_username = new TextBox();
            textBox_password = new TextBox();
            button_login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(543, 48);
            label1.Name = "label1";
            label1.Size = new Size(106, 40);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(336, 168);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 2;
            label2.Text = "USERNAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(335, 229);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 3;
            label3.Text = "PASSWORD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(43, 168);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 8;
            label4.Text = "Action House";
            // 
            // label_exit
            // 
            label_exit.AutoSize = true;
            label_exit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_exit.Location = new Point(775, 0);
            label_exit.Name = "label_exit";
            label_exit.Size = new Size(24, 25);
            label_exit.TabIndex = 9;
            label_exit.Text = "X";
            label_exit.Click += label_exit_Click;
            label_exit.MouseEnter += label_exit_MouseEnter;
            label_exit.MouseLeave += label_exit_MouseLeave;
            
            // 
            // label_clear
            // 
            label_clear.AutoSize = true;
            label_clear.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label_clear.Location = new Point(568, 368);
            label_clear.Name = "label_clear";
            label_clear.Size = new Size(57, 25);
            label_clear.TabIndex = 10;
            label_clear.Text = "Clear";
            label_clear.Click += label_clear_Click;
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(504, 169);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(184, 23);
            textBox_username.TabIndex = 11;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(504, 229);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(184, 23);
            textBox_password.TabIndex = 12;
            textBox_password.UseSystemPasswordChar = true;
            // 
            // button_login
            // 
            button_login.Location = new Point(550, 301);
            button_login.Name = "button_login";
            button_login.Size = new Size(92, 28);
            button_login.TabIndex = 14;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_login);
            Controls.Add(textBox_password);
            Controls.Add(textBox_username);
            Controls.Add(label_clear);
            Controls.Add(label_exit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label_exit;
        private Label label_clear;
        private TextBox textBox_username;
        private TextBox textBox_password;
        private Button button_login;
    }
}