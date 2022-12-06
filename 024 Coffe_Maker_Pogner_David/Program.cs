// Angabe: https://github.com/Teaching-HTL-Leonding/coffee-maker-David-Pogner

Console.OutputEncoding = System.Text.Encoding.Default;

char option = 'N';

do
{
    Console.Clear();

    Console.Write("Please enter the amount of money that you felt into the machine (multiple of 0.50): ");
    double money = double.Parse(Console.ReadLine()!);

    const double CAPPUCCINO = 3.50;
    const double TEA = 1.50;
    const double CACAO = 2.50;

    int choice;
    double fullMoney = money;
    double percentage;

    if (money % 0.5 != 0 || money <= 0)   
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Your input is not valid!");
        Console.ResetColor();
    }
    else
    {
        do
        {
            percentage = money/fullMoney*20;
            for (int i = 0; i < percentage; i++)
            {
                System.Console.Write("#");
            }
            for (int j = 0; j < 20 - percentage; j ++)
            {
                System.Console.Write(".");
            }
            System.Console.WriteLine();
            Console.Write("Which product would you like to buy?");
            Console.Write("1) Cappuccino (3.5€), 2) Tea (1.5€), 3) Cacao (2.5€), 4) Nothing else: ");
            choice = int.Parse(Console.ReadLine()!);

            switch (choice)
            {
                case 1:
                    if (money >= CAPPUCCINO)
                    {
                        money -= CAPPUCCINO;
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough money! 😥");
                    }
                    break;

                case 2:
                    if (money >= TEA)
                    {
                        money -= TEA;
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough money! 😥");
                    }
                    break;

                case 3:
                    if (money >= CACAO)
                    {
                        money -= CACAO;
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough money! 😥");
                    }
                    break;

                case 4:
                    Console.WriteLine($"Your restmoney is {money} €");
                    int Two_Euro_Coins = (int)(money / 2);
                    money -= Two_Euro_Coins * 2;
                    int One_Euro_Coins = (int)money;
                    money -= One_Euro_Coins;
                    int Fifty_Cent_Coins = (int)(money * 2);

                    if (Two_Euro_Coins > 0)
                    {
                        Console.WriteLine($"You get {Two_Euro_Coins}x 2€ pieces");
                    }
                    if (One_Euro_Coins > 0)
                    {
                        Console.WriteLine($"You get {One_Euro_Coins}x 1€ pieces");
                    }
                    if (Fifty_Cent_Coins > 0)
                    {
                        Console.WriteLine($"You get {Fifty_Cent_Coins}x 0,50€ pieces");
                    }

                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your input is not an option!");
                    Console.ResetColor();
                    break;
            }


        }
        while (choice != 4);
    }

    Console.WriteLine();
    Console.WriteLine("Do you want to start again? (Y/N): ");
    option = char.Parse(Console.ReadLine()!.ToUpper());
}
while (option == 'Y');

