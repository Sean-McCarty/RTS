// See https://aka.ms/new-console-template for more information
using EmploymentScreening;

#region AboveBelow

Console.WriteLine(@"List is null");
Dictionary<string, int> comparisons = Utilities.AboveBelow(null, 7);
foreach (KeyValuePair<string, int> comparison in comparisons)
    Console.WriteLine(String.Format("{0} = {1}", comparison.Key, comparison.Value.ToString()));
Console.WriteLine();

Console.WriteLine(@"List is empty");
comparisons = Utilities.AboveBelow(new List<int> {  }, 7);
foreach (KeyValuePair<string, int> comparison in comparisons)
    Console.WriteLine(String.Format("{0} = {1}", comparison.Key, comparison.Value.ToString()));
Console.WriteLine();

Console.WriteLine(@"All elements equal reference");
comparisons = Utilities.AboveBelow(new List<int> { 7, 7, 7 }, 7);
foreach (KeyValuePair<string, int> comparison in comparisons)
    Console.WriteLine(String.Format("{0} = {1}", comparison.Key, comparison.Value.ToString()));
Console.WriteLine();

Console.WriteLine(@"Valid list");
comparisons = Utilities.AboveBelow(new List<int> {3, 2, 6, 4, 10, 8, 15, 5, 7}, 7);
foreach(KeyValuePair<string, int> comparison in comparisons)
    Console.WriteLine(String.Format("{0} = {1}", comparison.Key, comparison.Value.ToString()));
Console.WriteLine();
Console.WriteLine();

#endregion

#region StringRotation

string str1 = @"MyString";
string str2 = @"The day is getting long.";

Console.WriteLine(str1);
Console.WriteLine(Utilities.StringRotation(str1, 2));
Console.WriteLine();

Console.WriteLine(str2);
Console.WriteLine(Utilities.StringRotation(str2, 6));
Console.WriteLine();

#endregion