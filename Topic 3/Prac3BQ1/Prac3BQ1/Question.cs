using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac3BQ1
{
    class Question
    {
        //instance variables
        private string text;
        private string answer;

        //default constructor
        public Question() { }

        //properties for the attributes
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public string Answer
        {
            get { return answer; }
            set { answer = value; }
        }

        //The checkAnswer(string) method
        public bool checkAnswer(string response)
        {
            return answer.Equals(response);
        }

        //displayQuestion() that displays the question
        public string displayQuestion()
        {
            return text;
        }
    }
}
