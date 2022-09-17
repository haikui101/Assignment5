// This program will capture the user number and it will tell the user if the number is positive or negative, if the number is equal to zero the program will write "Got 0", and if the number is greater than 1000 it will write big number

Console.WriteLine("Please input a number: ");
int number = int.Parse(Console.ReadLine());
if (number > 0 && number < 1000) 
{
    Console.WriteLine("Positive number.");
} else if (number > 1000) 
{
    Console.WriteLine("Big number");
} else if (number < 0)
    Console.WriteLine("Negative number.");
{
