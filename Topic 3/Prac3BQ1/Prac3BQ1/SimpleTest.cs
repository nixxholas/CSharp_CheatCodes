using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac3BQ1
{
    class SimpleTest
    {
        //instace variables
        private List<Question> test; //private Question[] test;
        public double score;

        //default constructor
        public SimpleTest()
        {
            test = new List<Question>();
        }

        public void addQuestion(Question q)
        {
            test.Add(q);
        }

        //The method startTets() that performs the following tasks:
        //display each question from the list onto the screen
        //prompt the user for his response
        //check the response and display the result(correct or incorrect)
        //update the score
        public void startTest()
        {
            foreach (Question q in test) {
                Console.WriteLine(q.displayQuestion());
                string response = Console.ReadLine();
                if (q.checkAnswer (response))
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }
            }
        }

        public double calculatePercentage()
        {
            return score / test.Count;
        }
    }
}
