using System.Text;

class Program{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Hello");
        sb.Append(" ");
        sb.Append("World");
        Console.WriteLine(sb.ToString());
    }
}