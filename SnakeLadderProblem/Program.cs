﻿namespace SnakeLadderProblem;
class Program
{
    static void Main(string[] args)
    {
        //Start
        Console.WriteLine("Snake Ladder Problem");

        //UC1
        //u1 starts from position 0
        User u1 = new User();

        //UC2
        int nextMove = u1.RollDice();
        Console.WriteLine($"next move is {nextMove}");
        
    }
}

