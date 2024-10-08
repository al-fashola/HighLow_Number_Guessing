namespace HighLow_Number_Guessing;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        const int MAX_GUESSES = 10;
        const int INITIALGUESS = 1;
        const int CLOSE_PROXIMITY = 5;
        const int LOW_GUESS_RANGE = 1;
        const int HIGH_GUESS_RANGE = 101;

        int numberOfGuesses = 1;
        int numberGuess = 0;
        int correctGuess = rnd.Next(LOW_GUESS_RANGE, HIGH_GUESS_RANGE); 
        
        //Console.WriteLine(correctGuess);
        
        Console.WriteLine($"Hello, let's play a game! You will be guessing a number between {LOW_GUESS_RANGE} and {HIGH_GUESS_RANGE-1}, you will have {MAX_GUESSES} tries");
        
        // while the number or guesses is below MAX_GUESSES continue to run the loop 
        while (true) 
        {
            if (numberOfGuesses == INITIALGUESS)
            {
                Console.WriteLine("Please enter your First guess: ");
            }
            else if (numberOfGuesses == MAX_GUESSES)
            {
                Console.WriteLine("Please enter your final guess: ");
            }
            else 
            {
                Console.WriteLine($"Please enter guess #{numberOfGuesses} : ");
            }
            
            numberGuess = Convert.ToInt32(Console.ReadLine());
            
            // Win or lose end of game logic
            if (numberGuess == correctGuess)
            {
                Console.WriteLine($"You Won in {numberOfGuesses} tries, {correctGuess} is the right answer!");
                break;
            }
            if (numberGuess != correctGuess && numberOfGuesses >= MAX_GUESSES)
            {
                Console.WriteLine("You lose!");
                Console.WriteLine($"The correct guess was {correctGuess}!");
                break;
            } 
            
           
            //High/low proximity logic
            if (Math.Abs(numberGuess-correctGuess) <= CLOSE_PROXIMITY)
            {
                Console.WriteLine("You're close!");
            }
            if (numberGuess > correctGuess)
            {
                Console.WriteLine("Too High!");
            }
            if (numberGuess < correctGuess)
            {
                Console.WriteLine("Too low!");
            }
            numberOfGuesses++;
            
        }
        
        
    }
    
}