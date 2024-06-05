namespace Assignment5._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();
            
            bool result = IsPalindrome(word, 0, word.Length-1);
            if (result)
            {
                Console.WriteLine($"{word} is a Palindrome");
            }
            else
            {
                Console.WriteLine($"{word} is not a Palindrome");
            }
        }

        static bool IsPalindrome(string word, int start, int end)
        {
            if (start >= end  )
            {
                return true;
            }

            if (word[start] != word[end])
            {
                return false;
            }
            return IsPalindrome(word, start + 1, end - 1);
        }

       
    }
}
