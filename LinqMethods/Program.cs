//Concat
using System;

var list1 = new List<int> { 1, 2, 3 };

var list2 = new List<int> { 4, 5, 6 };

var concatenatedList = list1.Concat(list2);

foreach (var item in concatenatedList)
{
    Console.WriteLine(item);
}


//Distinct

var numbersDistinct = new List<int> { 1, 2, 2, 3, 3, 4, 5 };

var distinctNumbers = numbersDistinct.Distinct();

foreach (var number in distinctNumbers)
{
    Console.WriteLine(number);
}

// Skip & Take
var numbersSkipTake = Enumerable.Range(1, 10);

var skippedAndTaken = numbersSkipTake.Skip(3).Take(4);

foreach (var number in skippedAndTaken)
{
    Console.WriteLine(number);
}

// Sum
var numbers = new List<int> { 1, 2, 3, 4, 5 };

var sum = numbers.Sum();

Console.WriteLine(sum);


// Repeat
var repeatedNumbers = Enumerable.Repeat(5, 3);

foreach (var number in repeatedNumbers)
{
    Console.WriteLine(number);
}

// Reverse 
List<int> numbersReverse = new List<int> { 1, 2, 3, 4, 5 };
numbersReverse.Reverse(); // Orijinal koleksiyonun sırasını tersine çevirir

foreach (var number in numbersReverse)
{
    Console.WriteLine(number);
}


//min
var numbersMin = new List<int> { 5, 2, 8, 1, 3 };

var minNumber = numbersMin.Min();

Console.WriteLine(minNumber);

