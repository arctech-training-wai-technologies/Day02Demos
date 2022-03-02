// See https://aka.ms/new-console-template for more information
class Demo1CommandLineArguments
{
    public static void Test(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Total command line arguments = " + args.Length);
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine(args[i]);
        }
    }
}
