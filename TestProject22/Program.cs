//using System.Numerics;

//int a = 3;
//int b= 4;
//int c = 0;
//Multiply(a, b, c);
//Console.WriteLine($"golbal statement: {a} X {b}= {c}");




//void Multiply(int a, int b, int c)
//{
//    c = a * b;
//    Console.WriteLine($"inside statement: {a} X {b}= {c}");


//}





//int[] arr = {1, 2, 3, 4, 5};

//printarr(arr);
//clear(arr);
//printarr(arr);

//void printarr(int[] array)
//{
//    foreach(int i in array)
//    {
//        Console.Write($"{i} ");
//    }
//    Console.WriteLine();
//}
//void clear(int[] array)
//{
//    for (int i= 0; i< array.Length; i++)
//    {
//        array[i] = 0;
//    }
//}



//string status = "Healthy";
//Console.WriteLine($"start: {status}");
//setHealth(false);
//Console.WriteLine($"End: {status}");

//void setHealth( bool stat ) {

//    status = (stat ? "Healthy" : "Unhealthy");
//    Console.WriteLine($"Middle: {status}");
//}


string[] guestList = { "tony", "Rebecca", "Nadia", "Noor", "Jonte" };
string[] rsvps = new string[10];
int count = 0;


RSVP("Rebecca", 1, "none", true);
RSVP("Nadia", 2, "Nuts", true);
RSVP("Linh", 2, "none", false);
RSVP("Tony", 1, "Jackfruit", true);
RSVP("Noor", 4, "none", false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();

void RSVP(string name, int partySize, string allergies, bool inviteOnly)
{
    if (inviteOnly)
    {
        bool found = false;
        foreach (string guest in guestList)
        {
            if (guest.Equals(name))
            {
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
            return;
        }
    }

    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}


Console.ReadLine();

