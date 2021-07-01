using System;
using System.Collections.Generic;
using System.Text;

namespace QuizShowApplication
{
    public class Questions
    {

        public string Question { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public int CorrectAnswer { get; set; }
        public int WrongAnswer1 { get; set; }
        public int WrongAnswer2 { get; set; }


        public override string ToString()
        {
            return Question;
        }

    }
}
