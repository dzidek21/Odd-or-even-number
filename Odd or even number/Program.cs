namespace Odd_or_even_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cześć!\nPodaj jakąś liczbę:");
            var numberToCheck=UserNumber();
            Console.WriteLine($"Liczba {numberToCheck} jest liczbą {CheckNumber(numberToCheck)}");
            Console.ReadLine();       
        }
        private static int UserNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int userNumber))
                {
                    Console.WriteLine("Podano zły znak.\nPodaj liczbę");
                    continue;
                }
                else
                {         
                    return userNumber;                  
                }          
            }
        }
        private static string CheckNumber(int numberToCheck)
        {
            if (numberToCheck%2==0)
            {
                return "parzystą";
            }
            else
            {
                return "nieparzystą";
            }
        }
    }
}