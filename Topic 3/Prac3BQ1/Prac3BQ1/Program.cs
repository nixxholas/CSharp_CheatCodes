using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Prac3BQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a simpleTest object
            SimpleTest test = new SimpleTest();

            //Add some questions into the SimpleTest object. 
            string[] lines = File.ReadAllLines(@"..\..\question.txt");

            foreach (string line in lines)
            {
                string[] temp = line.Split(',');
                Question q = new Question();
                q.Text = temp[0];
                q.Answer = temp[1];
                test.addQuestion(q);
            }

            /*Question q1 = new Question();
            q1.Text = "Can we be released";
            q1.Answer = "Yes";
            test.addQuestion(q1);

            Question q2 = new Question();
            q2.Text = "How old is Sadesh";
            q2.Answer = "26";
            test.addQuestion(q2);

            ChoiceQuestion q3 = new ChoiceQuestion();
            q3.Text = "Is there a couple";
            q3.addChoice("Yes", true);
            q3.addChoice("No", false);
            test.addQuestion(q3);

            ChoiceQuestion q4 = new ChoiceQuestion();
            q4.Text = "Is DBMS fun?";
            q4.addChoice("Yes", false);
            q4.addChoice("No", false);
            q4.addChoice("Maybe", true);
            test.addQuestion(q4);*/

            //Prompt the user for his name before the start of the test.
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            //Start the test.
            test.startTest();
            //Report the test result.
            Console.WriteLine("{0}, your score is {1}", name, test.calculatePercentage());
            Console.ReadKey();
        }
    }
}
