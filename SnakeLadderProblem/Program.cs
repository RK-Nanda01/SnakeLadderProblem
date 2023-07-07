namespace SnakeLadderProblem;
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

        //UC4
        int i = 0;
        Console.WriteLine($"The Current positon before while is {u1.GetPosition()}");
        while(u1.GetPosition()<100)
        {
            
            int current = u1.GetPosition();
            int diceValue = u1.RollDice();
            int option = u1.AvailOptions();
            if(option == -1)
            {
                current = current - diceValue;
                if(current < 0)
                {
                    current = 0;
                }



            }

            else if(option == 1)
            {
                current = current + diceValue;
               
            }

            u1.SetPosition(current);
            Console.WriteLine($"Dice Value is  {diceValue}");
            Console.WriteLine($"Option chosen {option}");
            Console.WriteLine($"New position after roll is {current}");
            i++;
        }

        
        Console.WriteLine($"Out of while   {i}");

    }
}

