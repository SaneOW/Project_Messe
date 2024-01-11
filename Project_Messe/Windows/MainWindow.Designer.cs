namespace Project_Messe
{
    partial class MainWindow
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
            button_Speichern = new Button();
            text_Vorname = new TextBox();
            text_Nachname = new TextBox();
            text_Straße = new TextBox();
            text_Hausnummer = new TextBox();
            text_Postleitzahl = new TextBox();
            text_Stadt = new TextBox();
            pictureBox1 = new PictureBox();
            button_Picture = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            text_Land = new TextBox();
            radio_Autos_yes = new RadioButton();
            groupBox1 = new GroupBox();
            radio_Autos_no = new RadioButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupbox_Smartphones = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupbox_Laptops = new GroupBox();
            radio_Laptops_no = new RadioButton();
            radio_Laptops_yes = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupbox_Smartphones.SuspendLayout();
            groupbox_Laptops.SuspendLayout();
            SuspendLayout();
            // 
            // button_Speichern
            // 
            button_Speichern.Location = new Point(666, 388);
            button_Speichern.Name = "button_Speichern";
            button_Speichern.Size = new Size(75, 23);
            button_Speichern.TabIndex = 0;
            button_Speichern.Text = "Speichern";
            button_Speichern.UseVisualStyleBackColor = true;
            button_Speichern.Click += button_Speichern_Click;
            // 
            // text_Vorname
            // 
            text_Vorname.Location = new Point(86, 39);
            text_Vorname.Name = "text_Vorname";
            text_Vorname.Size = new Size(138, 23);
            text_Vorname.TabIndex = 1;
            // 
            // text_Nachname
            // 
            text_Nachname.Location = new Point(307, 39);
            text_Nachname.Name = "text_Nachname";
            text_Nachname.Size = new Size(138, 23);
            text_Nachname.TabIndex = 2;
            // 
            // text_Straße
            // 
            text_Straße.Location = new Point(86, 80);
            text_Straße.Name = "text_Straße";
            text_Straße.Size = new Size(215, 23);
            text_Straße.TabIndex = 3;
            // 
            // text_Hausnummer
            // 
            text_Hausnummer.Location = new Point(391, 80);
            text_Hausnummer.Name = "text_Hausnummer";
            text_Hausnummer.Size = new Size(54, 23);
            text_Hausnummer.TabIndex = 4;
            // 
            // text_Postleitzahl
            // 
            text_Postleitzahl.Location = new Point(86, 119);
            text_Postleitzahl.Name = "text_Postleitzahl";
            text_Postleitzahl.Size = new Size(100, 23);
            text_Postleitzahl.TabIndex = 5;
            // 
            // text_Stadt
            // 
            text_Stadt.Location = new Point(232, 119);
            text_Stadt.Name = "text_Stadt";
            text_Stadt.Size = new Size(213, 23);
            text_Stadt.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(473, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 172);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button_Picture
            // 
            button_Picture.Location = new Point(569, 229);
            button_Picture.Name = "button_Picture";
            button_Picture.Size = new Size(113, 23);
            button_Picture.TabIndex = 8;
            button_Picture.Text = "Foto aufnehmen";
            button_Picture.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 42);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 10;
            label1.Text = "Vorname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 42);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 11;
            label2.Text = "Nachname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 83);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 12;
            label3.Text = "Straße";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 122);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 13;
            label4.Text = "Postleitzahl";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(307, 83);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 14;
            label5.Text = "Hausnummer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(192, 122);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 15;
            label6.Text = "Stadt";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 161);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 16;
            label7.Text = "Land";
            // 
            // text_Land
            // 
            text_Land.Location = new Point(85, 158);
            text_Land.Name = "text_Land";
            text_Land.Size = new Size(100, 23);
            text_Land.TabIndex = 17;
            // 
            // radio_Autos_yes
            // 
            radio_Autos_yes.AutoSize = true;
            radio_Autos_yes.Location = new Point(7, 22);
            radio_Autos_yes.Name = "radio_Autos_yes";
            radio_Autos_yes.Size = new Size(35, 19);
            radio_Autos_yes.TabIndex = 18;
            radio_Autos_yes.TabStop = true;
            radio_Autos_yes.Text = "Ja";
            radio_Autos_yes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radio_Autos_no);
            groupBox1.Controls.Add(radio_Autos_yes);
            groupBox1.Location = new Point(85, 222);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(139, 50);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Autos";
            // 
            // radio_Autos_no
            // 
            radio_Autos_no.AutoSize = true;
            radio_Autos_no.Location = new Point(61, 22);
            radio_Autos_no.Name = "radio_Autos_no";
            radio_Autos_no.Size = new Size(50, 19);
            radio_Autos_no.TabIndex = 19;
            radio_Autos_no.TabStop = true;
            radio_Autos_no.Text = "Nein";
            radio_Autos_no.UseVisualStyleBackColor = true;
            // 
            // groupbox_Smartphones
            // 
            groupbox_Smartphones.Controls.Add(radioButton1);
            groupbox_Smartphones.Controls.Add(radioButton2);
            groupbox_Smartphones.Location = new Point(86, 334);
            groupbox_Smartphones.Name = "groupbox_Smartphones";
            groupbox_Smartphones.Size = new Size(138, 50);
            groupbox_Smartphones.TabIndex = 24;
            groupbox_Smartphones.TabStop = false;
            groupbox_Smartphones.Text = "Smartphones";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(60, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(50, 19);
            radioButton1.TabIndex = 29;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nein";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(35, 19);
            radioButton2.TabIndex = 28;
            radioButton2.TabStop = true;
            radioButton2.Text = "Ja";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupbox_Laptops
            // 
            groupbox_Laptops.Controls.Add(radio_Laptops_no);
            groupbox_Laptops.Controls.Add(radio_Laptops_yes);
            groupbox_Laptops.Location = new Point(86, 278);
            groupbox_Laptops.Name = "groupbox_Laptops";
            groupbox_Laptops.Size = new Size(138, 50);
            groupbox_Laptops.TabIndex = 25;
            groupbox_Laptops.TabStop = false;
            groupbox_Laptops.Text = "Laptops";
            // 
            // radio_Laptops_no
            // 
            radio_Laptops_no.AutoSize = true;
            radio_Laptops_no.Location = new Point(60, 22);
            radio_Laptops_no.Name = "radio_Laptops_no";
            radio_Laptops_no.Size = new Size(50, 19);
            radio_Laptops_no.TabIndex = 27;
            radio_Laptops_no.TabStop = true;
            radio_Laptops_no.Text = "Nein";
            radio_Laptops_no.UseVisualStyleBackColor = true;
            // 
            // radio_Laptops_yes
            // 
            radio_Laptops_yes.AutoSize = true;
            radio_Laptops_yes.Location = new Point(6, 22);
            radio_Laptops_yes.Name = "radio_Laptops_yes";
            radio_Laptops_yes.Size = new Size(35, 19);
            radio_Laptops_yes.TabIndex = 26;
            radio_Laptops_yes.TabStop = true;
            radio_Laptops_yes.Text = "Ja";
            radio_Laptops_yes.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(groupbox_Laptops);
            Controls.Add(groupbox_Smartphones);
            Controls.Add(groupBox1);
            Controls.Add(text_Land);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_Picture);
            Controls.Add(pictureBox1);
            Controls.Add(text_Stadt);
            Controls.Add(text_Postleitzahl);
            Controls.Add(text_Hausnummer);
            Controls.Add(text_Straße);
            Controls.Add(text_Nachname);
            Controls.Add(text_Vorname);
            Controls.Add(button_Speichern);
            Name = "MainWindow";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupbox_Smartphones.ResumeLayout(false);
            groupbox_Smartphones.PerformLayout();
            groupbox_Laptops.ResumeLayout(false);
            groupbox_Laptops.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Speichern;
        private TextBox text_Vorname;
        private TextBox text_Nachname;
        private TextBox text_Straße;
        private TextBox text_Hausnummer;
        private TextBox text_Postleitzahl;
        private TextBox text_Stadt;
        private PictureBox pictureBox1;
        private Button button_Picture;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox text_Land;
        private RadioButton radio_Autos_yes;
        private RadioButton radio_Laptops;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupbox_Smartphones;
        private GroupBox groupbox_Laptops;
        private RadioButton radio_Autos_no;
        private RadioButton radio_Laptops_no;
        private RadioButton radio_Laptops_yes;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}
