using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1;

namespace QuizShowApplication
{
    public partial class Leaderboard : Form
    {

        string username;
        string password;
        
        public Leaderboard(string username, string password)
        {
            InitializeComponent();

            this.username = username;
            this.password = password;
        }

        List<Participants> participants = new List<Participants>();

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            try
            {
                var lines = File.ReadAllLines("C:/Users/baran/source/repos/QuizShowApplicationDenemeleas/WinFormsApp1/TextFiles/Participants/TotalParticipants.txt");

                //var lines = File.ReadAllLines("C:/Users/baran/source/repos/QuizShowApplicationDenemeleas/WinFormsApp1/TextFiles/ShowRecords.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    lines[i].Split(';');
                    participants.Add(new Participants { Name = lines[i]});
                    leaderList.Items.Add(Name = participants[i].Name);
                }
            }
            catch(Exception E) {
                MessageBox.Show(E.Message);
            }
            
        }

        // Button to go back Main Menu
        private void backBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu(username, password);
            mainMenu.Show();
            this.Hide();
        }
    }
}
