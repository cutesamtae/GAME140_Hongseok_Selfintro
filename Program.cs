// See https://aka.ms/new-console-template for more information

const string name = "Hongseok Kim";
const string information = "I already learned Data Structures in C language";
const string book = "Metropolis";
int year = 2007;
DateTime date = DateTime.Now;

//print name
Console.WriteLine($"Hello, My name is {name}.");

//print born year
Console.WriteLine("I was born in " + year + ".");

//print personal information
Console.WriteLine($"An Interesting Fact About Me is {information}.\nMy favorite book is {book}.");

//print date
Console.WriteLine($"Today is {date.Date}.");