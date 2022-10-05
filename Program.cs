using System;

namespace Lesson8Homework
{
    class Program
    {
        // Problem 1
        static void CheckString(string s)
        {
            if (IsLC(s[0]) && Len(s) >= 8 && IsNum(s[Len(s) - 1]))
                System.Console.WriteLine("good");
            else
                System.Console.WriteLine("not good");
        }

        static bool IsLC(char c) => (c >= 'a' && c <= 'z');
        static bool IsNum(char c) => (c >= '0' && c <= '9');

        // Problem 2
        static int Len(string str)
        {
            int length = 0;

            while (str.ElementAtOrDefault(length) != '\0')
                length++;

            return length;
        }

        // Problem 3
        static string MaxString(string str1, string str2)
        {
            if (Len(str2) > Len(str1))
            {
                return str2;
            }

            return str1;
        }

        // Problem 4
        static bool StrEqual(string str1, string str2)
        {
            int length = Len(str1);

            if (length != Len(str2))
            {
                return false;
            }

            for (int i = 0; i < length; i++)
            {
                if (str1[i] != str2[i])
                {
                    return false;
                }
            }

            return true;
        }

        // Check solutions:
        static void Prob1()
        {
            System.Console.WriteLine("\n_____Problem 1_____");

            // First is not lower case letter.
            string Str1 = "*******9";
            System.Console.WriteLine($"Expected output for {Str1}: not good");
            System.Console.Write("Actual output: ");
            CheckString(Str1);

            // Fewer than 8 chars.
            string Str2 = "z*****9";
            System.Console.WriteLine($"\nExpected output for {Str2}: not good");
            System.Console.Write("Actual output: ");
            CheckString(Str2);

            // Last is not num.
            string Str3 = "z*******";
            System.Console.WriteLine($"\nExpected output for {Str3}: not good");
            System.Console.Write("Actual output: ");
            CheckString(Str3);

            // All conditions satisfied.
            string Str4 = "z******9";
            System.Console.WriteLine($"\nExpected output for {Str4}: good");
            System.Console.Write("Actual output: ");
            CheckString(Str4);
        }

        static void Prob2()
        {
            System.Console.WriteLine("\n_____Problem 2_____");

            string str = "abcde";
            System.Console.WriteLine($"Expected output for {str}: {str.Length}");
            System.Console.WriteLine($"Actual output: {Len(str)}");
        }

        static void Prob3()
        {
            System.Console.WriteLine("\n_____Problem 3_____");

            string str1 = "E=mc^2";
            string str2 = "e^(iπ)+1=0";

            System.Console.WriteLine($"Longer of '{str1}' and '{str2}': '{MaxString(str1, str2)}'");
            System.Console.WriteLine($"Longer of '{str2}' and '{str1}': '{MaxString(str2, str1)}'");
        }

        static void Prob4()
        {
            System.Console.WriteLine("\n_____Problem 4_____");

            string str1 = "E=mc^2";
            string str2 = "e^(iπ)+1=0";
            string str3 = str1;
            char[] arr = str1.ToCharArray();
            Array.Reverse(arr);
            string str4 = new String(arr);

            System.Console.WriteLine($"'{str1}' is the same as '{str2}': {StrEqual(str1, str2)}");
            System.Console.WriteLine($"'{str1}' is the same as '{str3}': {StrEqual(str1, str3)}");
            System.Console.WriteLine($"'{str1}' is the same as '{str4}': {StrEqual(str1, str4)}");
        }
        static void Main(string[] args)
        {
            Prob1();
            Prob2();
            Prob3();
            Prob4();
        }
    }
}