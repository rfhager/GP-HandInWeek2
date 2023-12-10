namespace GradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Vill du beräkna betyg för en elev? Ange: JA/NEJ");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "ja")
                {
                    Console.WriteLine("Ange elevens poäng:");
                    int points = int.Parse(Console.ReadLine());

                    if (points >= 90)
                        Console.WriteLine("Elevens betyg för denna uppgift är: A");
                    else if (points >= 80)
                        Console.WriteLine("Elevens betyg för denna uppgift är: B");
                    else if (points >= 70)
                        Console.WriteLine("Elevens betyg för denna uppgift är: C");
                    else if (points >= 60)
                        Console.WriteLine("Elevens betyg för denna uppgift är: D");
                    else if (points >= 50)
                        Console.WriteLine("Elevens betyg för denna uppgift är: E");
                    else
                        Console.WriteLine("Elevens betyg för denna uppgift är: F");

                } 
                else if (userInput == "nej")
                    Environment.Exit(0);
                else
                    Console.WriteLine("Ogiltig input");

            } while (true);
        }
    }
}
