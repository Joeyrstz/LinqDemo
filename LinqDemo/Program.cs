// See https://aka.ms/new-console-template for more information

using LinqDemo;

List<Person> people = new List<Person>
{
    new Person { FirstName = "John", LastName = "Doe", Age = 30 },
    new Person { FirstName = "Jane", LastName = "Doe", Age = 28 },
    new Person { FirstName = "Jack", LastName = "Smith", Age = 32 },
    new Person { FirstName = "Jill", LastName = "Johnson", Age = 35 }
};

var p1 = people.First(person => person.LastName == "Doe");
var p3 = people.First(Bla);
var p2 = people.Where(person => (person.LastName == "Doe" && person.Age > 15) || person.FirstName == "Jill").ToList();

var tuples = people.Select(p => new {p.FirstName, p.LastName}).ToList();

var maxAge = people.Max(p => p.Age);

var sdf = people.GroupBy(p => p.LastName).ToList();

static bool Bla(Person p)
{
    return true;
}


// Find all people whose age is greater than 30:
var result = people.Where(p => p.Age > 30).ToList();

// Find all people with last name "Doe":
var result2 = people.Where(p => p.LastName == "Doe").ToList();

// Find the oldest person:
var oldest = people.OrderByDescending(p => p.Age).First();

// Average age of all people:
var average = people.Average(p => p.Age);

Console.WriteLine("Hello, World!");