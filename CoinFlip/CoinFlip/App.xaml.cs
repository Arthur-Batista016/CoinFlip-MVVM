using CoinFlip.Views;

namespace CoinFlip
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CoinView();
        }
    }
}
