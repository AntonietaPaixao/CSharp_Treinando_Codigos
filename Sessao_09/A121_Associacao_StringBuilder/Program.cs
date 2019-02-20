using System;
using A121_Associacao_StringBuilder.Entities;

namespace A121_Associacao_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            //Post #1
            Post Post1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!", 
                12);
            //Comments Post #1
            Post1.AddComments(new Comment("Have a nice trip"));
            Post1.AddComments(new Comment("Wow that's awesome!"));
            
            //Post #@
            Post Post2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);

            //Comments Post #2
            Post2.AddComments(new Comment("Good night"));
            Post2.AddComments(new Comment("May the Force be with you"));

            Console.WriteLine(Post1);
            Console.WriteLine(Post2);
        }
    }
}
