namespace assignment_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
                   //question 1
        string title = "clean code";
        string uppertitle = title.ToUpper();
        Console.WriteLine(title);
        Console.WriteLine(uppertitle);
        //question 2
        string str1 = "clean code";
        string str2 = "clean code";
        Console.WriteLine(ReferenceEquals(str1,str2));
        //question 3
        StringBuilder sb = new StringBuilder();
        sb.Append("book list");
        sb.Append("updated");;
        Console.WriteLine(sb);
        //question 4
        sb.Replace("book list","library");
        Console.WriteLine(sb);
        //question 5
        string title2 = "clean code";
        int pages = 464;
        string result1 = "book" + title2 + "pages" + pages;
        Console.WriteLine(result1);
        //question 6
        string result2 = $"book{ title2}, pages{ pages}";
        Console.WriteLine(result2);
        //question 7
        string results3 = string.Format("book:{0},pages:{1}", title2, pages);
        Console.WriteLine(results3);

        }
    }
}
