using CoinFlip.ViewModels;

namespace CoinFlip.Views;

public partial class CoinView : ContentPage
{
	public CoinView()
	{
		InitializeComponent();
		this.BindingContext = new CoinViewModel();
	}
}