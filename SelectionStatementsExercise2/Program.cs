namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
          FavoriteSubject();
        }

        public static void FavoriteSubject()
        {
            Console.WriteLine("What is your favorite subject?");
            string subject = Console.ReadLine();
            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is hard");
                    break;
                case "science":
                    Console.WriteLine("Science is amazing!");
                    break;
                case "english":
                case "literature":
                case "lit":  
                case "reading"    
                    Console.WriteLine("English/literature is my absolute favorite");
                    break;
                case "history":
                    Console.WriteLine("History keeps us from repeating past mistakes");
                    break;
                case "language":
                case "foreign language":
                case "spanish":
                case "french":
                    Console.WriteLine("Learning other languages is hard");
                    break;
                case "pe":
                case "p.e.":
                case "physical education":
                    Console.WriteLine("Physical education is not for me");
                    break;
                default:
                    Console.WriteLine("That's a great subject too!");
                    break;
            }
        }
        
    }
}