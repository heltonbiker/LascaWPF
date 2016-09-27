using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lasca.Domain
{
	public enum Position
	{
		_71, _73, _75, _77,
		   _62, _64, _66,
		_51, _53, _55, _57,
		   _42, _44, _46,
		_31, _33, _35, _37,
		   _22, _24, _26,
		_11, _13, _15, _17,
	}

	public static class Moves
	{
		public static Dictionary<Position, IEnumerable<Position>> North
			= new Dictionary<Position, IEnumerable<Position>>()
			{
				{ Position._11, new[] { Position._22 } },
				{ Position._13, new[] { Position._22, Position._24} }
			};
	}
}
