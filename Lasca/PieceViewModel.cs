using GalaSoft.MvvmLight;
using Lasca.Domain;

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
