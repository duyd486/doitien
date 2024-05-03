internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("nhap so $ can doi: ");
        float dola = float.Parse(Console.ReadLine());
        float vnd = dola * 23000;
        Console.WriteLine("So tien khi chuyen qua vnd la: " + vnd);
    }
}