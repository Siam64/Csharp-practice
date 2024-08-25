string[] fraudId = {"a324", "e342", "b564", "h453", "b653", "m545", "b234", "b111"};

foreach(string id in fraudId)
{
    if(id.StartsWith("b"))
    {
        Console.WriteLine(id);
    }
}





























//fraudId[0] = "A234";
//fraudId[1] = "b345";
//fraudId[2] = "c545";

//Console.WriteLine($"first: {fraudId[0]}");
//Console.WriteLine($"second: {fraudId[1]}");
//Console.WriteLine($"third: {fraudId[2]}");


//fraudId[0] = "e456";
//Console.WriteLine($"First array reasign= {fraudId[0]}");

//Console.WriteLine($"There are {fraudId.Length} fraud id to process");





//string[] names = { "sam", "sham", "jodu", "modu" };

//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}
//int[] inventory = { 145, 254, 334, 456, 657, 789, 982, 126, 548, 712 };
//int sum = 0;
//int bin = 0;
//foreach(int ittems in inventory)
//{
//    sum+=ittems;
//    bin++;
//    Console.WriteLine($"Bin {bin}= {ittems} items (Running total= {sum} items)");
//}
//Console.WriteLine($"we have {sum} items in inventory");




Console.ReadLine();

