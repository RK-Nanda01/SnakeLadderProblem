using System;
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

		public int RollDice()
		{
			Random rnd = new Random();
			int newPosition = rnd.Next(1, 7);
			return newPosition;
		}
	}
}

