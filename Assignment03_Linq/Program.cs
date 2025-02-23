using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;
using static Assignment03_Linq.ListGenerators;
namespace Assignment03_Linq
{
    internal class Programs
    {
        static void Main(string[] args)
        {

            #region LINQ - Partitioning Operators

            #region 1. Get the first 3 orders from customers in Washington

            //var Customers = CustomerList.Where(customer => customer.Address == "Washington").SelectMany(customer => customer.Orders).Take(3);
            //  foreach (var customer in Customers)
            //     Console.WriteLine(customer);


            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington.

            //var Customers = CustomerList.Where(customer => customer.Address == "Washington").SelectMany(customer => customer.Orders).Skip(2);

            //foreach (var customer in Customers)
            //    Console.WriteLine(customer);

            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.TakeWhile((number , index) => number > index);

            //Console.WriteLine(string.Join(" ,", result));


            #endregion

            #region 4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile(number => number % 3 != 0);

            //Console.WriteLine(string.Join(" ,", result));

            #endregion

            #region 5. Get the elements of the array starting from the first element less than its position.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile((number, index) => number >= index);
            //Console.WriteLine(string.Join(" ,", result));

            #endregion


            #endregion

            #region LINQ – Grouping Operators


            #region 1- Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var result  = numbers.GroupBy(x => x % 5);

            //foreach ( var item in result )
            //{
            //    Console.WriteLine($"Numbers with a remainder of {item.Key} when divided by 5:");
            //    foreach( var item2 in item )
            //        Console.WriteLine(item2);
            //}

            #endregion

            #region 2- Uses group by to partition a list of words by their first letter.Use dictionary_english.txt for Input


            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.GroupBy(word => word[0]);

            //foreach (var item in result) {

            //    Console.WriteLine($"Words starting with '{item.Key}':");

            //    foreach (var item2 in item)
            //        Console.WriteLine(item2);
            //    Console.WriteLine("==============================");
            //}

            #endregion


            #region 3- Use Group By with a custom comparer that matches words that are consists of the same Characters Together


            //String[] Arr = { "from", "salt", "earn", " last", "near", "form" };

            //var NewArr = Arr.Select(word => word.Trim().ToLower()).ToArray();

            //var result = NewArr
            //.GroupBy(word => String.Concat(word.OrderBy(c => c)));

            //foreach (var group in result)
            //{

            //    foreach (var word in group)
            //    {
            //        Console.WriteLine(word);
            //    }
            //    Console.WriteLine("-----");
            //}

            #endregion

            #endregion
        }
    }
}
