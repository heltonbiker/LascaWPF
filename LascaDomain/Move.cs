using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LascaDomain
{
	public class Move
	{
		private Match match;

		public Move(Match match)
		{
			this.match = match;
		}

		public void Execute()
		{
			match.ChangeTurn();
		}
	}
}
