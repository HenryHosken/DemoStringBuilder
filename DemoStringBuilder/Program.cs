using DemoStringBuilder.Entities; 
namespace DemoStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1= new Post
                (
                    DateTime.Parse("16/02/2023 16:50:00"),
                    "Traveling to new Zealand",
                    "I'm going to visit this wonderful contry!",
                    12
                );
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the force be with you");
            Post p2 = new Post
                (
                    DateTime.Parse("13/02/2023 16:50:00"),
                    "Good night guys",
                    "See you tomorrow",
                    12
                );
            p1.AddComment(c1);
            p1.AddComment(c2);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}