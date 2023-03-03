namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int myDogs = 2;

            string myFullName = "Dwight" + " " + "Caddell";
            char middleInitial = 'A';
            bool isConfused = true;

            double gradYear = 1998;

            //Decimal
            var yearsTaught = 12.5m;

            Console.WriteLine($"My name is {myFullName} with a middle inital of {middleInitial}.");
            Console.WriteLine($"I have {myDogs} dogs.");
            Console.WriteLine($"I graduated high school in {gradYear} and taught school for {yearsTaught}.");
            Console.WriteLine($"{isConfused}");

        }
    }
}
