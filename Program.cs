using System;

Console.WriteLine("Please enter the amount you would like to convert to quarters, dimes, nickels, and pennies.");
var input = Console.ReadLine();
decimal quarter = 0.25M;
decimal dime = 0.10M;
decimal nickel = 0.05M;
decimal penny = 0.01M;
string returnString = input + " can be broken down into: ";
if(!decimal.TryParse(input, out decimal convertedString))
{
    Console.WriteLine("You didn't enter a valid decimal.");
}
else
{
    returnString += decimal.ToInt32((convertedString / quarter)) + " quarters, ";//Divide the input by a quarter
    decimal remainder = convertedString % quarter;
    if ((remainder / dime) < 1)
    {
        returnString += "0 dimes, ";
    }
    else
    {
        returnString += decimal.ToInt32(remainder / dime) + " dimes, ";
        remainder = remainder % dime;
        Console.WriteLine(remainder);
    }
    if((remainder / nickel) < 1)
    {
        returnString += "0 nickels, ";
    }
    else
    {
        returnString += decimal.ToInt32(remainder / nickel) + " nickels, ";
        remainder = remainder % nickel;
    }
    if((remainder / penny) < 1)
    {
        returnString += "0 pennies.";
    }
    else
    {
        returnString += decimal.ToInt32(remainder / penny) + " pennies.";
    }
}

Console.WriteLine(returnString);