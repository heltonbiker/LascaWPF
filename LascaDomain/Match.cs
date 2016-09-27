using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LascaDomain
{
	public class Match
	{
		public Army Turn { get; private set; }

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
				case Army.Black: Turn = Army.White; break;
				case Army.White: Turn = Army.Black; break;
			}
		}

		public static Match NewMatch()
		{
			Match board = new Match();
			board.Turn = Army.White;
			return board;
		}

		private void LoadStartPosition()
		{
			//throw new NotImplementedException();
		}

	}
}
