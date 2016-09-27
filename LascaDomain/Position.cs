using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lasca.Domain
{
	public class Position
	{
		public int X { get; private set; }
		public int Y { get; private set; }
		

		// CONSTRUTOR
		internal Position(int x, int y)
		{			
			X = x;
			Y = y;
		}

	}
}
