using System;

namespace IsPalindrome1
{
    class Program
    {
        /**two projects, a library project and a unit test project.
        library should have a class that can tell me whether a string is a palindrome or not.
        all the behavior of the class should be unit tested.
        a palindrome reads the same forwards and backwards.
        for example, these should be considered palindromes:
            "nurses run"
            "racecaR"
            "1221"
            "never odd, or even."
        for example, these should not be considered palindromes:
            "one two one"
            "123abccba123"**/
        public static bool IsPalindrome(string Reversiblewords)
        {
            int min = 0;
            int max = Reversiblewords.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = Reversiblewords[min];
                char b = Reversiblewords[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }

 static void Main()
        {
            string[] array =
                {
                    "civic",
                    "deleveled",
                    "Hannah",
                    "kayak",
                    "level",
                    "examiron",
                    "racecar",
                    "radar",
                    "refer",
                    "reviver",
                    "easywcf",
                    "rotator",
                    "rotor",
                    "sagas",
                    "solos",
                    "stats",
                    "tenet",                    
                    ""
                };

            foreach (string value in array)
            {
                Console.WriteLine("{0} = {1}", value, IsPalindrome(value));
            }


        }
    }
}
