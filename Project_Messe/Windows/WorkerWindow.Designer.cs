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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(48, 241);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1139, 150);
            dataGridView1.TabIndex = 0;
            // 
            // button_DatenAnzeigen
            // 
            button_DatenAnzeigen.Location = new Point(975, 165);
            button_DatenAnzeigen.Name = "button_DatenAnzeigen";
            button_DatenAnzeigen.Size = new Size(124, 23);
            button_DatenAnzeigen.TabIndex = 1;
            button_DatenAnzeigen.Text = "Daten anzeigen";
            button_DatenAnzeigen.UseVisualStyleBackColor = true;
            // 
            // button_sendData
            // 
            button_sendData.Location = new Point(975, 397);
            button_sendData.Name = "button_sendData";
            button_sendData.Size = new Size(75, 23);
            button_sendData.TabIndex = 2;
            button_sendData.Text = "Daten Senden";
            button_sendData.UseVisualStyleBackColor = true;
            button_sendData.Click += button_sendData_Click;
            // 
            // WorkerWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 450);
            Controls.Add(button_sendData);
            Controls.Add(button_DatenAnzeigen);
            Controls.Add(dataGridView1);
            Name = "WorkerWindow";
            Text = "WorkerWindow";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button_DatenAnzeigen;
        private Button button_sendData;
    }
}