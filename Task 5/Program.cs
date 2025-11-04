//Creates a DateTime variable representing your birthdate.
DateTime myBirthDate = new DateTime(2003, 12, 25);

//Creates another DateTime variable representing the current date and time.
DateTime currentDate = DateTime.Now;

//Calculates your age using TimeSpan (you'll need to subtract the two DateTime values).
TimeSpan myAge = currentDate - myBirthDate;
int ageInYears = (int)(myAge.Days / 365.25);

//Prints your birthdate, the current date, and your age in years.
Console.WriteLine($"My Birthdate: {myBirthDate:MM/dd/yyyy}");
Console.WriteLine($"Current Date: {currentDate:MM/dd/yyyy}");
Console.WriteLine($"My age in years: {ageInYears}");

//Adds 10 days to your birthdate and prints the resulting date.
DateTime birthDatePlus = myBirthDate.AddDays(10);
Console.WriteLine($"My birthdate plus 10 days: {birthDatePlus:MM/dd/yyyy}");

