using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");
        // Console.WriteLine("Program 1: Abstraction with YouTube Videos");
        //Video1
        Video video1 = new Video();
        video1.SetAuthor("Fontaine Cards");
        video1.SetLength(516);
        video1.SetTitle("Black Fontaines // Now Available");

        Comment comment1Video1 = new Comment();
        comment1Video1.SetComment("I swear Noel's flourish Virus is probably one of my favorite moves ive seen in awhile");
        comment1Video1.SetCommenter("gamerfreq");
        video1.SetComment(comment1Video1);

        Comment comment2Video1 = new Comment();
        comment2Video1.SetComment("Nice cards. I like the simplistic design; they look a bit nicer than Jerry's Nuggets, even");
        comment2Video1.SetCommenter("doordieace5high");
        video1.SetComment(comment2Video1);

        Comment comment3Video1 = new Comment();
        comment3Video1.SetComment("I think noel secretly has octopus tenticles as fingers because most of what he just did was insane");
        comment3Video1.SetCommenter("doordieace5high");
        video1.SetComment(comment3Video1);

        Comment comment4Video1 = new Comment();
        comment4Video1.SetComment("pledged 100 dollars for a brick of these. Big fan of yours Zach. Can't wait");
        comment4Video1.SetCommenter("DIOcelot");
        video1.SetComment(comment4Video1);

        // video1.Display();
        //Video2
        Video video2 = new Video();
        video2.SetAuthor("Jesus Channel");
        video2.SetTitle("Because of him");
        video2.SetLength(164);

        Comment comment1Video2 = new Comment();
        comment1Video2.SetComment("");
        comment1Video2.SetCommenter("");
        video2.SetComment(comment1Video2);

        Comment comment2Video2 = new Comment();
        comment2Video2.SetComment("So grateful for this video. Literally my fav church video ever. It brings me so much hope");
        comment2Video2.SetCommenter("Taylor Harper");
        video2.SetComment(comment2Video2);

        Comment comment3Video2 = new Comment();
        comment3Video2.SetComment("I needed see this video the devil flew away quickly he kept saying it’s too late it is not true");
        comment3Video2.SetCommenter("Rainbow Angel");
        video2.SetComment(comment3Video2);

        //Video3
        Video video3 = new Video();
        video3.SetAuthor("Red Bull Batalla");
        video3.SetLength(858);
        video3.SetTitle("CARPEDIEM vs GAZIR - Cuartos | Red Bull Batalla Internacional 2022");

        Comment comment1Video3 = new Comment();
        comment1Video3.SetComment("Que sepa Carpediem que los Colombianos estamos orgullosos de su trabajo en cada Inter");
        comment1Video3.SetCommenter("G13 Freestyle");
        video3.SetComment(comment1Video3);

        Comment comment2Video3 = new Comment();
        comment2Video3.SetComment("Carpe definitivamente está dentro del top 10 histórico de infravalorados");
        comment2Video3.SetCommenter("Miguel Garcia");
        video3.SetComment(comment2Video3);

        Comment comment3Video3 = new Comment();
        comment3Video3.SetComment("Lo de Carpe es el verdadero rap que ya casi no se encuentra");
        comment3Video3.SetCommenter("Joselo Music");
        video3.SetComment(comment3Video3);

        Comment comment4Video3 = new Comment();
        comment4Video3.SetComment("Carpediem lo partio. lo volvio a partir, lo siguio partiendo, y no hay nada que ningun Bnet o Aczino pueda decir al respecto. Esto era de Carpe. Sigue dandole duro! Esperemos verlo en otra inter!");
        comment4Video3.SetCommenter("Jose David");
        video3.SetComment(comment4Video3);

        Comment comment5Video3 = new Comment();
        comment5Video3.SetComment("Te quiero mucho Carpediem, gracias por el esfuerzo y el nivelazo🇨🇴");
        comment5Video3.SetCommenter("Sebastian Torres");
        video3.SetComment(comment5Video3);

        //video 4
        Video video4 = new Video();
        video4.SetAuthor("Morat");
        video4.SetTitle("Morat, Juanes - 506");
        video4.SetLength(181);

        Comment comment1Video4 = new Comment();
        comment1Video4.SetComment("Morat me tiene entre un pie a la depresión y el otro a la superación");
        comment1Video4.SetCommenter("Ariana Milagros Villavicencio Samame");
        video4.SetComment(comment1Video4);

        Comment comment2Video4 = new Comment();
        comment2Video4.SetComment("no hay nada mejor en el planeta que ver cantar a Morat y Juanes");
        comment2Video4.SetCommenter("A DONDE VAMOS");
        video4.SetComment(comment2Video4);

        Comment comment3Video4 = new Comment();
        comment3Video4.SetComment("De mis canciones favoritas ♡");
        comment3Video4.SetCommenter("kuki99");
        video4.SetComment(comment3Video4);

        Comment comment4Video4 = new Comment();
        comment4Video4.SetComment("Morat literalmente tiene una canción para todo , los amo");
        comment4Video4.SetCommenter("Gera Depablos");
        video4.SetComment(comment4Video4);

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach(Video videito in videos)
        {
            videito.Display();
            Console.WriteLine("");
        }

    }
}