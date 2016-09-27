using System.Collections.Generic;

namespace Lasca.Domain
{
	public class Match
	{
		public TeamType Turn { get; private set; }



		public IEnumerable<Move> AvailableMoves
		{
			get
			{
				var result = new List<Move>() { new Move(this) };

				return result;
			}
		}

		internal void ChangeTurn()
		{
			switch (Turn)
			{
				case TeamType.Black: Turn = TeamType.White; break;
				case TeamType.White: Turn = TeamType.Black; break;
			}
		}

		public static Match NewMatch()
		{
			Match board = new Match();
			board.Turn = TeamType.White;
			return board;
		}

		private void LoadStartPosition()
		{
			//throw new NotImplementedException();
		}

	}
}
