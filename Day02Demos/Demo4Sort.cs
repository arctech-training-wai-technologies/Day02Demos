// See https://aka.ms/new-console-template for more information

class Demo4Sort
{
    public static void Test()
    {
        Console.WriteLine("======= Sort Demo =======");
        Console.Write("How many numbers do you want to sort: ");
        string totalText = Console.ReadLine();
        int total = int.Parse(totalText);

        int[] arr = new int[total];

        for (int i = 0; i < total; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            string numText = Console.ReadLine();
            arr[i] = int.Parse(numText);
        }

        Console.WriteLine("\nThe unsorted array is: ");
        Display(arr);
        
        Sort(arr);
        
        Console.WriteLine("\n\nThe sorted array is: ");
        Display(arr);
    }

    public static void Sort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if(arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }    
            }
        }
    }

    static void Display(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + ",");
        }
    }
}


