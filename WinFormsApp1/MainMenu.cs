using QuizShowApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainMenu : Form
    {

        string username;
        string password;

        public MainMenu(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }
        

        private void quizBtn_Click(object sender, EventArgs e)
        {
           
            Quiz quiz = new Quiz(username, password);
            quiz.Show();
            this.Hide();


        }

        private void leaderbBtn_Click(object sender, EventArgs e)
        {
            Leaderboard leaderboard = new Leaderboard(username, password);
            leaderboard.Show();
            this.Hide();

        }

        private void scoreBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
