﻿using System;
namespace SnakeLadderProblem
{
	public class User
	{
		private int startPosition;
		private int currentPosition;

		public User()
		{
			startPosition = 0;
			currentPosition = 0;
		}

		public int GetPosition()
		{
			return this.currentPosition;
		}

		public void SetPosition(int x)
		{
			this.currentPosition = x;
		}

		public int RollDice()
		{
			Random rnd = new Random();
			int newPosition = rnd.Next(1, 7);
			return newPosition;
		}

		public int AvailOptions()
		{

            Random rnd = new Random();
            int option = rnd.Next(-1, 2);
			//-1 --> Snake
			//0 ---> Stays at same positon
			//1 ---> Chooses Ladder
			return option;
			

        }

		public void Move(int diceValue, int option)
		{
			int current = this.GetPosition();
            if (option == 1) //chooses ladder
            {
                current += diceValue;
                if (current > 100)
                {
                    current -= diceValue;
                }
            }

            else if (option == -1)
            {
                current -= diceValue;
                if (current < 0)
                {
                    current = 0;
                }
            }

            this.SetPosition(current);
        }

	}
}

