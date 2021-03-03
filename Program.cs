using System;

namespace Griaffe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            
            do
            {
                //start the game
                Game();
                Console.WriteLine(" Press Y to retry!");
                //feedback for retry
                String contAnswer = Console.ReadLine();
                if (!contAnswer.Equals("Y"))
                {
                    cont = false;
                }
            }
            //if player answer Y then keep in the while loop
            while (cont);

        } 

        //the game method
        static void Game()
        {
            string[] secretWords = { "one", "two", "griaffe" };
            Random rnd = new Random();
            int wordIndex = rnd.Next(secretWords.Length);
            string secretWord = secretWords[wordIndex];
            string temp = "";
            int guessCount = 0;
            int guessLimit = 3;
            for (int i = 0; i < secretWord.Length; i++)
            {
                temp = temp + "_";
            }
            string guess = "";
            Console.WriteLine("Guess the word! hint: it has " + secretWord.Length + " characters!");
            while (guess != secretWord && guessLimit > guessCount)
            {           
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
                if (guess.Length == secretWord.Length)
                {
                    for (int i = 0; i < guess.Length; i++)
                    {
                         if (guess.Substring(i, 1).Equals(secretWord.Substring(i, 1)))
                        {
                            temp = temp.Remove(i, 1);
                            temp = temp.Insert(i, guess.Substring(i, 1));
                        }
     
                    }
                    
                }
                guessCount++;
                Console.WriteLine(temp);
                Console.WriteLine(guessLimit - guessCount + " tries left!");
            }
            if (guessCount >= guessLimit)
                Console.Write("You Lose!");
            else
                Console.Write("You Win!");
            
        }
        

    }
}
