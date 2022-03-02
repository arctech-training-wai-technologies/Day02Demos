// See https://aka.ms/new-console-template for more information

class Demo3LinearSearch
{
    internal static void Test()
    {
        int[] ages = new int[] { 33, 22, 54, 62, 45, 77, 22, 34, 65 };

        Console.Write("Enter the age to search: ");
        string ageText = Console.ReadLine();

        bool bFound = LinearSearch(ages, int.Parse(ageText));

        if (bFound)
            Console.WriteLine("Found the age");
        else
            Console.WriteLine("Age not found");

        int[] salaries = new int[] { 10000, 20000, 30000 };
        LinearSearch(salaries, 3000);
    }

    private static bool LinearSearch(int[] ages, int ageToSearch)
    {
        bool bFound = false;

        foreach (int age in ages)
        {
            if (age == ageToSearch)
            {
                bFound = true;
                break;
            }
        }

        return bFound;
    }
}