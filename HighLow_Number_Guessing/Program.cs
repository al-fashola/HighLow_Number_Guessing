namespace HighLow_Number_Guessing;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        

        int numberOfGuesses = 1;
        int numberGuess = 0;
        int correctGuess = rnd.Next(1, 100); 
        
        //Console.WriteLine(correctGuess);
        
        Console.WriteLine("Hello, let's play a game! You will be guessing a number between 1 and 100, you will have 3 tries");
        
        while (numberOfGuesses < 4 || numberGuess != correctGuess )
        {
            if (numberOfGuesses == 1)
            {
                Console.WriteLine("Please enter your first guess: ");
            }
            if (numberOfGuesses == 2)
            {
                Console.WriteLine("Please enter your second guess: ");
            }
            if (numberOfGuesses ==3)
            {
                Console.WriteLine("Please enter your final guess: ");
            }
            numberGuess = Convert.ToInt32(Console.ReadLine());
            
            if (numberGuess != correctGuess && numberOfGuesses >= 3)
            {
                Console.WriteLine("You lose!");
                break;
            }
            if (numberGuess == correctGuess)
            {
                Console.WriteLine("You Won " + correctGuess + " is the right answer!");
                break;
            }
            if (Math.Abs(numberGuess-correctGuess) <=5)
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