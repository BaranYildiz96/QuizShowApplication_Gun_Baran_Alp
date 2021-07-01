using QuizShowApplication;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Quiz : Form
    {

        // variable for answers
        int correctAnswer;
        int wrongAnswer1;
        int wrongAnswer2;

        string username;
        string password;

        // list of Questions
        List<Questions> questions = new List<Questions>();

        // 
        int questionNumber = 1;
        int score;
        int moneyWon;

        int totalQuestions;
        int joker = 2;
        int wrongAnswerChance = 2;
        int loop;
        
        // constructor
        public Quiz(string username, string password)
        {
            InitializeComponent();
            askQuestion(questionNumber);

            totalQuestions = 16;

            this.username = username;
            this.password = password;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            // if the answer is the right 
            if (buttonTag == correctAnswer && buttonTag != 5)
            {
                if (moneyWon < 600)
                {
                    moneyWon = +moneyWon + 200;
                }
                else if (moneyWon >= 600 && moneyWon < 1000)
                {
                    moneyWon = +moneyWon + 300;
                }
                else
                {
                    moneyWon = +moneyWon + 400;
                }

                //moneyWon =+ moneyWon + 200;
                score++;
                loop++;
                questionNumber++;
                askQuestion(loop);
                MessageBox.Show("Right Answer");

                // Hardness level of questions changed
                if(questionNumber == 4)
                {
                    MessageBox.Show("Medium Questions");
                } else if (questionNumber == 7)
                {
                    MessageBox.Show("Hard Questions");
                }

                answerBtn1.BackColor = Color.Transparent;
                answerBtn2.BackColor = Color.Transparent;
                answerBtn3.BackColor = Color.Transparent;
                answerBtn4.BackColor = Color.Transparent;
            }
            // if the answer is wrong
            else if (buttonTag != correctAnswer && buttonTag != 5)
            {
                MessageBox.Show("Wrong Answer");
                wrongAnswerChance--;
                loop++;
                askQuestion(questionNumber);

                answerBtn1.BackColor = Color.Transparent;
                answerBtn2.BackColor = Color.Transparent;
                answerBtn3.BackColor = Color.Transparent;
                answerBtn4.BackColor = Color.Transparent;
            }

            // Joker Button
            if(buttonTag == 5) // Paint red to 2 wrong answers
            {
                if (wrongAnswer1 == 1 || wrongAnswer2 == 1)
                {
                    answerBtn1.BackColor = Color.Red;
                }
                if (wrongAnswer1 == 2 || wrongAnswer2 == 2)
                {
                    answerBtn2.BackColor = Color.Red;
                }
                if (wrongAnswer1 == 3 || wrongAnswer2 == 3)
                {
                    answerBtn3.BackColor = Color.Red;
                }
                if(wrongAnswer1 == 4 || wrongAnswer2 == 4)
                {
                    answerBtn4.BackColor = Color.Red;
                }

                // decreases number of Jokers
                joker--;

                if(joker == 0)
                {
                    jokerBtn.Hide();
                }
            }
            // when all questions or wrong answer chances finished stop quiz
            if (questionNumber == totalQuestions || wrongAnswerChance == 0)
            {

                displayScore();

                MainMenu mainMenu = new MainMenu(username, password);
                mainMenu.Show();
                this.Hide();

            }

        }

        // displays Score at the end of the quiz
        private void displayScore()
        {
            SaveScore(score,moneyWon);
            MessageBox.Show(
                  "Quiz Ended!" + Environment.NewLine +
                  "You have answered " + score + " questions correctly." + Environment.NewLine +
                  "Your have won " + moneyWon + " TL" + Environment.NewLine +
                  "Click OK to go Main Menu"
                  );
        }

        // Saves score of the player at the finish of the quiz
        private void SaveScore(int score, int moneyWon)
        {
            var Line = ", " + score + ", " + moneyWon + ";";

            // if player can't answer any questions correctly, write to the losers
            if (score == 0)
            {
                var SpecialLine = username + ", " + password + ", " + score + ", " + moneyWon + ";";

                File.AppendAllText(@"C:\Users\baran\source\repos\QuizShowApplicationDenemeleas\WinFormsApp1\TextFiles\Participants\LoserParticipants.txt", SpecialLine + Environment.NewLine);
                //File.AppendAllText(@"C:\Users\baran\source\repos\QuizShowApplicationDenemeleas\WinFormsApp1\TextFiles\Participants\LoserParticipants.txt", SpecialLine + Environment.NewLine);
            }

            // if player answers all questions correctly add winner list
            if (score == 16)
            {
                var SpecialLine = username + ", " + password + ", " + score + ", " + moneyWon + ";";

                File.AppendAllText(@"C:\Users\baran\source\repos\QuizShowApplicationDenemeleas\WinFormsApp1\TextFiles\Participants\WinnerParticipants.txt.txt", SpecialLine + Environment.NewLine);
                //File.AppendAllText(@"C:\Users\baran\source\repos\QuizShowApplicationDenemeleas\WinFormsApp1\TextFiles\Participants\WinnerParticipants.txt", SpecialLine + Environment.NewLine);
            }

            // Add score of the user 
            File.AppendAllText(@"C:\Users\baran\source\repos\QuizShowApplicationDenemeleas\WinFormsApp1\TextFiles\Participants\TotalParticipants.txt", Line );
            //File.AppendAllText(@"C:\Users\baran\source\repos\QuizShowApplicationDenemeleas\WinFormsApp1\TextFiles\Participants\TotalParticipants.txt", Line);
        }

        /**
        public List<Questions> GetQuestionList()
        {
           List<Questions> objQuestion = new List<Questions>();

           using (StreamReader file = new StreamReader(@"C: \Users\baran\source\repos\QuizShowApplicationDenemeler\WinFormsApp1\TextFiles\Questions\EasyQuestion.txt"))
           {
               while ((line = file.ReadLine()) != null)
               {

                   char[] delimiters = new char[] { ',' };
                   string[] parts = line.Split(delimiters);

                   Questions objQuestion = new Questions();
                   objQuestion.QuestionCode = parts[0];
                   objQuestion.QuestionTitle = parts[1];
                   objQuestion.QuestionA = parts[2];
                   objQuestion.QuestionB = parts[3];
                   objQuestion.QuestionC = parts[4];
                   objQuestion.QuestionD = parts[5];
                   objQuestion.Add(objQuestion);

               }

               file.Close();
           }

           return objQuestion;
        }
        */

        private void askQuestion(int loop1)
        {
            // put questions to a list
            // 1
            questions.Add(new Questions { Question = "What is the colour of the sky?", Answer1 = "Blue", Answer2 = "Yellow", Answer3 = "Orange", Answer4 = "Red", CorrectAnswer = 1, WrongAnswer1 = 3, WrongAnswer2 = 4});
            // 2
            questions.Add(new Questions { Question = "What is the name of the main character from Iron Man?", Answer1 = "Clark Kent", Answer2 = "Tony Stark", Answer3 = "Rody", Answer4 = "Peter Quill", CorrectAnswer = 2, WrongAnswer1 = 3, WrongAnswer2 = 4 });
            // 3
            questions.Add(new Questions { Question = "What is the short name of Counter Strike: Global Operaitons?", Answer1 = "Call of Duty", Answer2 = "Battlefield", Answer3 = "Fortnite", Answer4 = "CS - GO", CorrectAnswer = 4, WrongAnswer1 = 3, WrongAnswer2 = 2 });
            // 4
            questions.Add(new Questions { Question = "Which Publisher made Call of Duty?", Answer1 = "EA", Answer2 = "Rockstar", Answer3 = "Activision", Answer4 = "Sony", CorrectAnswer = 3, WrongAnswer1 = 1, WrongAnswer2 = 4 });
            // 5
            questions.Add(new Questions { Question = "Which Publisher made World of Warcraft?", Answer1 = "Blizzard", Answer2 = "EA", Answer3 = "Bandai", Answer4 = "CD Projekt Red", CorrectAnswer = 1, WrongAnswer1 = 3, WrongAnswer2 = 4 });
            // 6
            questions.Add(new Questions { Question = "What is the main characters name in the God of War?", Answer1 = "Tom", Answer2 = "Ghost", Answer3 = "Kratos", Answer4 = "Atreus", CorrectAnswer = 3, WrongAnswer1 = 2, WrongAnswer2 = 4 });
            // 7
            questions.Add(new Questions { Question = "Who was Geralt looking for in Witcher 3: Wild Hunt?", Answer1 = "Yennefer", Answer2 = "Triss", Answer3 = "Ciri", Answer4 = "Wild Hunt", CorrectAnswer = 3, WrongAnswer1 = 1, WrongAnswer2 = 2 });
            // 8
            questions.Add(new Questions { Question = "Which city is the captial city of England?", Answer1 = "Manchester", Answer2 = "Paris", Answer3 = "New York", Answer4 = "London", CorrectAnswer = 4, WrongAnswer1 = 3, WrongAnswer2 = 1 });
            // 9
            questions.Add(new Questions { Question = "What is the name of streaming website?", Answer1 = "Twitch", Answer2 = "Youtube", Answer3 = "Twitter", Answer4 = "Instagram", CorrectAnswer = 1, WrongAnswer1 = 3, WrongAnswer2 = 4 });
            // 10
            questions.Add(new Questions { Question = "What is the name of the main character from Captain America?", Answer1 = "Clark Kent", Answer2 = "Steve Rogers", Answer3 = "Rody Mood", Answer4 = "Peter Quill", CorrectAnswer = 2, WrongAnswer1 = 3, WrongAnswer2 = 4 });
            // 11
            questions.Add(new Questions { Question = "What is the name of the main character from James Bond?", Answer1 = "Tom Cruise", Answer2 = "Daniel Craig", Answer3 = "Steven Frane", Answer4 = "Keanu Reeves", CorrectAnswer = 2, WrongAnswer1 = 3, WrongAnswer2 = 4 });
            // 12
            questions.Add(new Questions { Question = "What is the formula of water", Answer1 = "SO2", Answer2 = "C02", Answer3 = "H2O2", Answer4 = "H2O", CorrectAnswer = 4, WrongAnswer1 = 3, WrongAnswer2 = 2 });
            // 13
            questions.Add(new Questions { Question = "What is the date of Karlofca Deal", Answer1 = "1708", Answer2 = "1699", Answer3 = "1455", Answer4 = "1927", CorrectAnswer = 2, WrongAnswer1 = 1, WrongAnswer2 = 4 });
            // 14
            questions.Add(new Questions { Question = "With which victory did the Turks enter Anatolia? ", Answer1 = "Miryokefelon", Answer2 = "Ankara", Answer3 = "Bedir", Answer4 = "Malazgirt", CorrectAnswer = 4, WrongAnswer1 = 3, WrongAnswer2 = 2 });
            // 15
            questions.Add(new Questions { Question = "Who made the first powered airplane flight? ", Answer1 = "Niel Bohr", Answer2 = "Enrico Fermi", Answer3 = "Wright Brothers", Answer4 = "Evangelista Toricelli", CorrectAnswer = 3, WrongAnswer1 = 2, WrongAnswer2 = 4 });
            // 16
            questions.Add(new Questions { Question = "In which country is it compulsory for women to do military service?", Answer1 = "England", Answer2 = "China", Answer3 = "Israel", Answer4 = "Russia", CorrectAnswer = 3, WrongAnswer1 = 1, WrongAnswer2 = 2 });

            // easy questions
            for ( ; loop1 < 5; loop1++)
            {
                try
                {
                    jokerLbl.Text = "Joker chances: " + joker;

                    questionLBL.Text = questions[loop].Question;
                    answerBtn1.Text = questions[loop].Answer1;
                    answerBtn2.Text = questions[loop].Answer2;
                    answerBtn3.Text = questions[loop].Answer3;
                    answerBtn4.Text = questions[loop].Answer4;

                    correctAnswer = questions[loop].CorrectAnswer;
                    wrongAnswer1 = questions[loop].WrongAnswer1;
                    wrongAnswer2 = questions[loop].WrongAnswer2;
                }
                catch (Exception e)
                {

                }
            }

            // medium questions
            for ( ; loop1 < 10; loop1++)
            {
                try
                {
                    jokerLbl.Text = "Joker chances: " + joker;

                    questionLBL.Text = questions[loop].Question;
                    answerBtn1.Text = questions[loop].Answer1;
                    answerBtn2.Text = questions[loop].Answer2;
                    answerBtn3.Text = questions[loop].Answer3;
                    answerBtn4.Text = questions[loop].Answer4;

                    correctAnswer = questions[loop].CorrectAnswer;
                    wrongAnswer1 = questions[loop].WrongAnswer1;
                    wrongAnswer2 = questions[loop].WrongAnswer2;
                }
                catch (Exception e)
                {

                }

            }

            // hard questions
            for ( ; loop1 < 15; loop1++)
            {
                try
                {
                    jokerLbl.Text = "Joker chances: " + joker;

                    questionLBL.Text = questions[loop].Question;
                    answerBtn1.Text = questions[loop].Answer1;
                    answerBtn2.Text = questions[loop].Answer2;
                    answerBtn3.Text = questions[loop].Answer3;
                    answerBtn4.Text = questions[loop].Answer4;

                    correctAnswer = questions[loop].CorrectAnswer;
                    wrongAnswer1 = questions[loop].WrongAnswer1;
                    wrongAnswer2 = questions[loop].WrongAnswer2;
                }
                catch (Exception e)
                {

                }

            }

        }

    }
}
