// See https://aka.ms/new-console-template for more information
using EmploymentScreening;

#region AboveBelow

Console.WriteLine(@"List is null");
Console.WriteLine(Utilities.AboveBelow(null, 7));
Console.WriteLine();

Console.WriteLine(@"List is empty");
Console.WriteLine(Utilities.AboveBelow(new List<int> { }, 7));
Console.WriteLine();

Console.WriteLine(@"All elements equal reference");
Console.WriteLine(Utilities.AboveBelow(new List<int> { 7, 7, 7 }, 7));
Console.WriteLine();

Console.WriteLine(@"Valid list");
Console.WriteLine(Utilities.AboveBelow(new List<int> { 3, 2, 6, 4, 10, 8, 15, 5, 7 }, 7));
Console.WriteLine();
Console.WriteLine();

#endregion

#region StringRotation

string str1 = @"MyString";
string str2 = @"The day is getting long.";

Console.WriteLine($@"{str1}, offset = 2");
Console.WriteLine(Utilities.StringRotation(str1, 2));
Console.WriteLine();

Console.WriteLine($@"{str2}, offset = 6");
Console.WriteLine(Utilities.StringRotation(str2, 6));
Console.WriteLine();

#endregion