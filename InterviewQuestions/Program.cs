using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace InterviewQuestions
{
    class Program
    {


        static void Main(string[] args)
        {
            ////####### NOTES ####### Just some loops. 
            ////While Loop: 
            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            ////Do While Loop:
            //int i = 5;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while (i < 10);

            ////For Loop: 
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            ////foreach Loop: 
            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //foreach (string i in cars)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.ReadLine();



            ////####### 1 ####### Sum evens and odds of an array. 

            //int[] arr = { 2, 4, 9, 16, 27, 77, 98 }; //Declare and initialize an array.
            //int even = 0, odd = 0; //Declare variables to hold sum of even and odd values.
            //List<int> Even = new List<int>();

            //// Loop to find even, odd sum
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 == 0) //value at index i, using modulus operator, when dividing by two if there is no remainder, value is even
            //    {
            //        even += arr[i]; //add value on the right to value on the left and maintain new value in variable on the left
            //        Even.Add(arr[i]); //add Even values to a new list to print off. Can't use an array because those are fixed length in C#.
            //    }
            //    else
            //        odd += arr[i];
            //}

            //Console.WriteLine("Sum of even values: " + even);
            //Console.WriteLine("Sum of odd values: " + odd);
            //Console.WriteLine("Even list: [{0}]", string.Join(", ", Even));
            //Console.ReadLine();

            ////####### 2 ####### implicit and explicit casting.
            //int[] arr = { 12, 900000000, 4, 900000000 };
            //long[] b = Array.ConvertAll(arr, val => (long)val); // Caste array to new data type before summing.  
            //int sum = 0; // initialize sum

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}

            //Console.WriteLine("Sum of given array is " + sum);
            //Console.ReadLine();

            ////####### 3 ####### reverse a string.

            ////SHORTHAND
            //string s = "microsoft";
            //char[] arr = s.ToCharArray();
            //Console.WriteLine("before reversal:" + arr);
            //Array.Reverse(arr); //the reverse method is a shorthand way to reverse an array. 
            //Console.WriteLine("AFTER reversal:" + string.Join("", arr)); //write array as a joined string.

            ////LONGHAND w/ INTEGERS
            //int[] arr = { 4, 6, 90, 35 };
            //Console.WriteLine("before reversal:" + string.Join(", ", arr)); //display array before reversal.
            //int end = arr.Length - 1;
            //int start = 0;
            //int temp;

            //while (start < end)
            //{
            //    temp = arr[start];
            //    arr[start] = arr[end];
            //    arr[end] = temp;
            //    start++;
            //    end--;
            //}

            //Console.WriteLine("AFTER reversal:" + string.Join(", ", arr)); //write array as a joined string.
            //Console.ReadLine();


            ////####### 4 ####### remove duplicates
            //string myStr = "kkllmmnnoo";
            //Console.WriteLine("Initial String: " + myStr);
            ////var unique = new HashSet<char>(myStr);
            ////Console.Write("New String after removing duplicates: ");
            ////foreach (char c in unique)
            ////    Console.Write(c);
            ////Console.ReadLine();

            ////Defining a method
            ////public static string RemoveDuplicates(string input) { return new string(input.ToCharArray().Distinct().ToArray()); }
            ////Console.WriteLine(RemoveDuplicates(myStr));

            ////Linq statement.
            //Console.WriteLine(myStr.ToCharArray().Distinct().ToArray());

            //////####### 5 ####### FIZZ BUZZ
            //int x = 0;
            //while (x < 100)
            //{
            //    if (x % 3 == 0 && x % 5 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }
            //    else if (x % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (x % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(x);
            //    }
            //    x++;
            //}
            //Console.ReadLine();

            //////####### 6 ####### most repeating character
            //string str = "aaaaaaabbcbbbbcbbbb"; //string
            //int len = str.Length;   //make a variable for total length
            //int count = 0;  //varialbe to keep track of value
            //char res = str[0]; //a placeholder for most repeated value in string

            //for (int i = 0; i < len; i++)
            //{
            //    int cur_count = 1;
            //    for (int j = i + 1; j < len; j++)
            //    {
            //        if (str[i] != str[j])
            //        {
            //            break;
            //        }
            //        else cur_count++;
            //    }
            //    // Update result if required
            //    if (cur_count > count)
            //    {
            //        count = cur_count;
            //        res = str[i];
            //    }
            //}
            //Console.WriteLine(res);
            //Console.ReadLine();


            //////####### 7 ####### combine two sorted arrays
            //int[] A = { 1, 5, 7, 12, 18, 32 };
            //int[] B = { 2, 4, 9, 16, 27, 76, 98 };

            ////Using a list.
            //List<int> newList = new List<int>();
            //foreach (int item in A)
            //{
            //    newList.Add(item);
            //}
            //foreach (int item in B)
            //{
            //    newList.Add(item);
            //}
            //Console.WriteLine(string.Join(", ", newList));
            //newList.Sort();
            //Console.WriteLine("Sorted List:" + string.Join(", ", newList));
            //Console.ReadLine();

            ////Not using list. 
            //int aLength = A.Length;
            //int bLength = B.Length;
            //int cLength = aLength + bLength;
            //int[] C = new int[cLength];
            //int counter = 0;

            //for (int i = 0; i < aLength -1; i++)
            //{
            //    C[counter] = A[i];
            //    counter++;
            //}
            //for (int j = 0; j < bLength -1; j++)
            //{
            //    C[counter] = B[j];
            //    counter++;
            //}

            //Console.WriteLine(string.Join(", ", C));
            //Array.Sort(C);
            //Console.WriteLine("Sorted List:" + string.Join(", ", C));
            //Console.ReadLine();


            ////////####### 8 ####### negative numbers to the left
            //int[] arr = { 10, 2, -3, 4, 5, 6, -7, 8, 9 };
            //int temp;
            //int j = 0;

            //for (int i = 0; i < arr.Length-1; i++)
            //{
            //    if (arr[i]<0)
            //    {
            //        temp = arr[i];
            //        arr[i] = arr[j];
            //        arr[j] = temp;
            //        j++;
            //    }
            //}
            //Console.WriteLine("Sorted Array:" + string.Join(", ", arr));
            //Console.ReadLine();

            //////####### 8 ####### negative numbers to the left
            //int[] arr = { 0, 1, 0, 1, 0, 0, 1, 1, 1, 0 };
            //int count = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == 0)
            //        count++;
            //}

            //for (int i = 0; i < count; i++)          // loop fills the arr with 0 until count

            //    arr[i] = 0;

            //for (int i = count; i < arr.Length; i++) // loop fills remaining arr space with 1
            //    arr[i] = 1;

            //Console.WriteLine("Sorted Array:" + string.Join(", ", arr));
            //Console.ReadLine();


            //////####### 9 ####### find if sum of two values equals a number

            //int[] arr = { 9, 29, 10, 2, 50, 24, 100 };
            //int n = 50;
            //int size = arr.Length;
            //bool x = false;

            //// Initialize positions of two elements
            //int i = 0, j = 1;

            //// Search for a pair
            //do
            //{
            //    if (i != j && arr[j] - arr[i] == n)
            //    {
            //        Console.WriteLine("Pair Found: "
            //        + "( " + arr[i] + ", " + arr[j] + " )");
            //        x = true;

            //    }
            //    else if (arr[j] - arr[i] < n)
            //        j++;
            //    else
            //        i++;
            //}
            //while (x == false);

            //Console.ReadLine();




            ////////####### 15 ####### find if sum of two values equals a number

            //int [] A = { 1, 4, 45, 6, 10, 8 };
            //int arr_size = A.Length;
            //int sum = 22;

            //for (int i = 0; i < arr_size - 2; i++)
            //{
            //    HashSet<int> s = new HashSet<int>();    // Find pair in sub array A[i+1..n-1] with sum equal to sum - A[i]
            //    int curr_sum = sum - A[i];
            //    for (int j = i + 1; j < arr_size; j++)
            //    {
            //        if (s.Contains(curr_sum - A[j]))
            //        {
            //            Console.Write("Triplet is ({0}, {1}, {2})", A[i], A[j], curr_sum - A[j]);
            //        }
            //        s.Add(A[j]);
            //    }
            //}
            //Console.ReadLine();


            ////////####### 16 ####### find if sum of two values equals a number

            //string[] s = "i like this program very much".Split(' ');
            //Console.WriteLine("Original string: " + string.Join(" ", s));
            //string ans = "";
            //for (int i = s.Length - 1; i >= 0; i--)
            //{
            //    ans += s[i] + " ";
            //}
            //Console.Write("Reversed String: ");
            //Console.Write(ans.Substring(0, ans.Length - 1));
            //Console.ReadLine();


            ////////####### 17 ####### searching for anagrams
            // Get lenghts of both strings
            //string str1 = "them";
            //string str2 = "meth";
            //bool anagram = false;

            //int n1 = str1.Length;
            //int n2 = str2.Length;

            //// If length of both strings is not
            //// same, then they cannot be anagram
            //if (n1 != n2)
            //{
            //    anagram = false;
            //}

            //// Sort both strings
            //char[] one = str1.ToCharArray();
            //Array.Sort(one);
            //char[] two = str2.ToCharArray();
            //Array.Sort(two);

            //// Compare sorted strings
            //for (int i = 0; i < n1; i++)
            //{
            //    if (one[i] != two[i])
            //    {
            //        anagram = false;
            //    }
            //    else
            //    {
            //        anagram = true;
            //    }
            //}
            //Console.WriteLine(anagram);

            ////////####### 21 ####### factorial of a number

            //// method to find factorial of given number
            //int num = 5;
            //int total = num;
            //while (num - 1 > 0)
            //{
            //    total = total * (num - 1);
            //    num--;
            //}
            //Console.WriteLine("Factorial of " + 5 + " is " + total);
            //Console.ReadLine();



            //////////####### 22 ####### two sum problem
            //int[] arr = { 3, 5, 2, -4, 8, 11 };
            //int S = 7;

            //// check each element in array
            //for (var i = 0; i < arr.Length; i++)
            //{
            //    // check each other element in the array
            //    for (var j = i + 1; j < arr.Length; j++)
            //    {
            //        // determine if these two elements sum to S
            //        if (arr[i] + arr[j] == S)
            //        {
            //            Console.WriteLine(string.Join(", ", arr[i], arr[j]));
            //        }

            //    }

            //}

            //////////####### 23 ####### two sum problem
            ////Console.WriteLine("write a name without any spaces in it.");
            ////string str = (Console.ReadLine().ToLower());
            //string str = "GeeksforGeeks";
            //var tf = false;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    for (int j = i + 1; j < str.Length; j++)
            //    {
            //        if (str[i] == str[j])
            //        {
            //            tf = true;
            //            break;
            //        }
            //    }
            //}
            //if (tf == false)
            //{
            //    Console.WriteLine("The String " + str + " has all unique characters");
            //}
            //else
            //{
            //    Console.WriteLine("The String " + str + " has duplicate characters");
            //}

            ////Combine two lists to make a unique list.
            //List<string> farewells = new List<string>() { "bye", "bonvoyage", "bye" };
            //List<string> matches = new List<string>();

            //foreach (string farewell in farewells)
            //{
            //    if (matches.Contains(farewell))
            //    {
            //        Console.WriteLine(farewell + " has been seen already");
            //    }
            //    else
            //    {
            //        Console.WriteLine(farewell);
            //        matches.Add(farewell);
            //    }
            //}
            //matches.ForEach(i => Console.Write("{0}\t",i));
            //Console.ReadLine();

            //        //////////####### 24 ####### REACT COMPONENT
            //        Import React, { Component} from "react"
            //            class ToDoLIst extends component
            //    {
            //        constructor(props){
            //        super(props);
            //    CallConvThiscall.state ={
            //        tasks:[]
            //};
            //this.add=this.add.bindd(this);


            /////###### Write with delay
            int[] arr = { 3, 4, 5, 6, 7, 8, 8};

            for (var i = 0; i< arr.Length; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(arr[i]);
            }

        }
    }
}


