﻿using System;
using System.Linq;

namespace Basic_Exercises
{
    class Program
    {
        static void Main(string[] args) {
            //SayHello();
            //SumTwo();
            //DivideTwo();
            //SpecOps();
            //Swap();
            //MultThree();
            //AllOps();
            //Multable();
            //Average();
            //SillyMath();
            //AgeInsulter();
            //DisplayDigit();
            //RectNum();
            //TempConv();
            //DelChar();
            //LetSwap();
            //TackOn();
            OneOfEach();
        }



        /*
         1. Write a C# Sharp program to print Hello and your name in a separate line. Go to the editor
        Expected Output :
        Hello: Alexandra Abramov
        */
        static void SayHello() {
            Console.WriteLine("Hello: ");
            Console.WriteLine("Alexandra Abramov");
        }


        /*
        2. Write a C# Sharp program to print the sum of two numbers. Go to the editor
        */
        static void SumTwo() {
            Console.Write("\n\nEnter the first number: ");
            int first_num = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the second number: ");
            int second_num = int.Parse(Console.ReadLine());
            Console.Write($"\nThe sum of {first_num} and {second_num} is {first_num + second_num}\n");
        }
        
        /*
        3. Write a C# Sharp program to print the result of dividing two numbers. Go to the editor
        */
        static void DivideTwo() {
            Console.Write("\n\nEnter the first number: ");
            double first_num = double.Parse(Console.ReadLine());
            Console.Write("\nEnter the second number: ");
            double second_num = double.Parse(Console.ReadLine());
            Console.Write($"\n{first_num} divided by {second_num} is {first_num / second_num}\n");
        }

        /*
        4. Write a C# Sharp program to print the result of the specified operations. Go to the editor
        Test data:
        -1 + 4 * 6
        ( 35+ 5 ) % 7
        14 + -4 * 6 / 11
        2 + 15 / 6 * 1 - 7 % 2
        Expected Output:
        23
        5
        12
        3
        */
        static void SpecOps() {
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        }

        /*
        5. Write a C# Sharp program to swap two numbers. Go to the editor
        Test Data:
        Input the First Number : 5
        Input the Second Number : 6
        Expected Output:
        After Swapping :
        First Number : 6
        Second Number : 5
        */
        static void Swap() {
            Console.Write("\nInput the First Number : ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("\nInput the Second Number : ");
            int secon = int.Parse(Console.ReadLine());
            int temp = first;
            first = secon;
            secon = temp;
            Console.Write($"\nAfter Swapping :\nFirst Number : {first}\nSecond Number : {secon}\n");
        }

        /*
        6. Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user. Go to the editor
        Test Data:
        Input the first number to multiply: 2
        Input the second number to multiply: 3
        Input the third number to multiply: 6
        Expected Output:
        2 x 3 x 6 = 36
        */
        static void MultThree() {
            Console.WriteLine("Input the first number to multiply: ");
            int fst = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number to multiply: ");
            int snd = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the third number to multiply: ");
            int trd = int.Parse(Console.ReadLine());
            Console.WriteLine($"{fst} x {snd} x {trd} = {fst * snd * trd}");
        }

        /*
        7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing 
        of two numbers which will be entered by the user. Go to the editor
        Test Data:
        Input the first number: 25
        Input the second number: 4
        Expected Output:
        25 + 4 = 29
        25 - 4 = 21
        25 x 4 = 100
        25 / 4 = 6
        25 mod 4 = 1
       */
        static void AllOps() {
            Console.WriteLine("Input the first number: ");
            int fst = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number: ");
            int snd = int.Parse(Console.ReadLine());
            Console.WriteLine($"{fst} + {snd} = {fst + snd}");
            Console.WriteLine($"{fst} - {snd} = {fst - snd}");
            Console.WriteLine($"{fst} x {snd} = {fst * snd}");
            Console.WriteLine($"{fst} / {snd} = {fst / snd}");
            Console.WriteLine($"{fst} mod {snd} = {fst % snd}");
        }

        /*
        8. Write a C# Sharp program that takes a number as input and print its multiplication table. Go to the editor
        Test Data:
        Enter the number: 5
        Expected Output:
        5 * 0 = 0
        5 * 1 = 5
        5 * 2 = 10
        5 * 3 = 15
        ....
        5 * 10 = 50
        */
        static void Multable() {
            Console.WriteLine("Enter a number: ");
            int input = int.Parse(Console.ReadLine());
            for (int i=0; i<100; i++){
                Console.WriteLine($"{input} * {i} = {input * i}");
            }
        }

        /*
        9. Write a C# Sharp program that takes four numbers as input to calculate and print the average. Go to the editor
        Test Data:
        Enter the first number: 10
        Enter the second number: 15
        Enter the third number: 20
        Enter the fourth number: 30

        Expected Output:
        The average of 10 , 15 , 20 , 30 is: 18
        */
        static void Average() {
            string[] names = { "first", "second", "third", "fourth" };
            int[] numbers = new int[4];
            for (int i = 0; i < 4; i++) {
                Console.WriteLine("Enter the " + names[i] + " number: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The average of {numbers[0]}, {numbers[1]}, {numbers[2]}, {numbers[3]} is: {(double)numbers.Sum()/4}");
        }

        /*
        10. Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z. Go to the editor
        Test Data:
        Enter first number - 5
        Enter second number - 6
        Enter third number - 7

        Expected Output:
        Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72
        */
        static void SillyMath() {
            int first, second, third;
            Console.Write("\nEnter the first number: ");
            first = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the second number: ");
            second = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the third number: ");
            third = int.Parse(Console.ReadLine());
            Console.WriteLine($"\n(first + second) x third = {(first + second) * third} and first x second + second x third = {first * second + second * third}");
        }

        /*
        11. Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20". Go to the editor
        Test Data:
        Enter your age - 25
        Expected Output:
        You look older than 25
        */
        static void AgeInsulter() {
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            Console.WriteLine($"Wow! You're awfully ugly for {age}.");
        }

        /*
        12. Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), 
        and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}. Go to the editor
        Test Data:
        Enter a digit: 25
        Expected Output:
        25 25 25 25
        25252525
        25 25 25 25
        25252525
        */
        static void DisplayDigit() {
            Console.WriteLine("Please enter a whole number.");
            string input = Console.ReadLine();
            if (uint.TryParse(input, out uint result)) {
                Console.Write($"{result} {result} {result} {result}\n{result}{result}{result}{result}\n{result} {result} {result} {result}\n{result}{result}{result}{result}\n");
            }
        }

        /*
        13. Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit. Go to the editor
        Test Data:
        Enter a number: 5
        Expected Output:
        555
        5 5
        5 5
        5 5
        555
        */
        static void RectNum() {
            Console.WriteLine("Please enter a whole number.");
            string input = Console.ReadLine();
            if (uint.TryParse(input, out uint result)) {
                int num_spaces = input.Length;
                string spaces = "";
                for (int i = 0; i < num_spaces; i++) {
                    spaces += " ";
                }
                Console.Write($"{result}{result}{result}\n{result}" + spaces + $"{result}\n{result}" + 
                    spaces + $"{result}\n{result}" + spaces + $"{result}\n{result}{result}{result}\n");
            }
        }

        /*
        14. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit. Go to the editor
        Test Data:
        Enter the amount of celsius: 30
        Expected Output:
        Kelvin = 303
        Fahrenheit = 86
        */
        static void TempConv() {
            Console.WriteLine("Enter degrees celsius: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double result)) {
                Console.WriteLine($"Kelvin = {result + 273}");
                Console.WriteLine($"Fahrenheit = {1.8*result+32}");
            }
        }

        /*
        15. Write a C# program remove specified a character from a non-empty string using index of a character. Go to the editor
        Test Data:
        w3resource
        Sample Output:
        wresource
        w3resourc
        3resource
        */
        static void DelChar() {

            Console.Write("Enter a some text: ");
            string text = Console.ReadLine();

            Console.WriteLine("Which character should I remove?");
            char toREm = Console.ReadLine().First();

            Console.WriteLine("Should I remove all instances? Y/N");
            char resp = Console.ReadLine().First();

            if (resp == 'N' || resp == 'n') 
            {//Remove() will cause an out of range exception if the character isn't in the string.
                if (text.Contains(toREm)) 
                    text = text.Remove(text.IndexOf(toREm), 1);
            } 
            else if (resp == 'Y' || resp == 'y') 
            {
                for (int i = text.Length - 1; i > 0; i--) {
                    if (text.Contains(toREm))
                        text = text.Remove(text.IndexOf(toREm), 1);
                }
            }

            Console.WriteLine($"The text with the character deleted is: {text}");
        }

        /*
        16. Write a C# program to create a new string from a given string where the first and last characters will change their positions. Go to the editor
        Test Data:
        w3resource
        Python
        Sample Output:
        e3resourcw
        nythoP
        */
        static void LetSwap() {
            Console.Write("Enter some text: ");
            string text = Console.ReadLine();
            char first = text.First();
            char last = text.Last();
            text = text.Remove(0, 1);
            text = text.Remove(text.Length -1, 1);
            text += first;
            text = last + text;
            Console.Write($"With the first and last reversed: {text}");
        }

        /*
        17. Write a C# program to create a new string from a given string (length 1 or more ) with 
        the first character added at the front and back. Go to the editor
        Sample Output:
        Input a string : The quick brown fox jumps over the lazy dog.
        TThe quick brown fox jumps over the lazy dog.T
        */
        static void TackOn() {
            Console.Write("Enter some text: ");
            string text = Console.ReadLine();
            char first = text.First();
            text += first;
            text = first + text;
            Console.Write($"With the first letter added front and back: {text}");
        }

        /*
        18. Write a C# program to check two given integers and return true if one is negative and one is positive. Go to the editor
        Sample Output:
        Input first integer:
        -5
        Input second integer:
        25
        Check if one is negative and one is positive:
        True
        */
        static void Swap(ref int int1, ref int int2) {
            int temp = int1;
            int1 = int2;
            int2 = temp;
        }
        static void OneOfEach() {
            Console.Write("Enter an interger: ");
            int int1 = int.Parse(Console.ReadLine());
            Console.Write("Enter another integer: ");
            int int2 = int.Parse(Console.ReadLine());
            //Put the larger one first
            if (int1 < int2) Swap(ref int1, ref int2);
            //if absolute value of addition is greater than larger of two then signs are the same
            if (Math.Abs(int1 + int2) >= int1) Console.WriteLine("False");
            else Console.WriteLine("True");
        }

        /*
        19. Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum. Go to the editor
        */

        /*
        20. Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than second number. Go to the editor
        */

        /*
        21. Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20. Go to the editor
        */

        /*
        22. Write a C# program to check if an given integer is within 20 of 100 or 200. Go to the editor
        Sample Output:
        Input an integer:
        25
        False
        */

        /*
        23. Write a C# program to convert a given string into lowercase. Go to the editor
        Sample Output:
        write a c# sharp program to display the following pattern using the alphabet.
       */

        /*
        24. Write a C# program to find the longest word in a string. Go to the editor
        Test Data: Write a C# Sharp Program to display the following pattern using the alphabet.
        Sample Output:
        following
        */

        /*
        25. Write a C# program to print the odd numbers from 1 to 99. Prints one number per line. Go to the editor
        Sample Output:
        Odd numbers from 1 to 99. Prints one number per line.
        1
        3
        5
        7
        9
        ...
        95
        97
        99
        */

        /*
        26. Write a C# program to compute the sum of the first 500 prime numbers. Go to the editor
        Sample Output:
        Sum of the first 500 prime numbers:
        824693
        */

        /*
        27. Write a C# program and compute the sum of the digits of an integer. Go to the editor
        Sample Output:
        Input a number(integer): 12
        Sum of the digits of the said integer: 3
        */

        /*
        28. Write a C# program to reverse the words of a sentence. Go to the editor
        Sample Output:
        Original String: Display the pattern like pyramid using the alphabet.
        Reverse String: alphabet. the using pyramid like pattern the Display
        */

        /*
        29. Write a C# program to find the size of a specified file in bytes. Go to the editor
        Sample Output:
        Size of a file: 31
        */

        /*
        30. Write a C# program to convert a hexadecimal number to decimal number. Go to the editor
        Sample Output:
        Hexadecimal number: 4B0
        Convert to-
        Decimal number: 1200
        */

        /*
        31. Write a C# program to multiply corresponding elements of two arrays of integers. Go to the editor
        Sample Output:
        Array1: [1, 3, -5, 4]
        Array2: [1, 4, -5, -2]
        Multiply corresponding elements of two arrays:
        1 12 25 -8
        */

        /*
        32. Write a C# program to create a new string of four copies, taking last four characters from a given string. If the length of the given string is less than 4 return the original one. Go to the editor
        Sample Output:
        Input a string : The quick brown fox jumps over the lazy dog.
        dog.dog.dog.dog.
        */

        /*
        33. Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7. Go to the editor
        Sample Output:
        Input first integer:
        15
        True
        */

        /*
        34. Write a C# program to check if a string starts with a specified word. Go to the editor
        Note: Suppose the sentence starts with "Hello"
        Sample Data: string1 = "Hello how are you?"
        Result: Hello.
        Sample Output:
        Input a string : Hello how are you?
        True
        */

        /*
        35. Write a C# program to check two given numbers where one is less than 100 and other is greater than 200. Go to the editor
        Sample Output:
        Input a first number(<100): 75
        Input a second number(>100): 250
        True
        */

        /*
        36. Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10. Go to the editor
        Sample Output:
        Input a first number: -5
        Input a second number: 8
        True
        */

        /*
        37. Write a C# program to check if "HP" appears at second position in a string and returns the string without "HP". Go to the editor
        Test Data: PHP Tutorial
        Sample Output:
        P Tutorial
        */

        /*
        38. Write a C# program to get a new string of two characters from a given string. The first and second character of the given string must be "P" and "H", so PHP will be "PH". Go to the editor
        Test Data: PHP
        Sample Output:
        PH
        */

        /*
        39. Write a C# program to find the largest and lowest values from three integer values. Go to the editor
        Test Data:
        Input first integer:
        15
        Input second integer:
        25
        Input third integer:
        30
        Sample Output
        Largest of three: 30
        Lowest of three: 15
        */

        /*
        40. Write a C# program to check the nearest value of 20 of two given integers and return 0 if two numbers are same. Go to the editor
        Test Data:
        Input first integer:
        15
        Input second integer:
        12
        Sample Output
        15
        */

        /*
        41. Write a C# program to check if a given string contains ‘w’ character between 1 and 3 times. Go to the editor
        Test Data:
        Input a string (conatins at least one 'w' char) : w3resource
        Test the string contains 'w' character between 1 and 3 times:
        Sample Output
        True
        */

        /*
        42. Write a C# program to create a new string where the first 4 characters will be in lower case. If the string is less than 4 characters then make the whole string in upper case. Go to the editor
        Test Data:
        Input a string: w3r
        Sample Output
        W3R
        */

        /*
        43. Write a C# program to check if a given string starts with "w" and immediately followed by two "ww". Go to the editor
        Test Data:
        Input a string : www
        Sample Output
        False
        */

        /*
        44. Write a C# program to create a new string of every other character (odd position) from the first position of a given string. Go to the editor
        Test Data:
        Input a string : w3resource
        Sample Output
        wrsuc
        */

        /*
        45. Write a C# program to count a specified number in a given array of integers. Go to the editor
        Test Data:
        Input an integer: 5
        Sample Output
        Number of 5 present in the said array: 2
        */

        /*
        46. Write a C# program to check if a number appears as either the first or last element of an array of integers and the length is 1 or more. Go to the editor
        Test Data:
        Input an integer: 25
        Sample Output
        False
        */

        /*
        47. Write a C# program to compute the sum of all the elements of an array of integers. Go to the editor
        Test Data:
        Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
        Sample Output
        Sum: 69
        */

        /*
        48. Write a C# program to check if the first element and the last element are equal of an array of integers and the length is 1 or more. Go to the editor
        Test Data:
        Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
        Sample Output
        True
        */

        /*
        49. Write a C# program to check if the first element or the last element of the two arrays ( length 1 or more) are equal. Go to the editor
        Test Data:
        Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
        Array2: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5]
        Check if the first element or the last element of the two arrays ( leng th 1 or more) are equal.
        Sample Output
        True
        */

        /*
        50. Write a C# program to rotate an array (length 3) of integers in left direction. Go to the editor
        Test Data:
        Array1: [1, 2, 8]
        After rotating array becomes: [2, 8, 1]
        */

        /*
        51. Write a C# program to get the larger value between first and last element of an array (length 3) of integers. Go to the editor
        Test Data:
        Array1: [1, 2, 5, 7, 8]
        Highest value between first and last values of the said array: 8
        */

        /*
        52. Write a C# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers. Go to the editor
        Test Data:
        Array1: [1, 2, 5]
        Array2: [0, 3, 8]
        Array3: [-1, 0, 2]
        New array: [2, 3, 0]
        */

        /*
        53. Write a C# program to check if an array contains an odd number. Go to the editor
        Test Data:
        Original array: [2, 4, 7, 8, 6]
        Check if an array contains an odd number? True
        */

        /*
        54. Write a C# program to get the century from a year. Go to the editor
        */

        /*
        55. Write a C# program to find the pair of adjacent elements that has the largest product of an given array which is equal to a given value. Go to the editor
        */

        /*
        56. Write a C# program to check if a given string is a palindrome or not. Go to the editor
        Sample Example:
        For 'aaa' the output should be true
        For 'abcd' the output should be false
        */

        /*
        57. Write a C# program to find the pair of adjacent elements that has the highest product of an given array of integers. Go to the editor
        */

        /*
        58. Write a C# program which will accept a list of integers and checks how many integers are needed to complete the range. Go to the editor
        Sample Example [1, 3, 4, 7, 9], between 1-9 -> 2, 5, 6, 8 are not present in the list. So output will be 4.
        */

        /*
        59. Write a C# program to check whether it is possible to create a strictly increasing sequence from a given sequence of integers as an array. Go to the editor
        */

        /*
        60. Write a C# program to calculate the sum of all the intgers of a rectangular matrix except those integers which are located below an intger of value 0. Go to the editor
        Sample Example:
        matrix = [[0, 2, 3, 2],
        [0, 6, 0, 1],
        [4, 0, 3, 0]]
        Eligible integers which will be participated to calculate the sum -
        matrix = [[X, 2, 3, 2],
        [X, 6, X, 1],
        [X, X, X, X]]
        Therefore sum will be: 2 + 3 + 2 + 6 + 1 = 14
        */

        /*
        61. Write a C# program to sort the integers in ascending order without moving the number -5. Go to the editor
        */

        /*
        62. Write a C# program to reverse the strings contained in each pair of matching parentheses in a given string and also remove the parentheses within the given string.
         */

    }
}