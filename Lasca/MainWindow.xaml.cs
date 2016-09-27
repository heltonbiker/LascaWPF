using System.Windows;

namespace Lasca.UI
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			DataContext = new MainViewModel();
		}
	}
}
