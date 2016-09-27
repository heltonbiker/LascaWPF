using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lasca.Domain;

namespace LascaDomain
{
	public class Piece
	{
		public TeamColor Team { get; private set; }
		public Position Position { get; private set; }
		public Rank Rank { get; private set; } = Rank.Private;

		public Piece(TeamColor team, Position position)
		{
			Team = team;
			Position = position;
		}

		public IEnumerable<Move> GetAvailableMoves()
		{
			throw new NotImplementedException();
		}
	}
}
