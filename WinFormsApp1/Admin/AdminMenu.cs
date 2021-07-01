using QuizShowApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Admin
{
    public partial class AdminMenu : Form
    {
        String dummy;

        public AdminMenu()
        {
            InitializeComponent();
        }

        private void leaderBoardBtn_Click(object sender, EventArgs e)
        {
            Leaderboard leaderboard = new Leaderboard(dummy, dummy);
            leaderboard.Show();
            this.Hide();
        }
    }
}
