// See https://aka.ms/new-console-template for more information
class Demo2Palindrome
{
    public static void Test()
    {
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();

        if (IsPalindrome(word))
            Console.WriteLine("Yes!! " + word + " is a palindrome");
        else
            Console.WriteLine("No!! " + word + " is NOT a palindrome");

        if (IsPalindrome("nitin"))
            Console.WriteLine("Yes!! Nitin is a palindrome");
        else
            Console.WriteLine("No!! Nitin is NOT a palindrome");    
    }

    public static bool IsPalindrome(string word)
    {
        int startIndex = 0;
        int endIndex = word.Length - 1;

        while (startIndex < endIndex)
        {
            if (word[startIndex++] != word[endIndex--])
            {
                return false;
            }
        }

        return true;
    }
}