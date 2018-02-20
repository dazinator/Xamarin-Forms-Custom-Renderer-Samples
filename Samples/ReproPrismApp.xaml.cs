using Prism.Autofac;
using Prism.Ioc;
using Samples.Views;
using Xamarin.Forms;

namespace Samples
{
    public partial class ReproPrismApp : PrismApplication
    {
        public ReproPrismApp()
        {
            InitializeComponent();
            // MainPage = new NavigationPage(new Views.MainPage());
        }      

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage>();
        }

        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync("MainPage").Wait();

            // throw new System.NotImplementedException();
        }
    }
}
