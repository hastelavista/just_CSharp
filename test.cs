
List<int> numbers = new() { 1,2,3,4,5,6,7,8,9,10 };

var evennum = numbers.Where(n => n % 2 == 0).ToList();
var evennumsquared = numbers.Where(n => n % 2 == 0).Select(n => n*n).ToList();

Console.WriteLine(string.Join(", ",evennum));
Console.WriteLine(string.Join(", ",evennumsquared));