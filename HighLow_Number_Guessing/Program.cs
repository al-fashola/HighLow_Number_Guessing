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
        
        while (true /*numberOfGuesses <= MAX_GUESSES*/)
        {
            if (numberOfGuesses == INITIALGUESS)
            {
                Console.WriteLine("Please enter your INITIALGUESS guess: ");
            }
            if (numberOfGuesses > INITIALGUESS && numberOfGuesses < MAX_GUESSES)
            {
                Console.WriteLine($"Please enter guess #{numberOfGuesses} : ");
            }
            if (numberOfGuesses == MAX_GUESSES)
            {
                Console.WriteLine("Please enter your final guess: ");
            }
            numberGuess = Convert.ToInt32(Console.ReadLine());
            if (numberGuess == correctGuess)
            {
                Console.WriteLine("You Won " + correctGuess + " is the right answer!");
                break;
            }
            if (numberGuess != correctGuess && numberOfGuesses >= MAX_GUESSES)
            {
                Console.WriteLine("You lose!");
                break;
            }
           
            if (Math.Abs(numberGuess-correctGuess) <= CLOSE_PROXIMITY)
            {
                Console.WriteLine("You're close!");
            }
            if (numberGuess != correctGuess && numberGuess > correctGuess)
            {
                Console.WriteLine("Too High!");
            }
            if (numberGuess != correctGuess && numberGuess < correctGuess)
            {
                Console.WriteLine("Too low!");
            }
            numberOfGuesses++;
            
        }
        
        
    }
    
}