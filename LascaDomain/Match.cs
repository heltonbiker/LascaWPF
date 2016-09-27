using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LascaDomain
{
	public class Match
	{
		public TeamColor Turn { get; private set; }



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
				case TeamColor.Black: Turn = TeamColor.White; break;
				case TeamColor.White: Turn = TeamColor.Black; break;
			}
		}

		public static Match NewMatch()
		{
			Match board = new Match();
			board.Turn = TeamColor.White;
			return board;
		}

		private void LoadStartPosition()
		{
			//throw new NotImplementedException();
		}

	}
}
