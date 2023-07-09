namespace SnakeLadderProblem;
class Program
{
    static void Main(string[] args)
    {
        //Start
        Console.WriteLine("Snake Ladder Problem");

       
        //Creating 2 players of the game
        User[] u = new User[2];
        for (int i = 0; i < 2; i++)
        {
            u[i] = new User();
        }

        Console.WriteLine($"The Current positon of Player1 before game starts is  {u[0].GetPosition()}");
        Console.WriteLine($"The Current positon of Player2 before game starts is {u[1].GetPosition()}");
        int diceRolled = 0;

        // Player1 starts the game //
        while (u[0].GetPosition()<100 && u[1].GetPosition()<100)
        {
            int i = 0;
            while (i<2 && u[i].GetPosition()<100)
            {
                Console.WriteLine($"Move of Player {i}");
                int diceValue = u[i].RollDice();
                diceRolled++;
                Console.WriteLine($"Dice Value is  {diceValue}");
                int chosenOption = u[i].AvailOptions();
                Console.WriteLine($"Chosen Option is {chosenOption}");
                u[i].Move(diceValue, chosenOption);
                if(chosenOption!=1)
                {
                    i++;
                }

                Console.WriteLine($"After diceRoll-> Pos of player0 is {u[0].GetPosition()}");
                Console.WriteLine($"After diceRoll-> Pos of player1 is {u[1].GetPosition()}");
            }
        }

        Console.WriteLine($"GAME COMPLETE-->Pos of Player 0 is {u[0].GetPosition()}");
        Console.WriteLine($"GAME COMPLETE-->Pos of Player 1 is {u[1].GetPosition()}");
        Console.WriteLine($"GAME COMPLETE-->Number of time dice was rolled {diceRolled}");



    }



}

