using System;

class Loopar
{
    static void Main()
    {
        Console.Write("Mata in ett heltal: "); // Ber användaren mata in ett heltal och lagrar det som en integer.
        int numb = int.Parse(Console.ReadLine());
        bool div = false;  // Variabeln 'div' används för att hålla reda på om något tal som är delbart med både 3 och 7 har hittats.
        for (int i = 1; i <= numb; i++) // En for-loop som itererar från 1 upp till och med värdet som användaren har matat in.
        {
            if (i % 3 == 0 && i % 7 == 0) // Kollar om det aktuella talet 'i' är jämnt delbart med både 3 och 7.
            {
                Console.WriteLine($"Talet {i} är jämnt delbart med både 3 och 7");  // Om 'i' är jämnt delbart med både 3 och 7, skrivs det ut.
                div = true;  // Sätter 'div' till true för att indikera att ett sådant tal har hittats.
            }
        }
        if (!div) // Om inga tal som är delbara med både 3 och 7 hittades, skrivs ett meddelande ut.
        {
            Console.WriteLine("Hittade inga tal...");
        }
    }
}
