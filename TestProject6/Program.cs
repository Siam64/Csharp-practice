string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome super admin!");
    }

    else
    {
        Console.WriteLine("welcome admin");
    }

}
else if(permission.Contains("Manager"))
{
    if(level >= 20)
    {
        Console.WriteLine("Please contact admin for access");
    }
    else
    {
        Console.WriteLine("You dont have sufficient privilage");
    }
}
else
{
    Console.WriteLine("You dont have sufficient privilage");
}
Console.ReadLine();