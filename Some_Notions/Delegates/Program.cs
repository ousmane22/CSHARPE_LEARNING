

public delegate void HelloFonctionDelegate(string message);

public class program
{
    public static void Main()
    {
        HelloFonctionDelegate handle = Hello;
        handle("Hello from delage");
    }
    public static void Hello(string msgHello)
    {
        Console.WriteLine(msgHello);
    }
}
