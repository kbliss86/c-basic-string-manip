using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_basic_string_manip
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Sentence and String Manipulation

            Description 1:
            Prompt the user to enter a sentence, split the sentence into individual words, and display each word on its own line.
            */

            //Bool do while loop to keep loop running until they say now
            bool goAgain = false;
            do
            {
                //Prompt User for a sentence
                Console.WriteLine("Please Enter a Sentence so we can manipulate it");
                //Split each character on " "
                string[] words = Console.ReadLine().Split(' ');
                //Loop Through Each Word and right them back
                for (int i = 0; i < words.Length; i++)
                {
                    Console.WriteLine(words[i]);
                }
                //Ask user if they want to continue
                Console.WriteLine("Would you like to go again? (y/n)");
                goAgain = Console.ReadLine().ToLower() == "n" ? true : false;
            }
            while (!goAgain);


            /*
            Description 2:
            Repeatedly prompt the user to enter a string, store the string in a list, and display the list's contents with each element separated by a space.
            */

            //Bool do while loop to loop running until user says no
            bool goAgain2 = false;

            //Declare blank list of strings
            List<string> strings = new List<string>();
            //Declare user input variable
            string userInput;

            do
            {
                //Prompt user to a word
                Console.WriteLine("Please enter a single word in a sentence");
                userInput = Console.ReadLine();
                //Add word to list
                strings.Add(userInput);
                //Join strings on " " and display the cumulative string
                Console.WriteLine(string.Join(" ", strings));
                //Ask user if they want to continue
                Console.WriteLine("Would you like to continue? (y/n)");
                goAgain2 = Console.ReadLine().ToLower() == "n" ? true : false;

            } while (!goAgain2);

            Console.ReadLine();
        }//End Main
    }//End Class
}//ENd Namespace
