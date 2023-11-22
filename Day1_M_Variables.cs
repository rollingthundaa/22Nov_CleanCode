review1.cs
public bool IsShopOpen(string day)
{
  if (!string.IsNullOrEmpty(day))
  {
    day = day.ToLower();
    if (day == "friday" || day == "saturday" || day == "sunday")
      return true;
  }
  return false;
}

review3.cs
public long Fibonacci(int n)
{
    if (n < 50)
    {
        if (n <= 1)
            return n;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
    else
    {
        throw new System.Exception("Not supported");
    }
}

review4.cs
var cities = new[] { "Austin", "New York", "San Francisco" };
for (int i = 0; i < cities.Count(); i++)
{
    var city = cities[i];
    DoStuff();
    DoSomeOtherStuff();

    // ...
    // ...
    // ...
    // Wait, what is `li` for again?
    Dispatch(city);
}

review5.cs
const string ADMIN_ROLE = "admin";
if(userRole==ADMIN_ROLE) {}

review6.cs
public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }

    //...
}

review7.cs
var dateAsString = DateTime.UtcNow.ToString("MMMM dd, yyyy");

review9.cs
public void CreateMicrobrewery(string name = null)
{
    var breweryName = "Hipster Brew Co.";
    // ...
}











