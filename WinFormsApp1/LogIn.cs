using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Admin;

namespace WinFormsApp1
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            // hide the text of the password
            passwordTB.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }
      
        private void button1_Click_1(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(usernameTB.Text) && usernameTB.Text.Length < 6)
            {
                MessageBox.Show("Username must be longer than 5 characters");
            }
            else if (String.IsNullOrWhiteSpace(passwordTB.Text) && passwordTB.Text.Length < 6)
            {
                MessageBox.Show("Password must be longer than 5 characters");
            }
            else
            {
                // admin log-in
                if (usernameTB.Text == "Baran123" && passwordTB.Text == "123456" || usernameTB.Text == "Gün123" && passwordTB.Text == "874156" || usernameTB.Text == "Alp123" && passwordTB.Text == "369853")
                {
                    AdminMenu adminMenu = new AdminMenu();
                    adminMenu.Show();
                    this.Hide();
                }
                /**
                else if (usernameTB.Text == "Gün123" && passwordTB.Text == "874156")
                {
                    AdminMenu adminMenu = new AdminMenu();
                    adminMenu.Show();
                    this.Hide();
                }
                else if (usernameTB.Text == "Alp123" && passwordTB.Text == "369853")
                {
                    AdminMenu adminMenu = new AdminMenu();
                    adminMenu.Show();
                    this.Hide();
                }
                */
                // Participant Log-in
                else
                {
                    SaveUserName(usernameTB, passwordTB);            
                    MainMenu mainMenu = new MainMenu(usernameTB.Text, passwordTB.Text);
                    // Show the settings form
                    mainMenu.Show();
                    this.Hide();
                }

            }

        }

        // Save Username and Password of participants
        private void SaveUserName(TextBox usernameTB, TextBox passwordTB)
        {
            var Line = usernameTB.Text + ", " + passwordTB.Text ;
            // add a new participant to TotalParticipants file
            File.AppendAllText(@"C:\Users\baran\source\repos\QuizShowApplicationDenemeleas\WinFormsApp1\TextFiles\Participants\TotalParticipants.txt", Environment.NewLine + Line ); //+ Environment.NewLine

            //File.AppendAllText(@"C:\Users\baran\source\repos\QuizShowApplicationDenemeleas\WinFormsApp1\TextFiles\Participants\TotalParticipants.txt", Line + Environment.NewLine);
        }
    }
}
