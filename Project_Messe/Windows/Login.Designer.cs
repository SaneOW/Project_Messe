namespace Project_Messe.Windows
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            button_Login = new Button();
            button_Reset = new Button();
            button_Exit = new Button();
            textBox_Username = new TextBox();
            textBox_Password = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(99, 62);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(99, 122);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // button_Login
            // 
            button_Login.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button_Login.Location = new Point(82, 325);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(91, 42);
            button_Login.TabIndex = 2;
            button_Login.Text = "Login";
            button_Login.UseVisualStyleBackColor = true;
            button_Login.Click += button_Login_Click;
            // 
            // button_Reset
            // 
            button_Reset.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button_Reset.Location = new Point(192, 325);
            button_Reset.Name = "button_Reset";
            button_Reset.Size = new Size(86, 42);
            button_Reset.TabIndex = 3;
            button_Reset.Text = "Reset";
            button_Reset.UseVisualStyleBackColor = true;
            button_Reset.Click += button_Reset_Click;
            // 
            // button_Exit
            // 
            button_Exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button_Exit.Location = new Point(294, 325);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(84, 42);
            button_Exit.TabIndex = 4;
            button_Exit.Text = "Exit";
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // textBox_Username
            // 
            textBox_Username.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBox_Username.Location = new Point(178, 59);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(100, 23);
            textBox_Username.TabIndex = 5;
            // 
            // textBox_Password
            // 
            textBox_Password.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBox_Password.Location = new Point(178, 119);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(100, 23);
            textBox_Password.TabIndex = 6;
            textBox_Password.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(446, 450);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Username);
            Controls.Add(button_Exit);
            Controls.Add(button_Reset);
            Controls.Add(button_Login);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button_Login;
        private Button button_Reset;
        private Button button_Exit;
        private TextBox textBox_Username;
        private TextBox textBox_Password;
    }
}