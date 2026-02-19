
//if-else

int num = 5;
if (num % 2 == 0)
    Console.WriteLine("EVEN");
else
    Console.WriteLine("ODD");



//if-else if-else

int marks = 65;
if (marks >= 90)
    Console.WriteLine($"Marks: {marks} - Grade A");
else if (marks >= 80)
    Console.WriteLine($"Marks: {marks} - Grade B");
else if (marks >= 70)
    Console.WriteLine($"Marks: {marks} - Grade C");
else if(marks < 40)
    Console.WriteLine($"Marks: {marks} - Failed");
else
    Console.WriteLine($"Marks: {marks} - Passed");

