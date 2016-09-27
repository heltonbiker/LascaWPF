using GalaSoft.MvvmLight;
using Lasca.Domain;
using LascaDomain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lasca.UI
{
	public class MainViewModel : ViewModelBase
	{
		public ObservableCollection<PieceViewModel> Pieces { get; private set; }
			= new ObservableCollection<PieceViewModel>();

		public string Name => "Lasca is nice";


		// CONSTRUCTOR
		public MainViewModel()
		{
			var piece1 = new Piece(TeamColor.Black, Position._44);
			Pieces.Add(new PieceViewModel(piece1));

			var piece2 = new Piece(TeamColor.White, Position._66);
			Pieces.Add(new PieceViewModel(piece2));
		}
	}
}
