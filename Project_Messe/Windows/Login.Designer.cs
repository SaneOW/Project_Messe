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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(131, 71);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 126, 249);
            label2.Location = new Point(131, 191);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // button_Login
            // 
            button_Login.BackColor = Color.FromArgb(74, 79, 99);
            button_Login.FlatAppearance.BorderSize = 0;
            button_Login.FlatStyle = FlatStyle.Flat;
            button_Login.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Login.ForeColor = Color.FromArgb(0, 126, 249);
            button_Login.Location = new Point(34, 381);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(91, 42);
            button_Login.TabIndex = 2;
            button_Login.Text = "Login";
            button_Login.UseVisualStyleBackColor = false;
            button_Login.Click += button_Login_Click;
            // 
            // button_Reset
            // 
            button_Reset.BackColor = Color.FromArgb(74, 79, 99);
            button_Reset.FlatAppearance.BorderSize = 0;
            button_Reset.FlatStyle = FlatStyle.Flat;
            button_Reset.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Reset.ForeColor = Color.FromArgb(0, 126, 249);
            button_Reset.Location = new Point(178, 381);
            button_Reset.Name = "button_Reset";
            button_Reset.Size = new Size(86, 42);
            button_Reset.TabIndex = 3;
            button_Reset.Text = "Reset";
            button_Reset.UseVisualStyleBackColor = false;
            button_Reset.Click += button_Reset_Click;
            // 
            // button_Exit
            // 
            button_Exit.BackColor = Color.FromArgb(74, 79, 99);
            button_Exit.FlatAppearance.BorderSize = 0;
            button_Exit.FlatStyle = FlatStyle.Flat;
            button_Exit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Exit.ForeColor = Color.FromArgb(0, 126, 249);
            button_Exit.Location = new Point(322, 381);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(84, 42);
            button_Exit.TabIndex = 4;
            button_Exit.Text = "Exit";
            button_Exit.UseVisualStyleBackColor = false;
            button_Exit.Click += button_Exit_Click;
            // 
            // textBox_Username
            // 
            textBox_Username.BackColor = Color.FromArgb(74, 79, 99);
            textBox_Username.BorderStyle = BorderStyle.None;
            textBox_Username.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_Username.ForeColor = Color.FromArgb(0, 126, 249);
            textBox_Username.Location = new Point(217, 71);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(166, 26);
            textBox_Username.TabIndex = 5;
            // 
            // textBox_Password
            // 
            textBox_Password.BackColor = Color.FromArgb(74, 79, 99);
            textBox_Password.BorderStyle = BorderStyle.None;
            textBox_Password.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_Password.ForeColor = Color.FromArgb(0, 126, 249);
            textBox_Password.Location = new Point(213, 187);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(166, 26);
            textBox_Password.TabIndex = 6;
            textBox_Password.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox_Password);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox_Username);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 361);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.username_1;
            pictureBox1.Location = new Point(41, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.password_76;
            pictureBox2.Location = new Point(41, 157);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(84, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(446, 450);
            Controls.Add(button_Exit);
            Controls.Add(button_Reset);
            Controls.Add(button_Login);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button_Login;
        private Button button_Reset;
        private Button button_Exit;
        private TextBox textBox_Username;
        private TextBox textBox_Password;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}