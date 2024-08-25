Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if(daysUntilExpiration== 0)
{
    Console.WriteLine("Your subscription expired");
}

else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription ends in a day");
    discountPercentage = 20;
}

else if(daysUntilExpiration <=5)
{
    Console.WriteLine($"your subscription ends in {daysUntilExpiration} days.");
    discountPercentage = 10;
}

else if(daysUntilExpiration <=10)
{
    Console.WriteLine("your subscription ends soon!");
    discountPercentage = 5;
}

if(discountPercentage>0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}

Console.ReadLine();