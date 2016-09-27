using GalaSoft.MvvmLight;

namespace Lasca.UI
{
	public class MainViewModel : ViewModelBase
	{
		public string Name => "Lasca is nice";


		public BoardViewModel BoardVM
		{
			get { return _board_vm; }
			set
			{
				_board_vm = value;
				RaisePropertyChanged(() => BoardVM);
			}
		}
		BoardViewModel _board_vm = new BoardViewModel();



		// CONSTRUCTOR
		public MainViewModel()
		{

		}
	}
}
