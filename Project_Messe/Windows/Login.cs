using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Messe.Windows
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            textBox_Username.Clear();
            textBox_Password.Clear();
        }

        private bool isValid()
        {
            if (textBox_Username.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Bitte Username eingeben", "error");
                return false;
            }
            else if (textBox_Password.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Bitte Passwort eingeben", "error");
                return false;
            }
            return true;
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                if (textBox_Username.Text.Trim() == "Serhan" && textBox_Password.Text.Trim() == "123")
                {
                    MainWindow m1 = new MainWindow();
                    this.Hide();
                    m1.Show();
                }
                else
                {
                    MessageBox.Show("Username oder Passwort ist falsch!");
                }
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
