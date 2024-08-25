//Console.WriteLine("Signed integral types:");

//Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
//Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
//Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
//Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

//Console.ReadKey();


//int a = 2;
//string b = "2";
//string result= (a+b); 
//Console.WriteLine(result);

//int myint = 45;
//Console.WriteLine($"myint: {myint}");
//decimal myDecimal = myint;
//Console.WriteLine($"myDecimal: {myDecimal}");

//decimal m = 3.4m;
//Console.WriteLine($"a: {m}");
//int c= (int)m;
//Console.WriteLine($"a: {c}");


string a = "102";
int b= 0;

if (int.TryParse(a, out b))
    Console.WriteLine($"Measurement: {b}");
else
    Console.WriteLine($"Couldnt report the mesurement");

Console.WriteLine($"mesure2: {50 + b}");

Console.ReadLine();