using System;
Random random = new Random();
Console.CursorVisible = false;
int height = Console.WindowHeight - 1;
int width = Console.WindowWidth - 5;
bool shouldExit = false;


// Console position of the player
int playerX = 0;
int playerY = 0;


// Console position of the food
int foodX = 0;
int foodY = 0;


string[] states = { "('-')", "(^-^)", "(x_x)" };
string[] foods = { "@@@@@", "$$$$$", "#####" };
string player = states[0];
int food = 0;
int playerSpeed = 1; // Default player speed


InitializeGame();
while (!shouldExit)
{
    Move();
}


bool TerminalResized()
{
    return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
}


void ShowFood()
{
    
    food = random.Next(0, foods.Length);
    foodX = random.Next(0, width - player.Length);
    foodY = random.Next(0, height - 1);
    Console.SetCursorPosition(foodX, foodY);
    Console.Write(foods[food]);
}

void ChangePlayer()
{
    player = states[food];
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

void FreezePlayer()
{
    System.Threading.Thread.Sleep(3000); // Freeze for 3 seconds (3000 milliseconds)
    player = states[0]; // Reset player representation to the default "(^-^)"
}

bool CheckPositions()
{
    return playerX == foodX && playerY == foodY;
}


void Move()
{
    if (TerminalResized())
    {
        Console.Clear();
        Console.WriteLine("Console was resized. Program exiting.");
        System.Threading.Thread.Sleep(2000);
        return;
    }

    int lastX = playerX;
    int lastY = playerY;
    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

    switch (keyInfo.Key)
    {
        case ConsoleKey.UpArrow:
            playerY -= playerSpeed;
            break;
        case ConsoleKey.DownArrow:
            playerY += playerSpeed;
            break;
        case ConsoleKey.LeftArrow:
            playerX -= playerSpeed;
            break;
        case ConsoleKey.RightArrow:
            playerX += playerSpeed;
            break;
        case ConsoleKey.Escape:
            shouldExit = true;
            break;
    }

    
    Console.SetCursorPosition(lastX, lastY);
    for (int i = 0; i < player.Length; i++)
    {
        Console.Write(" ");
    }

    // Keep player position within the bounds of the Terminal window
    playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
    playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

    // Check if player and food positions match
    if (CheckPositions())
    {
        ChangePlayer(); 

        if (player == "(x_x)") 
        {
            FreezePlayer(); 
        }
        else if (player == "(^-^)") 
        {
            playerSpeed = 3; 
        }

        ShowFood(); 
    }

    // Draw the player at the new location
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Clears the console, displays the food and player
void InitializeGame()
{
    Console.Clear();
    ShowFood();
    Console.SetCursorPosition(0, 0);
    Console.Write(player);
}

Console.ReadKey();