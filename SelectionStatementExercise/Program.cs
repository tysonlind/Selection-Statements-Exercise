namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            var userInput = int.Parse(Console.ReadLine());
            if (userInput == favNumber)
            {
                Console.WriteLine("You guessed my favorite number!");
            } else if (userInput > favNumber)
            {
                Console.WriteLine("Your guess was too high");
            } else if (userInput < favNumber)
            {
                Console.WriteLine("Your guess was too low");
            } else
            {
                Console.WriteLine("Invalid entry");
            }
        }
    }
}
