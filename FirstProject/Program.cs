public class Program
{
    public void Add()
    {
        int a, b, c;
        a = 1;
        b = 2;
        c = a+ b;
        Console.WriteLine("Addition="+c);
    }

    public void Mul()
    {
        int a, b, c;
        a = 5;
        b = 4;
        c = a * b;
        Console.WriteLine("Multiplication=" + c);
    }
    public static void Main(string[] args)
    {
        Program program = new Program();
        program.Add();
        program.Mul();
        Console.ReadLine();
    }
}
