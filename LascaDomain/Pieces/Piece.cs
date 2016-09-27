using System;
using System.Collections.Generic;

namespace Lasca.Domain
{
	public abstract class Piece
	{
		public TeamType Team { get; private set; }
		public Position Position { get; private set; }
		public Rank Rank { get; private set; } = Rank.Private;

		internal Piece(TeamType team, Position position)
		{
			Team = team;
			Position = position;
		}

		public IEnumerable<Move> GetAvailableMoves(Board board)
		{
			var result = new List<Move>();

			result.AddRange(GetForwardMoves());

			if (Rank == Rank.Officer)
				result.AddRange(GetBackwardMoves());

			return result;
		}

		protected abstract IEnumerable<Move> GetForwardMoves();

		protected abstract IEnumerable<Move> GetBackwardMoves();
	}
}
