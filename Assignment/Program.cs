using System.ComponentModel;
using System.Data.SqlTypes;
using System.Runtime.Intrinsics.X86;
using System.Threading;
using static Assignment.ListGenerator;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment
{
    internal class Program
    {
        public static void PrintSequence<T>(IEnumerable<T> Sequence)
        {
            foreach (var item in Sequence)
            {
                Console.WriteLine(item);
            }
        }
        public static void PrintSequence<T>(T[] Array)
        {
            foreach (var item in Array)
            {
                Console.WriteLine(item);
            }
        }
        public static void PrintIGroup<T, Y>(IEnumerable<IGrouping<T, Y>> Groups)
        {
            foreach (var Group in Groups)
            {
                Console.WriteLine($"\n{Group.Key}:");
                foreach (var Product in Group)
                {
                    Console.WriteLine($".... {Product}");
                }
            }
        }

        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators

            #region 1. Find all products that are out of stock.
            // Fluent Syntax
            //var Result = ProductList.Where(P => P.UnitsInStock == 0);

            // Query Syntax
            //Result = from P in ProductList
            //         where P.UnitsInStock == 0
            //         select P;

            //PrintSequence(Result); 
            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            // Fluent Syntax
            //var Result = ProductList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3);

            // Query Syntax
            //Result = from P in ProductList
            //         where P.UnitsInStock > 0 && P.UnitPrice > 3
            //         select P;

            //PrintSequence(Result); 
            #endregion

            #endregion

            #region LINQ - Element Operators

            #region 1.Get first Product out of Stock
            // Fluent Syntax
            //var Result = ProductList.Where(P => P.UnitsInStock == 0).FirstOrDefault();

            // Query Syntax
            //var Result = (from P in ProductList
            //              where P.UnitsInStock == 0
            //              select P).FirstOrDefault();

            //Console.WriteLine(Result);
            #endregion

            #region 2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            // Fluent Syntax
            //var Result = ProductList.Where(P => P.UnitPrice > 1000).FirstOrDefault();

            // Query Syntax
            //var Result = (from P in ProductList
            //              where P.UnitPrice > 1000
            //              select P).FirstOrDefault();
            //Console.WriteLine(Result);  
            #endregion

            #endregion

            #region LINQ - Aggregate Operators

            #region 1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Odd = Arr.Count(P => P % 2 != 0);
            //Console.WriteLine($"Count Of Odd : {Odd}");
            #endregion

            #region 2. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Total = Arr.Sum();
            //Console.WriteLine(Total); 
            #endregion

            //(Read dictionary_english.txt into Array of String First)
            //string[] Words = File.ReadAllLines("dictionary_english.txt");

            #region 3.Get the total number of characters of all words in dictionary_english.txt
            //int Total = Words.Sum(W => W.Length);
            //Console.WriteLine(Total); 
            #endregion

            #region 4. Get the length of the shortest word in dictionary_english.txt
            //string Short = Words.MinBy(W => W.Length);
            //Console.WriteLine($"The Shortest Word : {Short}, Length : {Short.Length}"); 
            // ------- OR ---------
            //int Short = Words.MinBy(W => W.Length).Length;
            //Console.WriteLine(Short);
            #endregion

            #region 5. Get the total units in stock for each product category.
            // Fluen Syntax
            //var Result = ProductList.GroupBy(P => P.Category)
            //                        .Select(P => new
            //                        {
            //                            Category = P.Key,
            //                            TotalUnits = P.Sum(P => P.UnitsInStock)
            //                        });

            // ------------------ OR ------------------

            //var Result = ProductList.Select(P => P.Category)
            //                        .Distinct()
            //                        .Select(C => new
            //                        {
            //                            Category = C,
            //                            TotalUnits = ProductList.Where(P => P.Category == C)
            //                                                    .Sum(P => P.UnitsInStock)
            //                        });


            // Query Syntax
            //var Result = from P in ProductList
            //             group P by P.Category
            //             into Category
            //             select new
            //             {
            //                 Category = Category.Key,
            //                 TotalUnits = Category.Sum(P => P.UnitsInStock)
            //             };

            //PrintSequence(Result);
            #endregion

            #region 6. Get the cheapest price among each category's products
            // Fluen Syntax
            //var Result = ProductList.GroupBy(P => P.Category)
            //                        .Select(P => new
            //                        {
            //                            Category = P.Key,
            //                            CheapestPrice = P.Min(P => P.UnitPrice)
            //                        });

            // Query Syntax
            //var Result = from P in ProductList
            //             group P by P.Category
            //             into Category
            //             select new { Category = Category.Key, CheapestPrice = Category.Min(P => P.UnitPrice) };

            //PrintSequence(Result);
            #endregion

            #region 7. Get the products with the cheapest price in each category (Use Let)
            //var Result = from P in ProductList
            //             group P by P.Category
            //             into Category
            //             let Cheapest = Category.MinBy(P => P.UnitPrice)
            //             select new
            //             {
            //                 Category = Category.Key,
            //                 CheapestProduct = Category.MinBy(P => P.UnitPrice)
            //             };

            //PrintSequence(Result);
            #endregion

            #region 8. Get the average price of each category's products.
            // Fluen Syntax
            //var Result = ProductList.Select(P => P.Category)
            //                        .Distinct()
            //                        .Select(C => new
            //                        {
            //                            Category = C,
            //                            AveragePrice = ProductList.Where(P => P.Category == C)
            //                                                    .Average(P => P.UnitPrice)
            //                        });


            // Query Syntax
            //var Result = from P in ProductList
            //             group P by P.Category
            //             into Category
            //             select new
            //             {
            //                 Category = Category.Key,
            //                 TotalUnits = Category.Average(P => P.UnitPrice)
            //             };

            //PrintSequence(Result);
            #endregion

            #endregion

            #region LINQ - Ordering Operators

            #region 1. Sort a list of products by name
            // Fluent Syntax
            //var Result = ProductList.OrderBy(P => P.ProductName);

            // Query Syntax
            //var Result = from P in ProductList
            //             orderby P.ProductName
            //             select P;

            //PrintSequence(Result);
            #endregion

            #region 2. Sort a list of products by units in stock from highest to lowest.
            // Fluent Syntax
            //var Result = ProductList.OrderByDescending(P => P.UnitsInStock);

            // Query Syntax
            //var Result = from P in ProductList
            //             orderby P.UnitsInStock descending
            //             select P;

            //PrintSequence(Result);
            #endregion

            #region 3. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            // Fluent Syntax
            //var Result = Arr.OrderBy(S => S.Length).ThenBy(S => S);

            // Query Syntax
            //var Result = from N in Arr
            //             orderby N.Length, N
            //             select N;

            //PrintSequence(Result);
            #endregion

            #region 4. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            // Fluent Syntax
            //var Result = ProductList.OrderBy(P => P.Category).ThenByDescending(P => P.UnitPrice);

            // Query Syntax
            //var Result = from P in ProductList
            //             orderby P.Category, P.UnitPrice descending
            //             select P;

            //PrintSequence(Result);
            #endregion

            #region 5. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            // Fluent Syntax
            //var Result = Arr.OrderBy(W => W.Length).ThenByDescending(W => W.ToLower());

            // Query Syntax
            //var Result = from W in Arr
            //             orderby W.Length, W.ToLower() descending
            //             select W;

            //PrintSequence(Result);
            #endregion

            #region 6. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            // Fluent Syntax
            //var Result = Arr.Where(W => W[1] == 'i').Reverse();

            // Query Syntax
            //var Result = (from W in Arr
            //              where W[1] == 'i'
            //              select W).Reverse();

            //PrintSequence(Result);
            #endregion

            #endregion

            #region LINQ – Transformation Operators

            #region 1. Return a sequence of just the names of a list of products.
            // Fluent Syntax
            //var Result = ProductList.Select(P => P.ProductName);

            // Query Syntax
            //var Result = from Product in ProductList
            //             select Product.ProductName;

            //PrintSequence(Result);
            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            // Fluent Syntax
            //var Result = words.Select(W => new { Word = W, Lower = W.ToLower(), Upper = W.ToUpper() });

            // Query Syntax
            //var Result = from W in words
            //             select new { Word = W, Lower = W.ToLower(), Upper = W.ToUpper() };

            //PrintSequence(Result);
            #endregion

            #region 3. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            // Fluent Syntax
            //Console.WriteLine("Pairs where a < b");
            //var result = numbersA.SelectMany(a => numbersB.Where(b => a < b).Select(b => $"{a} is less then {b}"));

            // Query Syntax
            //var result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { a, b };

            //Console.WriteLine("Pairs where a < b");
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.a} is less then {item.b}");
            //}
            #endregion

            #region 4. Select all orders where the order total is less than 500.00.
            // Fluent Syntax
            //var Result = CustomerList.Where(C => C.Orders.Sum(O => O.Total) < 500).SelectMany(O => O.Orders);

            // Query Syntax
            //var Result = from C in CustomerList
            //             where C.Orders.Sum(O => O.Total) < 500
            //             from O in C.Orders
            //             select O;


            //PrintSequence(Result);
            #endregion

            #endregion

            #region LINQ - Set Operators

            #region 1. Find the unique Category names from Product List
            // Fluent Syntax
            //var Result = ProductList.Select(P => P.Category).Distinct();

            // Query Syntax
            //var Result = (from P in ProductList
            //             select P.Category).Distinct();

            //PrintSequence(Result);
            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names. 
            //var Seq01 = ProductList.Select(P => P.ProductName[0]);
            //var Seq02 = CustomerList.Select(C => C.CustomerName[0]);
            //var Result = Seq01.Union(Seq02).ToList();

            // --------------- OR -----------------

            //var Result = ProductList.Select(P => P.ProductName[0])
            //             .Union(
            //             CustomerList.Select(C => C.CustomerName[0])
            //             );

            //PrintSequence(Result);
            #endregion

            #region 3. Create one sequence that contains the common first letter from both product and customer names.
            //var Seq01 = ProductList.Select(P => P.ProductName[0]);
            //var Seq02 = CustomerList.Select(C => C.CustomerName[0]);
            //var Result = Seq01.Intersect(Seq02).ToList();

            // --------------- OR -----------------

            //var Result = ProductList.Select(P => P.ProductName[0])
            //             .Intersect(
            //              CustomerList.Select(C => C.CustomerName[0] )
            //              );

            //PrintSequence(Result);
            #endregion

            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var Seq01 = ProductList.Select(P => P.ProductName[0]);
            //var Seq02 = CustomerList.Select(C => C.CustomerName[0]);
            //var Result = Seq01.Except(Seq02).ToList();

            // --------------- OR -----------------

            //var Result = ProductList.Select(P => P.ProductName[0])
            //             .Except(
            //              CustomerList.Select(C => C.CustomerName[0] )
            //              );

            //PrintSequence(Result);
            #endregion

            #endregion

            #region LINQ - Partitioning Operators

            #region 1. Get the first 3 orders from customers in Washington
            //var Result = CustomerList.Where(C => C.Region == "WA").SelectMany(C => C.Orders).Take(3);

            //PrintSequence(Result);
            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington.
            //var Result = CustomerList.Where(C => C.Region == "WA").SelectMany(C => C.Orders).SkipLast(2);

            //PrintSequence(Result);
            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.TakeWhile((X, I) => X > I);

            //PrintSequence(Result);
            #endregion

            #region 4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.SkipWhile(I => I % 3 != 0);

            //PrintSequence(Result);
            #endregion

            #endregion

            #region LINQ - Quantifiers

            #region 1. Determine if any of the words in dictionary_english.txt contain the substring 'ei'.
            //string[] Words = File.ReadAllLines("dictionary_english.txt");

            //var Result = Words.Any(W => W.Contains("ei"));

            //Console.WriteLine(Result ? "Yes" : "No!");
            #endregion

            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            // Fluent Syntax
            //var Categories = ProductList.Where(P => P.UnitsInStock == 0).Select(P => P.Category).ToArray();
            //var Result = ProductList.Where(P => Categories.Contains(P.Category)).GroupBy(P => P.Category);

            // Query Syntax
            //var Result = from P in ProductList
            //             group P by P.Category
            //             into Groups
            //             where Groups.Any(G => G.UnitsInStock == 0)
            //             select Groups;

            //PrintIGroup(Result);

            #endregion

            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.
            // Fluent Syntax
            //var Categories = ProductList.Where(P => P.UnitsInStock == 0).Select(P => P.Category).ToArray();
            //var Result = ProductList.Where(P => !Categories.Contains(P.Category)).GroupBy(P => P.Category);

            // Query Syntax
            //var Result = from P in ProductList
            //             group P by P.Category
            //             into Groups
            //             where Groups.All(G => G.UnitsInStock != 0)
            //             select Groups;

            //PrintIGroup(Result);
            #endregion

            #endregion

            #region LINQ – Grouping Operators

            #region 1. Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input
            //string[] Words = File.ReadAllLines("dictionary_english.txt");

            //var Result = Words.OrderBy(W => W).GroupBy(W => W[0]).Select(W => new { W.Key, Count = W.Count() });

            //var Result = from W in Words
            //             orderby W
            //             group W by W[0]
            //             into Groups
            //             select new { Groups.Key, Count = Groups.Count() };

            //PrintSequence(Result);

            #endregion

            #endregion
        }
    }
}
