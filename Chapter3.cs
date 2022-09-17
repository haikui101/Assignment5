Console.WriteLine("Please input a number: ");
int a = int.Parse(Console.ReadLine());
if (a > 80)
{
    Console.WriteLine($"{a} is greater than 80");
}
else if (a == 80)
{
    Console.WriteLine("Number is 80");
}
else if (a == 79)
{
    Console.WriteLine($"{a} is special");
} else
{
    Console.WriteLine($"{a} is smaller than 80 but not special");
} 
