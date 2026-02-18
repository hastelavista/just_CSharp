using System;
using System.Linq;
using System.Collections.Generic;

/*
    foreach (type var in collection)
    {
    }
*/

/*
    for sorting 
    OrderBy() 
      -->for medium datasets, creates new object, doesnot change original array

    ForLarger DataSets doenot create new objects
    Array.Sort() 
       --> sorts in place, sorts original array, doesnot return anything
    
    List<T>.Sort() 
*/



// array strings

string[] fruits = {"Apple","Mango","Chhery","Banana"};

// var.orderBy() -- sorts alphabetically/Numerically
//var sortedfruits = fruits.OrderBy(f => f);
Array.Sort(fruits);

foreach (var fruit in fruits) // og array fruits is used 
{
    Console.WriteLine(fruit);
}
Console.WriteLine();


/*    *******************************************     */


//array numbers

int[] numbers = {1,3,6,2,5,4};
var sortedNum = numbers.OrderBy (n => n);

foreach(var num in sortedNum){
    Console.Write(num + " ");
}
Console.WriteLine("\n");

/*    *******************************************     */


//string

string word = "ALPHABET";
var sortedLetters = word.Distinct().OrderBy(c => c);
foreach(char letter in sortedLetters){
    Console.Write(letter + " ");
}

Console.WriteLine("\n");


/*    *******************************************     */


//list

List<string> colors = new List<string> { "Red", "Green", "Blue"};
//var sortedList = colors.Sort();
colors.Sort();
foreach (string color in colors){
    Console.WriteLine(color);
}