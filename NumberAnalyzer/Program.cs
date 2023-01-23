// Number Analyzer - Decision Maker
// Jeff Santucci

bool keepgoing = true;

do
{
    Console.WriteLine("Please enter an integer between 1 and 100: ");
    string holder = Console.ReadLine();
    int num = int.Parse(holder);

    Console.WriteLine("You have entered: " + num);

    if (num % 2 != 0 && num < 60)
    {
        Console.WriteLine(num + " Odd and less than 60");
    }
    else if (num % 2 == 0 && (num >= 2 && num <= 24))
    {
        Console.WriteLine("Even less than 25");
    }
    else if (num % 2 == 0 && (num >= 26 && num <= 60))
    {
        Console.WriteLine("Even between 26 and 60 inclusive");
    }
    else if (num % 2 == 0 && num > 60)
    {
        Console.WriteLine(num + " Even and greater than 60");
    }
    else if (num % 2 != 0 && num > 60)
    {
        Console.WriteLine(num + " Odd and greater than 60");
    }

    
    Console.WriteLine("Would you like to continue? Y/N ");
    string decision = Console.ReadLine();
    
    if (decision == "Y") 
    {
      keepgoing = true;

    }
    else
    {
        keepgoing = false;
    }

}
while(keepgoing);