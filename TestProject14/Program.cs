//string[] pallets = { "B14", "A11", "B12", "A13" };
//Console.WriteLine("Sorted: ");
//Array.Sort(pallets);
//foreach (var pallet in pallets)
//{
//    Console.WriteLine($"--{pallet}");
//}

//Console.WriteLine("");
//Console.WriteLine("Reversed: ");
//Array.Reverse(pallets);
//foreach (var pallet in pallets)
//{
//    Console.WriteLine($"--{pallet}");
//}


string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing pallets 2, Count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"resizing 6, count: {pallets.Length}");

pallets[4] = "co2";
pallets[5] = "co3";

foreach (var pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}


Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"resizing 3, count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}


Console.ReadLine();