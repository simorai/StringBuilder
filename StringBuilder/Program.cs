using stringBuilder.Entities;


namespace stringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow thats awsome");
            Post p1 = new Post(
                DateTime.Parse("29/12/2024 23:00:00"),
                "traveling to new zeland",
                "I'm going to visit this wonder country",
                12 );
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the force be with you");
            Post p2 = new Post(
                DateTime.Parse("27/12/2024 23:03:00"),
                "Good night guys",
                "see you tomorow",
                5);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
