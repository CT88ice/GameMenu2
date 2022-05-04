using GameMenu2;

while (true)
{
    StartMenu();
}


void StartMenu()
{
    Console.WriteLine("Pick a game:\n1. Tiktaktoe\n2. Snake\n3. Exit");
    switch (Console.ReadKey(true).Key)
    {
        case ConsoleKey.D1:
            new Tiktaktoe().Start();
            break;
        case ConsoleKey.D2:
            new Snake().Start();
            break;
        case ConsoleKey.D3:
            Environment.Exit(0);
            break;
        default:
            break;
    }
}