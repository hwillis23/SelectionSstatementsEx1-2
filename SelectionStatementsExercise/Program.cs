using System;

namespace SelectionStatementsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //favoriteNum();

            var r = new Random();
            var favNumber = r.Next(1, 10);
            Console.WriteLine("Try to guess my favorite number. Hint: it is between 1-10");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Too Low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too High");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }

            // SwitchCaseFavSchoolSubjectEx2

            Console.WriteLine("What is your favorite subject to take in school?");
            string userfavsubject = Console.ReadLine();

            switch (userfavsubject.ToLower())
            {
                case "organic chemistry":
                    Console.WriteLine("Ugh, too many carbons. That is known as the weed-out class to get into medical school.");
                    break;
                case "physics":
                    Console.WriteLine("You must be Sheldon Cooper smart!");
                    break;
                case "calculus":
                    Console.WriteLine("Letters as numbers,guh! I do not like that kind of math.");
                    break;
                case "computer science":
                    Console.WriteLine("You are offically my new best friend.That is my favorite class too! I love computers.");
                    break;
                case "spanish":
                    Console.WriteLine("I struggled in that class. I cannot roll my Rs to articulate that language well.");
                    break;
                default:
                    Console.WriteLine($"Oh, I have not taken {userfavsubject}. That sounds like a great class!");
                    break;
            }






        }   
    }
}

