review1.cs
public bool IsShopOpen(string day)
{
    if (string.IsNullOrEmpty(day))
    {
        return false;
    }
 
    switch (day.ToLower())
    {
        case "friday":
        case "saturday":
        case "sunday":
            return true;
        default:
            return false;
    }
}

review3.cs
public long Fibonacci(int n)
{
    if (n < 50)
    {
        throw new System.Exception("Not supported");
    }
    else if (n == 0 || n==1)
    {
        return 0;

    }
        
    else
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
        
    }
}

review4.cs
var city = new[] { "Austin", "New York", "San Francisco" };

for (var i = 0; i < l.Count(); i++)
{
    var listOfCities = city[i];
    DoStuff();
    DoSomeOtherStuff();

    // ...
    // ...
    // ...
    // Wait, what is `li` for again?
    Dispatch(listOfCities);
}

review5.cs
const string ADMIN_ROLE="Admin"
if(userRole==ADMIN_ROLE)
{
 
}


review6.cs
public class Car
{
    public string carMake { get; set; }
    public string carModel { get; set; }
    public string carColor { get; set; }

    //...
}

review7.cs
var dateAndTime = DateTime.UtcNow.ToString("MMMM dd, yyyy");

review9.cs
public void CreateMicrobrewery(string name = "Hipster Brew Co.")

