string program = "the quick brown fox jumps over the lazy dog";

string[] message= program.Split(' ');

string[] newMessage = new string[message.Length];

for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i]= new string(letters);
}

string result= string.Join(" ", newMessage);
Console.WriteLine(result);
Console.ReadLine();