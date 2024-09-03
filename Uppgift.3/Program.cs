using System;

class Loopar
{
    static void Main()
    {
        string str = "##########";   // Skapar en sträng med 10 stycken '#' tecken.
        int length = str.Length; // Sparar längden på strängen i variabeln 'length'.

        for (int i = 0; i < length; i++) // En for-loop som itererar från 0 till strängens längd minus 1.
        {
            Console.WriteLine(str.Substring(0, length - i)); // Man behöver inte använda sig ut av "nested loops" Detta gör att ett tecken tas bort för varje iteration.
        }
    }

}

