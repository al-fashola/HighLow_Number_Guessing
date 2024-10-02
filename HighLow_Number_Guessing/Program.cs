﻿namespace HighLow_Number_Guessing;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        const int MAX_GUESS = 10;
        const int FIRST = 1;
        
        

        int numberOfGuesses = 1;
        int numberGuess = 0;
        int correctGuess = rnd.Next(1, 100); 
        
        //Console.WriteLine(correctGuess);
        
        Console.WriteLine($"Hello, let's play a game! You will be guessing a number between 1 and 100, you will have {MAX_GUESS} tries");
        
        while (numberOfGuesses <= MAX_GUESS || numberGuess != correctGuess )
        {
            if (numberOfGuesses == FIRST)
            {
                Console.WriteLine("Please enter your first guess: ");
            }
            if (numberOfGuesses > FIRST && numberOfGuesses < MAX_GUESS)
            {
                Console.WriteLine($"Please enter guess #{numberOfGuesses} : ");
            }
            if (numberOfGuesses == MAX_GUESS)
            {
                Console.WriteLine("Please enter your final guess: ");
            }
            numberGuess = Convert.ToInt32(Console.ReadLine());
            
            if (numberGuess != correctGuess && numberOfGuesses >= MAX_GUESS)
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