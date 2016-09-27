using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lasca.Domain
{
	class BlackPiece : Piece
	{
		internal BlackPiece(Position position)
			: base (TeamType.Black, position) { }



		protected override IEnumerable<Move> GetBackwardMoves()
		{
			throw new NotImplementedException();
		}

		protected override IEnumerable<Move> GetForwardMoves()
		{
			throw new NotImplementedException();
		}
	}
}
