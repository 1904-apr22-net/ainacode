﻿using System;

namespace WeekOneCodeAssignment
{
    class Program
    {
        static void Main(string[] args)
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
            "123abccba123"
        follow best practices.**/


            IsPalindrome ascess = new IsPalindrome();


            Console.WriteLine("Hello World!");
        }
    }
}
