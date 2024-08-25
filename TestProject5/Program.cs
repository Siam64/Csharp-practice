//string value1 = " a";
//string value2 = "A ";
//Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
//


//int num = 97;
//string result = (num >= 97 ? "A+" : "A");
//Console.WriteLine(result);

Random coin = new Random();
Console.WriteLine($"Result: {(coin.Next(0, 2) == 0 ? "head" : "tail")}");



Console.ReadLine();