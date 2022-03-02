// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//Demo1CommandLineArguments.Test(args);
//Demo2Palindrome.Test();
//Demo3LinearSearch.Test();
//Demo4Sort.Test();

Demo5BinarySearch.Test();

class Demo5BinarySearch
{
    public static void Test()
    {
        int[] arr = new[] { 5, 7, 9, 3, 2, 1, 55, 44, 88, 66, 33, 22 };

        Demo4Sort.Sort(arr);

        do
        {
            Console.Write("Enter number to search: ");
            string numText = Console.ReadLine();

            if (numText == "0")
                return;

            if (BinarySearch(arr, int.Parse(numText)))
                Console.WriteLine("Found Successfully");
            else
                Console.WriteLine("Did not find this number");
        }while(true);
    }

    private static bool BinarySearch(int[] arr, int num)
    {
        int lowIndex = 0, highIndex = arr.Length - 1;

        while (lowIndex <= highIndex)
        {
            int midIndex = (highIndex + lowIndex) / 2;

            if (num == arr[midIndex])
                return true;
            else if (num < arr[midIndex])
                highIndex = midIndex - 1;
            else if (num > arr[midIndex])
                lowIndex = midIndex + 1;
        }

        return false;
    }
}