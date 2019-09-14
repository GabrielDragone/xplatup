using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.DryIoc;
using Prism.Ioc;
using XplatCollect.Views;
using Prism;

namespace XplatCollect
{
    public partial class App : PrismApplication
    {
        public App() : this(null){ }

        public App(IPlatformInitializer platformInitializer)
            : base(platformInitializer, true)
        {
        }

        public App(IPlatformInitializer platformInitializer, bool setFormsDependencyResolver)
            : base(platformInitializer, setFormsDependencyResolver)
        {
        }


        protected override async void OnInitialized()
        {
            //throw new NotImplementedException();
            InitializeComponent();

            await NavigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(MainPage)}?selectedTab={nameof(HomePage)}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<HomePage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<ProfilePage>();
            containerRegistry.RegisterForNavigation<NewCollectionPage>();
        }
    }
}
