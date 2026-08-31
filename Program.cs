const string name = "Hongseok Kim";
const string interestingFact = "I already learned Data Structures in C language";
const string book = "Metropolis";
int year = 2007;

//print myname
Console.WriteLine($"Hello, My name is {name}.");

//print born year
Console.WriteLine("I was born in " + year + ".");

//print personal information
Console.WriteLine($"An Interesting Fact About Me is {interestingFact}.\nMy favorite book is \"{book}\".");

//print date
Console.WriteLine($"Today is {DateTime.Now}.");

//print exit_key
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
