using System.Runtime.CompilerServices;
using System;
string fullName = "Kevin";
string location = "Rexburg";

Console.WriteLine($"My name is {fullName}. I'm from {location}");

string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
Console.WriteLine(currentDate);

int date = DateTime.Now.DayOfYear;
Console.WriteLine($"The number of days until Christmas is {360 - date}");