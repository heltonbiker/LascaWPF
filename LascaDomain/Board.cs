using System.Collections.Generic;

namespace Lasca.Domain
{
	public class Board
	{
		List<Piece> _pieces = new List<Piece>();

		public Piece AddWhite(Position position)
		{
			var p = new WhitePiece(position);
			_pieces.Add(p);
			return p;
		}
	}
}
