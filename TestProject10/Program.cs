int hero = 10;
int monster = 10;

Random dice= new Random();
 do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monsters damage is {roll}, remaining health is {monster}.");

    if ( monster <= 0 ) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Heros damage is {roll}, Remainig health is {hero}.");
} while ( hero > 0 && monster > 0 );
Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
Console.ReadLine();