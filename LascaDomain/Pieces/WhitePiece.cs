using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lasca.Domain
{
	class WhitePiece : Piece
	{
		internal WhitePiece(Position position) 
			: base(TeamType.White, position) { }



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
