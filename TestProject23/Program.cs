string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
    displayEmail(first: corporate[i, 0], last: corporate[i, 1] );
}

for (int i = 0; i < external.GetLength(0); i++)
{
    displayEmail(first: external[i, 0], last: external[i, 1], domain: externalDomain  );
}

void displayEmail(string first, string last, string domain= "contoso.com")
{
    string mail = first.Substring(0, 2) + last;
    mail = mail.ToLower();
    Console.WriteLine($"{mail}@{domain}");

}

Console.ReadKey();  