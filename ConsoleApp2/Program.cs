using System.Reflection;


Console.WriteLine("Enter how many times you want to play?");
int times = Convert.ToInt32(Console.ReadLine());
int winner = 0;
int loser = 0;

for (int time = 0; time < times; time++)
{
    Console.WriteLine("Enter 1 for rock, 2 for paper, 3 for scissors");
    int userchoise = Convert.ToInt32(Console.ReadLine());
    int CamputerChoise = new Random().Next(1, 4);


    switch (userchoise)
    {
        case int x when x == 1 && CamputerChoise == 2:
            Console.WriteLine("You chose rock");
            Console.WriteLine("Camputer choise is paper");
            Console.WriteLine("You are loser");
            loser += 1;
            break;
        case int x when x == 1 && CamputerChoise == 3:
            Console.WriteLine("You chose rock");
            Console.WriteLine("Camputer choise is scissors");
            Console.WriteLine("You are winner");
            winner += 1;
            break;
        case int x when x == 2 && CamputerChoise == 1:
            Console.WriteLine("You chose paper");
            Console.WriteLine("Camputer choise is rock");
            Console.WriteLine("You are winner");
            winner += 1;
            break;
        case int x when x == 2 && CamputerChoise == 3:
            Console.WriteLine("You chose paper");
            Console.WriteLine("Camputer choise is scissors");
            Console.WriteLine("You are loser");
            loser += 1;
            break;
        case int x when x == 3 && CamputerChoise == 1:
            Console.WriteLine("You chose scissors");
            Console.WriteLine("Camputer choise is rock");
            Console.WriteLine("You are loser");
            loser += 1;
            break;
        case int x when x == 3 && CamputerChoise == 2:
            Console.WriteLine("You chose scissors");
            Console.WriteLine("Camputer choise is paper");
            Console.WriteLine("You are winner");
            winner += 1;
            break;
        default:

            Console.WriteLine("Draw");
            winner += 0;
            loser += 0;
            break;
    }
}

if (winner > loser)
{
    Console.WriteLine($"You won {winner} times");
    Console.WriteLine($"Camputer won {loser} times");
    Console.WriteLine("You are winner in game");
}
else if (loser == winner)
{
    Console.WriteLine($"You won {winner} times");
    Console.WriteLine($"Camputer won {loser} times");
    Console.WriteLine("game is draw");
}
else
{
    Console.WriteLine($"You won {winner} times");
    Console.WriteLine($"Camputer won {loser} times");
    Console.WriteLine("You are loser in  game");
}