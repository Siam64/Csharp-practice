//string? value;
//value= Console.ReadLine();
//Console.WriteLine(value);
//Console.ReadLine();


//string? value;
//do
//{
//    Console.Write("enter your sgring: ");
//    value = Console.ReadLine();
//    Console.WriteLine("string is: "+ value);
//}while (value != null);

//string value;
//bool x = false;
//do
//{
//    Console.Write("Enter a valid string that contains at least 3 characters: ");
//    value = Console.ReadLine();
//    if (value != null)
//    {
//        if (value.Length >= 3)
//        {
//            x = true;
//        }
//        else
//        {
//            Console.Write("invalid input. ");
//        }
//    }
//} while (x == false);
//Console.WriteLine($"Correct! Your string is: {value}");

//string? readResult;
//bool validEntry = false;
//Console.WriteLine("Enter a string containing at least three characters:");
//do
//{
//    readResult = Console.ReadLine();
//    if (readResult != null)
//    {
//        if (readResult.Length >= 3)
//        {
//            validEntry = true;
//        }
//        else
//        {
//            Console.WriteLine("Your input is invalid, please try again.");
//        }
//    }
//} while (validEntry == false);
//Console.WriteLine(readResult);


//string input;
//bool validInput = false;
//int a;

//do
//{
//    Console.Write("Enter a value between 5 to 10: ");
//    input = Console.ReadLine();
//    bool i = int.TryParse(input, out a );
//    if ((a >=5) && (a<=10))
//    {

//        validInput = true;
//    }
//    else
//    {
//        Console.WriteLine("enter valid input");
//    }

//}while(validInput== false);
//Console.WriteLine($"Yoyr input({a}) is accepted");

//string? readResult;
//string roleName = "";
//bool validEntry = false;

//do
//{
//    Console.WriteLine("Enter your role name (Administrator, Manager or user): ");
//    readResult = Console.ReadLine();
//    if (readResult != null)
//    {
//        roleName = readResult.Trim();
//    }
//    if (roleName.ToLower() == "administrator" || roleName.ToLower()== "manager" || roleName.ToLower()== "user")
//    {
//        validEntry = true;
//    }
//    else
//    {
//        Console.WriteLine("wrong");
//    }
//}while (validEntry == false);
//Console.WriteLine("accepted");


string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}



Console.ReadLine();