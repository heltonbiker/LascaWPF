using GalaSoft.MvvmLight;
using LascaDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lasca.UI
{
	public class PieceViewModel : ObservableObject
	{
		Piece _piece;		

		

		// CONSTRUCTOR
		public PieceViewModel(Piece piece)
		{
			_piece = piece;
		}
	}
}
