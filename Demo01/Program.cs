namespace Demo
{
    internal class Program
    {
        #region Implicitly-Type Local Variables [var - dynamic]
        //public static var Print(var X)
        //{
        //    return X;
        //}

        public static dynamic Print(dynamic X)
        {
            return X;
        }
        #endregion
        static void Main()
        {
            #region Session01
            #region Implicitly-Type Local Variables [var - dynamic]
            // Implicitly-Type Local Variables [var - dynamic]

            // var

            //var Data01 = "Ahmed";

            // Compiler Can Detect The Datatype Of The Local Variable Based On Initial Value, At Compilation Time
            // Must Be Initiliazed
            // Can't Initialized The Local Varaible With Null
            // Can't Change Datatype of The Local Variable After Initialization
            // Can't Use Var as Parameter Or Return Type

            //Data01 = 12; // Invalid


            // dynamic: Like var in JS

            //dynamic Data02 = "Ahmed";

            // CLR Detect The Datatpye Of The Local Variable Based On Last Value, At Runtime
            // Don't Need To Be Initialized
            // Can Initilaized The Local Varaible With Null
            // Can Change Datatype Of The Local Variable After Initialization
            // Can Use dynamic Keyword as Parameter Or Return Type
            // Be Carefull When Use Dynamic
            // Like var in JS or Object in C#

            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = 12;
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = 1.4;
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = 1.4f;
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = 1.4m;
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = true;
            //Console.WriteLine(Data02.GetType().Name);

            //var X = 12;

            //var X = () => Console.WriteLine('Hello, World');
            //var X = delegate () { Console.WriteLine("Hello, World"); }; 
            #endregion

            #region Anonymous Type
            // Anonymous Type

            //Employee E01 = new Employee() {Id =1, Name ="Ahmed", Salary =12000 };

            //var E01 = new { Id = 1, Name = "Ahmed", Salary = 12000.0m };
            //var E02 = new { Id = 2, Name = "Ali", Salary = 15000.0m };

            //var E02 = E01 with { Id = 2 }; // NEW Feature C# 10.0

            //Console.WriteLine(E01.Id);
            //Console.WriteLine(E01.Name);
            //Console.WriteLine(E01.Salary);

            //E01.Id = 12; // Invalid : Immutable Can't Change Its Value After Creation

            //Console.WriteLine(E01.GetType().Name); // <>f __ AnonymousType0'3
            //Console.WriteLine(E02.GetType().Name); // <>f __ AnonymousType0'3
            // The Same Anonymous Type As long as:
            // 1. The Same Property Name [Case Sensitive]
            // 2. The Same Property Order

            //Console.WriteLine(E01); // { Id =1, Name =Ahmed, Salary = 12000.0 }
            // Compiler Will Override On ToString

            //Console.WriteLine(E01.GetHashCode());
            //Console.WriteLine(E02.GetHashCode());

            //if (E01.Equals(E02)) // Compiler Will Override On Equals
            //    Console.WriteLine(value: "E01 == E02");
            //else
            //    Console.WriteLine(value: "E01 != E02"); 
            #endregion

            #region Extension Methods
            // Extension Methods

            //int Number = 12345;
            //long Number = 12345;

            //var result = IntExtension. Reverse(Number); // Class Memeber Method

            //var result = Number.Reverse(); // Extension Method

            //Console.WriteLine(result); // 54321 
            #endregion

            #region What is LINQ
            // LINQ : Language Integrated Query
            //      : 40 + Extension Methods(LINQ Operators) Against Any Data[Data in Sequence]
            //      : Regardless Data Store
            //      : 13 Category
            //      : LINQ Operators Exists in Built -in Class "Enumerable"

            // Sequence : Object From Class Implement Interface "IEnumerable"
            // Local Sequence  : L20, L2XML
            // Remote Sequence : L2EF

            // Input Sequence -> LINQ Operator -> Output Sequence
            // Input Sequence -> LINQ Operator -> One Value
            //                -> LINQ Operator -> Output Sequence

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = Enumerable.Where(Numbers, N => N % 2 == 0);
            //var result = Enumerable.Any(Numbers, N => N % 2 == 0);
            //var result = Enumerable.Range(start: 1, count: 100);

            //Console.WriteLine(result);

            //foreach (var item in result)
            //{
            //    Console.Write(value: $"{item} ");
            //} 
            #endregion

            #region LINQ Syntax
            // LINQ Syntax

            // 1. Fluent Syntax
            // Use LINQ Methods

            // 1.1. LINQ Operator as => Class Memeber Method Through Class "Enumerable"

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 8, 9, 10 };

            //var result = Enumerable.Where(Numbers, X => X % 2 == 0);

            //foreach (var item in result)
            //{
            //    Console.Write($"{item} ");
            //}

            // 1.2. LINQ Operator as => Extension Method Through Sequence

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 8, 9, 10 };

            //var result = Numbers.Where(X => X % 2 == 0);

            //foreach (var item in result)
            //{
            //    Console.Write(value: $"{item} ");
            //}



            // 2. Query Syntax [Query Expression] Like SQL Style 
            // start from
            // end select, group by
            // Query Syntax easier than Fluent (Join, Group By, Let, Into)

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 8, 9, 10 };

            //var result = from N in Numbers
            //             where N % 2 == 0
            //             select N;


            //foreach (var item in result)
            //{
            //    Console.Write(value: $"{item} ");
            //}


            /*
                Select N
                From Numbers
                Where N % 2 = 0
            */
            #endregion

            #region LINQ Execution Ways
            // LINQ Execution Ways
            // 1.Differed Execution Way : 10 Category
            // 2.Immediate Execution Way : 3 Category[Elements Operator, Casting Operators, Aggregate Operators]

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 8, 9, 10 };

            //var result = Numbers.Where(X => X % 2 == 0); // Differed

            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });

            //foreach (var item in result) // here
            //{
            //    Console.Write(value: $"{item} ");
            //}


            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 8, 9, 10 };

            //var result = Numbers.Where(X => X % 2 == 0).ToList(); // Immediate

            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });

            //foreach (var item in result)
            //{
            //    Console.Write(value: $"{item} ");
            //} 
            #endregion

            #region Setup Data
            // Setup Data

            //Console.WriteLine(ProductList[0]);
            //Console.WriteLine(CustomerList[0]);

            //var result = ProductList.Where(P => P.UnitsInStock == 0);
            //var result = CustomerList.Where(C => C.City == "Berlin");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            #endregion

            #region Session02
            // LINQ: 40+ Extension Methods
            // LINQ: 13 Category

            #region 1. Filteration Operators - Where / OfType
            // 1. Filteration Operators - Where / OfType

            // 1.1. Where

            // All Product Out Stock:

            // Fluent Syntax:
            //var result = ProductList.Where(P => P.UnitsInStock == 0);


            // Query Syntax [Query Expression]:
            //var result = from P in ProductList
            //             where P.UnitsInStock == 0
            //             select P;

            //var result = ProductList.Where(P => P.Category == "Meat/Poultry");


            //var result = from P in ProductList
            //             where P.Category == "Meat/Poultry"
            //             select P;

            //var result = ProductList.Where(P => P.UnitsInStock > 0).Where(P => P.Category == "Meat/Poultry")
            //var result = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Meat/Poultry");


            //var result = from P in ProductList
            //             where P.UnitsInStock > 0 && P.Category == "Meat/Poultry"
            //             select P;



            // Indexed Where Valid Only in Fluent Syntax
            // Can't Be Written Using Query Syntax [Query Expression]
            //var result = ProductList.Where((P, Index) => Index < 10 && P.UnitsInStock == 0);
            //var result = ProductList.Where((P, Index) => Index < 5 );
            //var result = ProductList.Where((P, Index) => Index < 5 && P.UnitsInStock > 0);
            //var result = ProductList.Where(P => P.UnitsInStock > 0).Where((P,I) => I < 5);



            // 1.2. OfType:

            //ArrayList arrayList = new ArrayList() { 1, 2, 3, "Ahmed", "Ali", 1.3, 1.5, 1.7f, 1.8f, 213m, 4.5m, ProductList[0], ProductList[1] };
            //var result = arrayList.OfType<int>();
            //var result = arrayList.OfType<Product>();
            //var result = arrayList.OfType<float>();


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 2. Transformation Operators - Select / SelectMany
            // 2. Transformation Operators - Select / SelectMany

            // Fluent Syntax
            //var result = ProductList. Select(P => P);
            //var result = ProductList. Select(P => P.ProductName);


            //var result = from P in ProductList
            //             select P.ProductName;

            //var result = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Seafood")
            //.Select(P => new
            //{
            //    P.ProductName,
            //    P.Category,
            //    OldPrice = P.UnitPrice,
            //    NewPrice = P.UnitPrice - (P.UnitPrice * 0.1m)
            //});

            //var result = from P in ProductList
            //             where P.UnitsInStock > 0 && P.Category == "Seafood"
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.Category,
            //                 OldPrice = P.UnitPrice,
            //                 NewPrice = P.UnitPrice - P.UnitPrice * 0.1m
            //             };

            //var result = CustomerList. Select(C => C.CustomerName);
            //var result = CustomerList. Select(C => C.Orders); // Namespace
            //var result = CustomerList.SelectMany(C => C.Orders);// If One Of The Property is Sequne

            //var result = from C in CustomerList
            //             from O in C.Orders
            //             select O;


            // Indexed Select Valid Only in Fluent Syntax
            // Can't Be Written Using Query Syntax [Query Expression]
            //var result = ProductList.Select((P, I) => new { I, P.ProductName }).Where(P => P.I < 5);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 3. Ordering Operators - OrderBy / OrderByDescending / ThenBy / ThenByDescending
            // 3. Ordering Operators - OrderBy / OrderByDescending / ThenBy / ThenByDescending

            // Sorting

            //var result = ProductList.OrderBy(P => P.UnitPrice);
            //var result = ProductList.OrderBy(P => P.UnitPrice). Select(P => new {P.ProductName, P.Un:
            //var result = ProductList.OrderBy(P => P.UnitsInStock)
            //                        .Select(P => new
            //                        {
            //                            P.ProductName,
            //                            P.UnitPrice,
            //                            P.UnitsInStock
            //                        });

            //var result = ProductList.OrderByDescending(P => P.UnitsInStock)
            //                        .Select(P => new
            //                        {
            //                            P.ProductName,
            //                            P.UnitPrice,
            //                            P.UnitsInStock
            //                        });

            //var result = ProductList.OrderByDescending(P => P.UnitPrice)
            //                        .Select(P => new
            //                        {
            //                            P.ProductName,
            //                            P.UnitPrice,
            //                            P.UnitsInStock
            //                        });

            //var result = ProductList.OrderByDescending(P => P.UnitsInStock)
            //                        .ThenBy(P => P.UnitPrice)
            //                        .Select(P => new
            //                        {
            //                            P.ProductName,
            //                            P.UnitPrice,
            //                            P.UnitsInStock
            //                        });

            //var result = ProductList.Where(P => P.Category == "Seafood" && P.UnitsInStock > 0)
            //                        .OrderBy(P => P.UnitsInStock)
            //                        .ThenByDescending(P => P.UnitPrice)
            //                        .Select(P => new
            //                        {
            //                            P.ProductName,
            //                            P.UnitPrice,
            //                            P.UnitsInStock
            //                        });

            //var result = from P in ProductList
            //             where P.Category == "Meat/Poultry" && P.UnitsInStock > 0
            //             orderby P.UnitPrice, P.UnitsInStock descending
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.UnitPrice,
            //                 P.UnitsInStock
            //             };

            //var result = ProductList.Reverse<Product>();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 4. Elements Operators - Immediate Execution
            // 4. Elements Operators - Immediate Execution
            /*
             First - FirstOrDefault - Last - LastOrDefault - 
             ElementAt - ElementAtOrDefault - Single - SingleOrDefault - 
             DefaultIfEmpty
            */

            //ProductList = new List<Product>();

            //var result = ProductList.First(); // May Throw Exception [Sequence contains no elements]
            //var result = ProductList.Last(); // May Throw Exception [Sequence contains no elements]


            //var result = ProductList.First(P => P.UnitsInStock == 1000); // May Throw Exception [Sequence contains no matching elements]
            //var result = ProductList.Last(P => P.UnitsInStock == 0); // May Throw Exception [Sequence contains no elements]

            //var result = ProductList.FirstOrDefault();
            //var result = ProductList.FirstOrDefault(new Product() { ProductName = "Default Product" });
            //var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 1000);
            //var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 1000, new Product() { ProductName = "Default Product" });

            //var result = ProductList.LastOrDefault();
            //var result = ProductList.LastOrDefault(new Product() { ProductName = "Default Product" });
            //var result = ProductList.LastOrDefault(P => P.UnitsInStock == 1000);
            //var result = ProductList.LastOrDefault(P => P.UnitsInStock == 1000, new Product() { ProductName = "Default Product" });

            //var result = ProductList.ElementAt(1); // May Throw Exception [Index was out of range]
            //var result = ProductList.ElementAtOrDefault(1);

            //ProductList = new List<Product>() { new Product() { ProductName = "Only One Product" } };

            //var result = ProductList.Single(); // May Throw Exception
            // Exception: Sequence contains more than one element
            // Exception: Sequence contains no elements


            //var result = ProductList.Single(P => P.UnitsInStock == 0); // May Throw Exception
            // Exception: Sequence contains more than one matching element
            // Exception: Sequence contains no matching elements


            //var result = ProductList.SingleOrDefault(); // May Throw Exception
            // Exception: Sequence contains more than one element
            // Return Default Value [null] If The Sequence is Empty


            //var result = ProductList.SingleOrDefault(new Product() { ProductName = "Default Product" }); // May Throw Exception
            // Exception: Sequence contains more than one element
            // Return Default Value "new Product()" If The Sequence is Empty


            //var result = ProductList.SingleOrDefault(P => P.UnitsInStock == 1000); // May Throw Exception
            //var result = ProductList.SingleOrDefault(P => P.ProductID == 1); // May Throw Exception
            // Exception: Sequence contains more than one element
            // Return Default Value [null] If The Sequence is Empty

            //var result = ProductList.SingleOrDefault(P => P.UnitsInStock == 0, new Product() { ProductName = "Default Product" }); // May Throw Exception
            //var result = ProductList.SingleOrDefault(P => P.ProductID == 1, new Product() { ProductName = "Default Product" }); // May Throw Exception
            //var result = ProductList.SingleOrDefault(P => P.ProductID == 1000, new Product() { ProductName = "Default Product" }); // May Throw Exception
            // Exception: Sequence contains more than one element
            // Return Default Value [null] If The Sequence is Empty


            //var result = ProductList.DefaultIfEmpty(new Product() { ProductName = "Default" });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine(result?.ProductName ?? "NA"); 
            #endregion

            #region 5. Aggregate Operators - Immediate Exectuion
            // 5. Aggregate Operators - Immediate Exectuion

            // Count - Sum - Max - Min - Avg

            //var result = ProductList.Count(); // 77
            //var result = ProductList.Count; // 77

            //var result = ProductList.Count(P => P.UnitsInStock == 0); // 5
            //var result = ProductList.Where(P => P.UnitsInStock == 0).Count(); // 5

            //Sum:

            //var result = ProductList.Sum(P => P.UnitPrice); // 2222.7100
            //var result = ProductList.Sum(P => P.UnitsInStock); // 3180

            // Avg:
            //var result = ProductList.Average(P => P.UnitPrice); // 28.866363636363636363636363636

            // Max:

            //var result = ProductList.Max();// $263.50, Based On ICompareable (Price)
            //var result = ProductList.Max(new ProductComparerUnitInStock()); // $125, Based On IComparer (UnitinStock)
            //var result = ProductList.Max(P => P.UnitPrice); // 263.5000
            //var result = ProductList.Max(P => P.UnitsInStock); // 125

            //var MaxPrice = ProductList.Max(P => P.UnitPrice); // 263.5000
            //var result = ProductList.FirstOrDefault(P => P.UnitPrice == MaxPrice);

            //var result = ProductList.MaxBy(P => P.UnitPrice); // Product


            // Min:

            //var result = ProductList.Min();
            //var result = ProductList.Min(new ProductComparerUnitInStockC));
            //var result = ProductList.Min(new ProductComparerNameLength());
            //var result = ProductList.Max(new ProductComparerNameLength());

            //var result = ProductList.Min(P => P.UnitPrice); // 2.5000

            //var result= ProductList.MinBy(P => P.ProductName, new ProductComparerNameLength01());
            //var result= ProductList.MaxBy(P => P.ProductName,new ProductComparerNameLength01());

            // Aggregate

            //List<string> Names = new List<string>() { "Ahmed", "Ali", "Omar", "Osama" };

            //var result = Names.Aggregate((S01, S02) => $"{S01} {S02}");

            //Console.WriteLine(result); 
            #endregion

            #region 6. Casting Operators - Immediate Exectuion
            // 6. Casting Operators - Immediate Exectuion

            //List<Product> list = (List<Product>) ProductList.Where(P => P.UnitsInStock == 0); // Invalid
            //List<Product> list = ProductList.Where(P => P.UnitsInStock == 0).ToList();
            //Product[] list = ProductList.Where(P => P.UnitsInStock == 0).ToArray();
            //Dictionary<long, Product> list = ProductList.Where(P => P.UnitsInStock == 0).ToDictionary(P => P.ProductID);
            //HashSet<Product> list = ProductList.Where(P => P.UnitsInStock == 0).ToHashSet();

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 7. Generation Operators
            // 7. Generation Operators
            // The Only Way To Call This Method as -> Class Memeber Method Throught "Enumerable" Class

            // Range, Empty, Repeat

            //var result = Enumerable.Range(1, 100);


            //var result = Enumerable.Empty<Product>().ToList();

            //result.Add(item: new Product() { ProductName = "Product01" });
            //result.Add(item: new Product() { ProductName = "Product02" });

            //var result = Enumerable.Repeat(ProductList[0], 3);
            //var result = Enumerable.Repeat(element: 1, count: 30);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 8. Set Operators - Union Family
            // 8. Set Operators - Union Family
            // Union - Union All - Intersect, Except

            //var Seq01 = Enumerable.Range(1, 100); // 1 ... 100
            //var Seq02 = Enumerable.Range(start: 50, count: 100); // 50 ... 149

            //var result = Seq01.Union(Seq02); // Like Union in SQL Without Duplication
            //var result = Seq01.Concat(Seq02); // Like Union All in SQL With Duplication

            //result = result.Distinct(); // Remove Duplication

            //var result = Seq01.Intersect(Seq02); // 50 --- 100
            //var result= Seq01.Except(Seq02); // 1 .. 49
            //var result = Seq02.Except(Seq01); // 101 .. 149

            //foreach (var item in result)
            //{
            //    Console.Write($"{item} ");
            //}  
            #endregion

            #region 9. Quantifiers Operators - Return Boolean
            // 9. Quantifiers Operators - Return Boolean

            // Any - All - SequenceEqual - Contains

            //var Seq01 = Enumerable.Range(start: 1, count: 100);
            //var Seq02 = Enumerable.Range(start: 50, count: 100);

            // Any() -- > Return True if There are at least One Element [in Sequence Or Match The Condidtion]

            //var result = Seq01.Any(N => N % 2 == 0);

            //ProductList = new List<Product>();

            //var result = ProductList.Any();
            //var result = ProductList.Any(P => P.UnitsInStock == 0);

            // ALL() -- > Return True if All Element in The Sequence Match The Conditions Or Sequence is Empty

            //var result = ProductList.All(P => P.UnitsInStock == 0);
            //var result = ProductList.All(P => P.UnitPrice > 0);


            // SequenceEqual()

            //var result = Seq01.SequenceEqual(Seq02);

            //var result = Seq02.Contains(1);

            //ProductList.Contains()

            //Console.WriteLine(result); 
            #endregion

            #region 10. Zipping Operators
            // 10. Zipping Operators
            // Zip

            //List<string> Words = new List<string>() { "Ten", "Twenty", "Thirty", "Fourty" };

            //List<int> Numbers = new List<int>() { 10, 20, 30, 40, 50, 60 };

            ////var result = Words.Zip(Numbers, (W, N) => $"{N} --> {W}");
            //var result = Words.Zip(Numbers, (W, N) => new { Number = N, Word = W });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 11. Grouping Operators
            // 11. Grouping Operators

            //var Result = ProductList.GroupBy(P => P.Category);

            //Result = from P in ProductList
            //         group P by P.Category;

            //foreach (var Categeory in Result)
            //{
            //    Console.WriteLine(Categeory.Key);
            //    foreach (var Product in Categeory)
            //    {
            //        Console.WriteLine($".... {Product}");
            //    }
            //}


            //var Result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into Category
            //             where Category.Count() > 5
            //             select Category;


            //foreach (var Categeory in Result)
            //{
            //    Console.WriteLine(Categeory.Key);
            //    foreach (var Product in Categeory)
            //    {
            //        Console.WriteLine($".... {Product}");
            //    }
            //}


            //var Result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into Category
            //             where Category.Count() > 5
            //             select new
            //             {
            //                 Category = Category.Key,
            //                 CountOfProducts = Category.Count()
            //             };

            //var Result = ProductList.Where(P => P.UnitsInStock > 0)
            //                        .GroupBy(P => P.Category)
            //                        .OrderByDescending(C => C.Count())
            //                        .Where(C => C.Count() > 5)
            //                        .Select(C => new { Category = C.Key, Count = C.Count() });


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 12. Partioning Operators - Take, TakeLast, Skip, SkipLast, TakeWhile, SkipWhile
            // 12. Partioning Operators - Take, TakeLast, Skip, SkipLast, TakeWhile, SkipWhile

            //var Result= ProductsList.Where(P => P.UnitsInStock == 0).Take(3);
            //var Result= ProductsList. TakeLast(5);

            //var Result = ProductsList.Skip(5);
            //var Result = ProductsList.SkipLast(5);

            //int[] Numbers = { 9, 6, 4, 1, 2, 3, 4, 5 };
            //var Result = Numbers.TakeWhile((N) => N % 3 == 0);
            //var Result = Numbers.SkipWhile((N) => N % 3 == 0);

            //int[] Numbers = { 5, 4, 1, 3, 9, 6, 7, 2, 0 };
            //var Result = Numbers.TakeWhile((N, I) => N > I);
            //var Result = Numbers.SkipWhile((N, I) => N > I);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region let - into
            // let - into
            // Query Syntax

            // aeiouAEIOU
            //List<string> Names = new List<string>() { "Ahmed", "Ali", "Mohamed", "Mona", "Aya", "Mariam", "Tuqqaa", "Sally", "Mahmoud", "Osama" };

            //var Result = from Name in Names
            //             select Regex.Replace(Name, "[aeiouAEIOU]", string.Empty)
            //             into NonVolNames
            //             // into : Restart Query With Introducing NEW Range Variable (NonVolNames)
            //             where NonVolNames.Length > 3
            //             select NonVolNames;


            //var Result = from Name in Names
            //             let NonVolNames = Regex.Replace(Name, "[aeiouAEIOU]", string.Empty)
            //             where NonVolNames.Length > 3
            //             select NonVolNames;

            //foreach (var Item in Result)
            //{
            //    Console.WriteLine(Item);
            //}

            //var Result = Regex.Replace("Ahmed", "[aeiouAEIOU]", "");
            //Console.WriteLine(Result); 
            #endregion 
            #endregion
        }



    }
}

