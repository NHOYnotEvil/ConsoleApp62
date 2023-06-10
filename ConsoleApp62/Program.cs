namespace ConsoleApp62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number;
            int numberStartExample = 0;
            int firstDivisor = 3;
            int secondDivider = 5;
            int randomNumberMinimum = 0;
            int randomNumberMaximum = 101;
            float result;
            float result2;
            float finalResult = 0;
            bool isUserExit = false;
            number = random.Next(randomNumberMinimum, randomNumberMaximum);

            Console.WriteLine("Ваше число:" + number);

            while (isUserExit == false)
            {
                if (number % firstDivisor == 0 || number % secondDivider == 0)
                {
                    finalResult += number + number;
                    isUserExit = true;
                }
                else if (number % firstDivisor == 0 && number % secondDivider == 0)
                {
                    Console.WriteLine("Общая сумма, кратных - " + firstDivisor + " и " + secondDivider + ", равна - " + finalResult);
                }
            }

            Console.WriteLine("Общая сумма, кратных - " + firstDivisor + " и " + secondDivider + ", равна - " + finalResult);
        }
    }
}