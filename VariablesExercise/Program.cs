namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int myDogs = 2;

           /*Declaration Syntax and Initialization
           string myfullName
           myFullName = "Dwight" + " " + "Caddell";*/

            string myFullName = "Dwight" + " " + "Caddell";
                       
            char middleInitial = 'A'; //char has to have single ticks
            bool isConfused = true; //No quotes for bool
            double gradYear = 1998;

            
            var yearsTaught = 12.5m; //Decimal

            Console.WriteLine($"My name is {myFullName} with a middle inital of {middleInitial}.\n"); //don't put a space after \n
            Console.WriteLine($"I have {myDogs} dogs.");
            Console.WriteLine($"I graduated high school in {gradYear} and taught school for {yearsTaught}.");
            Console.WriteLine($"It is {isConfused} that I get confused in this class.");

        }
    }
}
