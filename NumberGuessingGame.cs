class Program
{
    static void Main(string[] args)

    {
        Random random = new Random();
        bool playAgain = true;
        int min = 1; 
        int max = 100;
        int number;
        int guesses;
        int guess;
        String response;

        while (playAgain)
            {
            number = random.Next(min,max + 1);
            guesses = 0;
            guess = 0;
            response = "";

            while (guess != number)
            {
                Console.WriteLine("Guess a number between " + min + " - " + max + ":");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Guess: " + guess);

                if (guess > number)

                {
                    Console.WriteLine("Your guess is too high");
                }
                else if (guess < number)

                {
                    Console.WriteLine("Your guess is too low");
                }
                guesses++;
            }

                Console.WriteLine("Your guess is correct!");
                Console.WriteLine("Guesses: " + guesses);
                Console.WriteLine("Would you like to play again (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else if (response == "N")
                {
                    playAgain = false;
                }


            
        }

        Console.WriteLine("Thanks for playing");
        Console.ReadKey();

    }


}