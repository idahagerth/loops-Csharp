using System;

class Loopar
{
    static void Main()
    {
        Console.Write("Mata in start: "); // Ber användaren mata in ett startvärde och lagrar det som en integer.
        int start = int.Parse(Console.ReadLine());
        Console.Write("Mata in stop: "); // Ber användaren mata in ett slutvärde och lagrar det som en integer.
        int stop = int.Parse(Console.ReadLine());
        Console.Write("Mata in steg: ");  // Ber användaren mata in ett steg (hur mycket loopen ska öka för varje iteration) och lagrar det som en integer.
        int step = int.Parse(Console.ReadLine());

        int count = 0;   // Variabeln 'count' kommer att användas för att summera alla tal i loopen.
        for (int i = start; i <= stop; i += step) // En for-loop som startar från 'start' och går upp till och med 'stop', och ökar med 'step' varje gång.
        {
            Console.Write(" " + i); // Skriver ut det aktuella värdet av 'i' på samma rad.
            count += i; // Adderar det aktuella värdet av 'i' till 'count'.
        }
        Console.WriteLine($" \n Summan av alla tal från start {start} med steg {step} till stop {stop} blir: {count}"); // Skriver ut den totala summan av alla tal som räknats ihop i loopen.
    }


}

