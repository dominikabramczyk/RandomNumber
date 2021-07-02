using System;

namespace SecondHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("  Witaj w programie, który losuje liczbę z zakresu 0-100.\n  Twoim zadaniem jest ją odgadnąć\n\tPowodzenia!!!");
            Console.WriteLine("---------------------------------------------------------------");
            Attempt();
        }

        public static int RandomNumber()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 100);
            return randomNumber;
        }

        public static int UserNumber()
        {
            Console.WriteLine("Podaj swoja liczbe.");
            var userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }

        public static void Attempt()
        {
            var randomNumber = RandomNumber();
            //Console.WriteLine(randomNumber);
            
            var numberOfTries = 1 ;
            
            while (true)
            {
               
                var userNumber = UserNumber();
                if (randomNumber > userNumber)
                {
                    Console.WriteLine("Twoja liczba jest za mała.\n\n");
                    numberOfTries++;
                }
                else if (randomNumber == userNumber)
                {
                    Console.WriteLine($"Brawo zgadłeś liczbę za {numberOfTries} razem!!!!!");
                    Console.ReadLine();
                    Environment.Exit(1);
                }
                else if (randomNumber < userNumber)
                {
                    Console.WriteLine("Twoja liczba jest za duża.\n\n");
                    numberOfTries++;
                }
            }

        }

    }
}
