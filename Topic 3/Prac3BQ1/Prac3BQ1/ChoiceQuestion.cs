using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac3BQ1
{
    class ChoiceQuestion : Question
    {
        //instance variable
        private List<string> choices;//private string[] choices;

        //default constructor
        public ChoiceQuestion()
        {
            choices = new List<string>(); //choices = new string [5]
        }

        //properties
        public List<string> Choices
        {
            get { return choices; }
            set { choices = value; }
        }

        public void addChoice(string choice, bool correct)
        {
            choices.Add(choice);
            if (correct) base.Answer = choice;
        }

        public string displayQuestion()
        {
            string str;
            int i = 1;
            str = base.displayQuestion();
            foreach (string c in choices)
            {
                str += i + ". " + c;
                i++;
            }

            return str;
        }
    }
}
