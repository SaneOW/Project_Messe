namespace Project_Messe.Windows
{
    partial class WorkerWindow
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
            dataGridView1 = new DataGridView();
            button_DatenAnzeigen = new Button();
            button_sendData = new Button();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(838, 264);
            dataGridView1.TabIndex = 0;
            // 
            // button_DatenAnzeigen
            // 
            button_DatenAnzeigen.Location = new Point(12, 294);
            button_DatenAnzeigen.Name = "button_DatenAnzeigen";
            button_DatenAnzeigen.Size = new Size(124, 23);
            button_DatenAnzeigen.TabIndex = 1;
            button_DatenAnzeigen.Text = "Daten anzeigen";
            button_DatenAnzeigen.UseVisualStyleBackColor = true;
            button_DatenAnzeigen.Click += button_DatenAnzeigen_Click;
            // 
            // button_sendData
            // 
            button_sendData.Location = new Point(681, 386);
            button_sendData.Name = "button_sendData";
            button_sendData.Size = new Size(169, 23);
            button_sendData.TabIndex = 2;
            button_sendData.Text = "Daten an Server senden";
            button_sendData.UseVisualStyleBackColor = true;
            button_sendData.Click += button_sendData_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(642, 323);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(208, 23);
            textBoxSearch.TabIndex = 3;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(775, 294);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "Suchen";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(642, 298);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 5;
            label1.Text = "Nach Namen suchen";
            // 
            // button1
            // 
            button1.Location = new Point(681, 415);
            button1.Name = "button1";
            button1.Size = new Size(169, 23);
            button1.TabIndex = 6;
            button1.Text = "Switch to data input window";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // WorkerWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(button_sendData);
            Controls.Add(button_DatenAnzeigen);
            Controls.Add(dataGridView1);
            Name = "WorkerWindow";
            Text = "WorkerWindow";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button_DatenAnzeigen;
        private Button button_sendData;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Label label1;
        private Button button1;
    }
}