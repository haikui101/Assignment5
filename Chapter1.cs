Console.WriteLine("Hey, Please input the number of \nthe weekly hours you have been training basketball: ");
int weeklyHours = int.Parse(Console.ReadLine());
int hoursneeded = 30 - weeklyHours;

if (weeklyHours < 30)
{
    Console.WriteLine("You cannot participate in the tournament league");
    Console.WriteLine("Your total traning hours are: " + weeklyHours + ", To participate in the tournament league you need to train " + hoursneeded + " more hours");
}
else if (weeklyHours >= 30)
{
    Console.WriteLine("You can participate in the tournament league");
}
