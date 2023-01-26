using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        // Book book1 = new Book();
        // book1.SetAuthor("Mormon");
        // book1.SetTitle("The Book of Mormon");
        // Console.WriteLine(book1.GetBookInformation());

        // PictureBook book2 = new PictureBook();
        // book2.SetAuthor("Adriana Robles");
        // book2.SetTitle("My 6 Treasures");
        // book2.SetIllustrator("Jose David");
        // Console.WriteLine(book2.GetPictureBookInfo());

        // Book book3= new Book("Edwards", "Oscar de leon");
        // Console.WriteLine(book3.GetBookInformation());

        // PictureBook book4 = new PictureBook("Magic Trucos", "Jose", "David");
        // //book4.SetIllustrator("Gustavo");
        // Console.WriteLine(book4.GetPictureBookInfo());

        Assign assignment = new Assign("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());


    }
}