using Lasca.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LascaDomain
{
	public class Board
	{
		List<Piece> _pieces = new List<Piece>();

		public Piece Add(TeamColor teamColor, Position position)
		{
			var p = new Piece(teamColor, position);
			_pieces.Add(p);
			return p;
		}
	}
}
