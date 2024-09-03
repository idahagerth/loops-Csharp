using System;

class Loopar
{
    static void Main()
    {
        int CorrectNumb = 42; // Det korrekta talet som användaren försöker gissa.
        int Guess = 0; // Variabel för att lagra användarens gissning.
        int TotalAmountOfGuesses = 0; // Variabel som håller koll på antalet gissningar användaren har gjort.

        while (Guess != CorrectNumb)  // En while-loop som fortsätter tills användaren gissar rätt.
        {
            Console.Write("Gissa ett tal mellan 1 och 100: ");  // Ber användaren att gissa ett tal mellan 1 och 100.
            Guess = int.Parse(Console.ReadLine()); // Läser in användarens gissning och omvandlar den till en integer.
            if (Guess > CorrectNumb) // Om användarens gissning är högre än det korrekta talet.
            {
                Console.WriteLine("För högt!");
                TotalAmountOfGuesses++;    // Ökar antalet gissningar med 1.
            }
            else if (Guess < CorrectNumb)  // Om användarens gissning är lägre än det korrekta talet.
            {
                Console.WriteLine("För lågt!");
                TotalAmountOfGuesses++;
            }
            else     // Om användarens gissning är korrekt.
            {
                TotalAmountOfGuesses++;  // Ökar antalet gissningar med 1 och gratulerar användaren.
                Console.WriteLine($"Grattis det tog dig {TotalAmountOfGuesses} gissningar!");
            }
        }
    }
}
