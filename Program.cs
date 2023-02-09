namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");
            string Answer = Console.ReadLine();
            switch(Answer)
            {
                case "English":
                Console.WriteLine("I love English!");
                break;
                case "Math":
                Console.WriteLine("I love Math!");
                break;
                case "Science":
                Console.WriteLine("I love Science!");
                break;
                case " History":
                Console.WriteLine("I love History!");
                break;
                case " PE":
                Console.WriteLine("I love PE!");
                break;
                default:
                Console.WriteLine("I have not heard of that one!");
                break;
            }
        }
    }
}