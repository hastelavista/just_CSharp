string a = "Hi";
string b = a;
b = "Bye";

Console.WriteLine(a);
Console.WriteLine(b);

int[] arr = new int [3];
int[] arr1 = arr;
arr1[1] = 3;
Console.WriteLine(arr[1]);