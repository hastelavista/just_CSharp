
//value types vs reference types
//  in stack      in heap

// value types: primitive dt [ int double bool char ] ADT: struct
// ref types: class, string, array, delegates, interfaces

using System;

/* ************** value-type *************** */

struct StudentStc { public string Name; }

        // --- Struct example ---
        //Structs → usually on stack → fast, independent, no GC overhead
        
        StudentStc s1;
        s1.Name = "Mr. X";
        StudentStc s2 = s1;
        s2.Name = "Ms. Z";

        /*
        here s1 and s2 are copies of entire stuct, new obj
        so changing ones property doesnot affect other
        i.e., structs store actual values not references, every copy is different
        */

        Console.WriteLine($"My Name is {s1.Name}");
        Console.WriteLine($"And My Name is {s2.Name}");
        Console.WriteLine("We are structures type, so we are different.\n");


/* ************** refernce-type *************** */


class StudentCls { public string Name; }

        // --- Class example ---
        // Classes → on heap → shared, requires GC, multiple references can affect same object
        StudentCls c1 = new StudentCls();
        c1.Name = "Mr. A";

        StudentCls c2 = c1;
        c2.Name = "Mr. B";

        Console.WriteLine($"My Name is {c1.Name}");
        Console.WriteLine($"And My Name is {c2.Name}");
        Console.WriteLine("We are class reference type, so we point to the same object.");
    
        /*
        here c1 and c2 are copies of refrence not the obj
        so they point to same obj on heap
        i.e., classes store refernces, so mul var can point at same obj
        */



/* ************** refernce-type but fkn weird *************** */
//strings -> ref type + immutable => can behave like value typed 
//          i.e, assigning new value now will create a different obj 
string a = "Hi";
string b = a;
b = "Bye";

Console.WriteLine(a);
Console.WriteLine(b);



/* ************** arrs *************** */

int[] arr = new int [3];
int[] arr1 = arr;
arr1[1] = 3;
Console.WriteLine(arr[1]);