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
            pictureBoxVideo = new PictureBox();
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
            radio_Smartphones = new RadioButton();
            groupbox_Laptops = new GroupBox();
            radio_Laptops_no = new RadioButton();
            radio_Laptops_yes = new RadioButton();
            comboBoxCameraList = new ComboBox();
            buttonSelectCamera = new Button();
            button_retry = new Button();
            button1 = new Button();
            panel1 = new Panel();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVideo).BeginInit();
            groupBox1.SuspendLayout();
            groupbox_Smartphones.SuspendLayout();
            groupbox_Laptops.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button_Speichern
            // 
            button_Speichern.BackColor = Color.FromArgb(74, 79, 99);
            button_Speichern.FlatAppearance.BorderSize = 0;
            button_Speichern.FlatStyle = FlatStyle.Flat;
            button_Speichern.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            button_Speichern.ForeColor = Color.FromArgb(0, 126, 249);
            button_Speichern.Location = new Point(653, 361);
            button_Speichern.Name = "button_Speichern";
            button_Speichern.Size = new Size(122, 23);
            button_Speichern.TabIndex = 0;
            button_Speichern.Text = "Speichern";
            button_Speichern.UseVisualStyleBackColor = false;
            button_Speichern.Click += button_Speichern_Click;
            // 
            // text_Vorname
            // 
            text_Vorname.BackColor = Color.FromArgb(74, 79, 99);
            text_Vorname.BorderStyle = BorderStyle.None;
            text_Vorname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_Vorname.Location = new Point(82, 43);
            text_Vorname.Name = "text_Vorname";
            text_Vorname.Size = new Size(138, 22);
            text_Vorname.TabIndex = 1;
            // 
            // text_Nachname
            // 
            text_Nachname.BackColor = Color.FromArgb(74, 79, 99);
            text_Nachname.BorderStyle = BorderStyle.None;
            text_Nachname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_Nachname.Location = new Point(323, 39);
            text_Nachname.Name = "text_Nachname";
            text_Nachname.Size = new Size(138, 22);
            text_Nachname.TabIndex = 2;
            // 
            // text_Straße
            // 
            text_Straße.BackColor = Color.FromArgb(74, 79, 99);
            text_Straße.BorderStyle = BorderStyle.None;
            text_Straße.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_Straße.Location = new Point(67, 79);
            text_Straße.Name = "text_Straße";
            text_Straße.Size = new Size(215, 22);
            text_Straße.TabIndex = 3;
            // 
            // text_Hausnummer
            // 
            text_Hausnummer.BackColor = Color.FromArgb(74, 79, 99);
            text_Hausnummer.BorderStyle = BorderStyle.None;
            text_Hausnummer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_Hausnummer.Location = new Point(406, 79);
            text_Hausnummer.Name = "text_Hausnummer";
            text_Hausnummer.Size = new Size(44, 22);
            text_Hausnummer.TabIndex = 4;
            // 
            // text_Postleitzahl
            // 
            text_Postleitzahl.BackColor = Color.FromArgb(74, 79, 99);
            text_Postleitzahl.BorderStyle = BorderStyle.None;
            text_Postleitzahl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_Postleitzahl.Location = new Point(100, 114);
            text_Postleitzahl.Name = "text_Postleitzahl";
            text_Postleitzahl.Size = new Size(100, 22);
            text_Postleitzahl.TabIndex = 5;
            // 
            // text_Stadt
            // 
            text_Stadt.BackColor = Color.FromArgb(74, 79, 99);
            text_Stadt.BorderStyle = BorderStyle.None;
            text_Stadt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_Stadt.Location = new Point(254, 116);
            text_Stadt.Name = "text_Stadt";
            text_Stadt.Size = new Size(207, 22);
            text_Stadt.TabIndex = 6;
            // 
            // pictureBoxVideo
            // 
            pictureBoxVideo.Location = new Point(473, 47);
            pictureBoxVideo.Name = "pictureBoxVideo";
            pictureBoxVideo.Size = new Size(302, 172);
            pictureBoxVideo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxVideo.TabIndex = 7;
            pictureBoxVideo.TabStop = false;
            // 
            // button_Picture
            // 
            button_Picture.BackColor = Color.FromArgb(74, 79, 99);
            button_Picture.FlatAppearance.BorderSize = 0;
            button_Picture.FlatStyle = FlatStyle.Flat;
            button_Picture.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            button_Picture.ForeColor = Color.FromArgb(0, 126, 249);
            button_Picture.Location = new Point(569, 229);
            button_Picture.Name = "button_Picture";
            button_Picture.Size = new Size(113, 23);
            button_Picture.TabIndex = 8;
            button_Picture.Text = "Foto aufnehmen";
            button_Picture.UseVisualStyleBackColor = false;
            button_Picture.Click += button_Picture_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(24, 30, 54);
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 10;
            label1.Text = "Vorname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(24, 30, 54);
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 126, 249);
            label2.Location = new Point(236, 42);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 11;
            label2.Text = "Nachname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 126, 249);
            label3.Location = new Point(12, 83);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 12;
            label3.Text = "Straße";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 126, 249);
            label4.Location = new Point(12, 116);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 13;
            label4.Text = "Postleitzahl";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 126, 249);
            label5.Location = new Point(307, 83);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 14;
            label5.Text = "Hausnummer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 126, 249);
            label6.Location = new Point(208, 121);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 15;
            label6.Text = "Stadt";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 126, 249);
            label7.Location = new Point(16, 152);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 16;
            label7.Text = "Land";
            label7.Click += label7_Click;
            // 
            // text_Land
            // 
            text_Land.BackColor = Color.FromArgb(74, 79, 99);
            text_Land.BorderStyle = BorderStyle.None;
            text_Land.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_Land.Location = new Point(100, 152);
            text_Land.Name = "text_Land";
            text_Land.Size = new Size(100, 22);
            text_Land.TabIndex = 17;
            // 
            // radio_Autos_yes
            // 
            radio_Autos_yes.AutoSize = true;
            radio_Autos_yes.Location = new Point(7, 22);
            radio_Autos_yes.Name = "radio_Autos_yes";
            radio_Autos_yes.Size = new Size(36, 19);
            radio_Autos_yes.TabIndex = 18;
            radio_Autos_yes.TabStop = true;
            radio_Autos_yes.Text = "Ja";
            radio_Autos_yes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(24, 30, 54);
            groupBox1.Controls.Add(radio_Autos_no);
            groupBox1.Controls.Add(radio_Autos_yes);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(0, 126, 249);
            groupBox1.Location = new Point(158, 238);
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
            radio_Autos_no.Size = new Size(51, 19);
            radio_Autos_no.TabIndex = 19;
            radio_Autos_no.TabStop = true;
            radio_Autos_no.Text = "Nein";
            radio_Autos_no.UseVisualStyleBackColor = true;
            // 
            // groupbox_Smartphones
            // 
            groupbox_Smartphones.BackColor = Color.FromArgb(24, 30, 54);
            groupbox_Smartphones.Controls.Add(radioButton1);
            groupbox_Smartphones.Controls.Add(radio_Smartphones);
            groupbox_Smartphones.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupbox_Smartphones.ForeColor = Color.FromArgb(0, 126, 249);
            groupbox_Smartphones.Location = new Point(158, 350);
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
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 29;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nein";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radio_Smartphones
            // 
            radio_Smartphones.AutoSize = true;
            radio_Smartphones.Location = new Point(6, 22);
            radio_Smartphones.Name = "radio_Smartphones";
            radio_Smartphones.Size = new Size(36, 19);
            radio_Smartphones.TabIndex = 28;
            radio_Smartphones.TabStop = true;
            radio_Smartphones.Text = "Ja";
            radio_Smartphones.UseVisualStyleBackColor = true;
            // 
            // groupbox_Laptops
            // 
            groupbox_Laptops.BackColor = Color.FromArgb(24, 30, 54);
            groupbox_Laptops.Controls.Add(radio_Laptops_no);
            groupbox_Laptops.Controls.Add(radio_Laptops_yes);
            groupbox_Laptops.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupbox_Laptops.ForeColor = Color.FromArgb(0, 126, 249);
            groupbox_Laptops.Location = new Point(158, 294);
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
            radio_Laptops_no.Size = new Size(51, 19);
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
            radio_Laptops_yes.Size = new Size(36, 19);
            radio_Laptops_yes.TabIndex = 26;
            radio_Laptops_yes.TabStop = true;
            radio_Laptops_yes.Text = "Ja";
            radio_Laptops_yes.UseVisualStyleBackColor = true;
            // 
            // comboBoxCameraList
            // 
            comboBoxCameraList.BackColor = Color.White;
            comboBoxCameraList.ForeColor = Color.FromArgb(0, 126, 249);
            comboBoxCameraList.FormattingEnabled = true;
            comboBoxCameraList.Location = new Point(473, 12);
            comboBoxCameraList.Name = "comboBoxCameraList";
            comboBoxCameraList.Size = new Size(121, 23);
            comboBoxCameraList.TabIndex = 26;
            // 
            // buttonSelectCamera
            // 
            buttonSelectCamera.BackColor = Color.FromArgb(74, 79, 99);
            buttonSelectCamera.BackgroundImageLayout = ImageLayout.None;
            buttonSelectCamera.FlatAppearance.BorderSize = 0;
            buttonSelectCamera.FlatStyle = FlatStyle.Flat;
            buttonSelectCamera.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSelectCamera.ForeColor = Color.FromArgb(0, 126, 249);
            buttonSelectCamera.Location = new Point(600, 12);
            buttonSelectCamera.Name = "buttonSelectCamera";
            buttonSelectCamera.Size = new Size(141, 23);
            buttonSelectCamera.TabIndex = 27;
            buttonSelectCamera.Text = "Kamera auswählen";
            buttonSelectCamera.UseVisualStyleBackColor = false;
            buttonSelectCamera.Click += buttonSelectCamera_Click_1;
            // 
            // button_retry
            // 
            button_retry.BackColor = Color.FromArgb(74, 79, 99);
            button_retry.FlatAppearance.BorderSize = 0;
            button_retry.FlatStyle = FlatStyle.Flat;
            button_retry.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            button_retry.ForeColor = Color.FromArgb(0, 126, 249);
            button_retry.Location = new Point(554, 225);
            button_retry.Name = "button_retry";
            button_retry.Size = new Size(128, 32);
            button_retry.TabIndex = 28;
            button_retry.Text = "Erneut versuchen";
            button_retry.UseVisualStyleBackColor = false;
            button_retry.Visible = false;
            button_retry.Click += retry_button_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(74, 79, 99);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(0, 126, 249);
            button1.Location = new Point(653, 402);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 29;
            button1.Text = "Switch to data view window";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(text_Stadt);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupbox_Laptops);
            panel1.Controls.Add(text_Hausnummer);
            panel1.Controls.Add(groupbox_Smartphones);
            panel1.Controls.Add(text_Nachname);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(text_Land);
            panel1.Controls.Add(text_Postleitzahl);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(text_Vorname);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(text_Straße);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 449);
            panel1.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(0, 126, 249);
            label8.Location = new Point(158, 205);
            label8.Name = "label8";
            label8.Size = new Size(137, 20);
            label8.TabIndex = 26;
            label8.Text = "Produktgruppen";
            label8.Click += label8_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button_retry);
            Controls.Add(buttonSelectCamera);
            Controls.Add(comboBoxCameraList);
            Controls.Add(label2);
            Controls.Add(button_Picture);
            Controls.Add(pictureBoxVideo);
            Controls.Add(button_Speichern);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainWindow";
            Text = "Form1";
            Load += MainWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxVideo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupbox_Smartphones.ResumeLayout(false);
            groupbox_Smartphones.PerformLayout();
            groupbox_Laptops.ResumeLayout(false);
            groupbox_Laptops.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private PictureBox pictureBoxVideo;
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
        private RadioButton radio_Smartphones;
        private ComboBox comboBoxCameraList;
        private Button buttonSelectCamera;
        private Button button_retry;
        private Button button1;
        private Panel panel1;
        private Label label8;
    }
}
