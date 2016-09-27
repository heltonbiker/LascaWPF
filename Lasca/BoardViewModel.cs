using GalaSoft.MvvmLight;
using Lasca.Domain;
using System.Collections.ObjectModel;

namespace Lasca.UI
{
	public class BoardViewModel : ViewModelBase
	{
		Board _board;

		public ObservableCollection<PieceViewModel> Pieces { get; private set; }
			= new ObservableCollection<PieceViewModel>();



		public BoardViewModel()
		{

		}
	}
}
