// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



// Projection
// Projection is the operation of selecting only a subset of properties or columns from a larger data set, often transforming the data into a new, typically "flatter," shape or type that only contains the information needed for a specific task. 
// Goal: To retrieve just the necessary fields, reducing data transfer and improving performance.
// In LINQ/Databases: In a database context or with LINQ, a projection is like using a SELECT statement to specify which columns you want, ignoring the rest of the object or table's fields.
// Example (C# LINQ): Starting with a list of Person objects that have FirstName, LastName, and Age, you might project them into a new list of an anonymous type that only contains the full name and a status (e.g., "Minor" or "Adult").

//    projection with select
List<Person> Pepole = new List<Person>
{
    new Person { FirstName = "hossien", LastName = "solymany", Age = 14, Email = "h@gmail.com" },
    new Person { FirstName = "hassan", LastName = "khj", Age = 145, Email = "2aa@gmail.com" },
    new Person { FirstName = "asas", LastName = "sowwy", Age = 55, Email = "aa@gmail.com" },
    new Person { FirstName = "oitrq", LastName = "oooai", Age = 21, Email = "oo@gmail.com" },
    new Person { FirstName = "212jdas2w", LastName = "ppqim", Age = 22, Email = "" },
    new Person { FirstName = "iwopq", LastName = "uurjn", Age = 434, Email = "" },
    new Person { FirstName = "pppaiw", LastName = "qie3uc", Age = 21, Email = "qq@gmail.com" },

};

//select 

// var my_interst = Pepole.Select(p => new
// {
//     Fullname = p.FirstName + " " + p.LastName,
//     ConfirmedEmail = !string.IsNullOrEmpty(p.Email),
// });

// foreach (var item in my_interst)
// {
//     Console.WriteLine($" FullName :{item.Fullname} ||| Email : {item.ConfirmedEmail} ");
// }


//where 

List<Person> a = Pepole.Where(p => p.Age > 30).
OrderBy(P => P.Age).ThenBy(p => p.FirstName).ToList();

//Aggregation 
var count = a.Count;
var avg = a.Average(p => p.Age);
var sum = a.Sum(p => p.Age);
var max = a.Max(p => p.Age);
var min = a.Min(p => p.Age);

//7. Removing duplicates or limiting data

Random.Shared.Next();
int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 8, 9, 9, 10, 11, 12, 13, 14, 15 };

var genrateNumbers = Enumerable.Range(12, 55).ToArray();
var funSequence = Enumerable.Range(1, 10).Select(n => n * n) .ToArray();
// make random number 

var randomArray = Enumerable.Range(0, 200).Select(_ => Random.Shared.Next()).ToArray();

var dis = numbers.Distinct().ToArray();


//Grouping

var group = numbers.GroupBy(n => n % 2 == 0 ? "Even" : "Odd");

System.Console.WriteLine();