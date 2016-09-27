using System.Collections.Generic;

namespace Lasca.Domain
{
	public static class Positions
	{
		public static Position
		_71, _73, _75, _77,
		   _62, _64, _66,
		_51, _53, _55, _57,
		   _42, _44, _46,
		_31, _33, _35, _37,
		   _22, _24, _26,
		_11, _13, _15, _17;

		static Positions()
		{
			_11 = new Position(1, 1);
			_13 = new Position(1, 3);

			_44 = new Position(4, 4);
		}
	}

}
