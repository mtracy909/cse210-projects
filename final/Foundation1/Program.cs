using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Video> videos = new List<Video>();
        Video fox = new Video("What Does the Fox Say?", "TV Norge", 225);
        Comment fox1 = new Comment("Bng_Rp_", "Haven’t heard this song in 8 years and I still know it word by word");
        fox.AddComment(fox1);
        Comment fox2 = new Comment("foxlover_XoX_", "I still don't know what sound a fox makes.");
        fox.AddComment(fox2);
        Comment fox3 = new Comment("fakeperson999", "It's truly a mystery, what the fox says.");
        fox.AddComment(fox3);
        videos.Add(fox);
        Video shark = new Video("Baby Shark Dance", "Pinkfong Baby Shark", 137);
        Comment shark1 = new Comment("randommother123", "My kid loves this!");
        shark.AddComment(shark1);
        Comment shark2 = new Comment("cursedbybabyshark", "I can't get this song out of my head.");
        shark.AddComment(shark2);
        Comment shark3 = new Comment("definitelyrealperson", "Do-doo, do-doo, do-doo");
        shark.AddComment(shark3);
        videos.Add(shark);
        Video despacito = new Video("Despacito", "Luis Fonsi", 282);
        Comment despacito1 = new Comment("gouthamvenkat5119", "TEACHER: What is the world population STUDENT: around one despacito");
        despacito.AddComment(despacito1);
        Comment despacito2 = new Comment("Armaansingh-qv3qo", "2017: People come to listen song. 2023: People come to check views.");
        despacito.AddComment(despacito2);
        Comment despacito3 = new Comment("User-Stoxy", "This song never stops being good. No matter how many years pass, everyone comes back here.");
        despacito.AddComment(despacito3);
        videos.Add(despacito);
        foreach (Video video in videos)
        {
            Console.WriteLine($"{video.GetTitle()} - {video.GetAuthor()} - Length: {video.GetLength()} - Comments: {video.GetNumComments()}");
            List<Comment> comments = video.GetComments();
            foreach (Comment comment in comments)
            {
                Console.WriteLine($"{comment.GetName()} - {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}