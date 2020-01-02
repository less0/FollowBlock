using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FollowBlock.Views;
using Prism.Unity;
using Prism.Ioc;

namespace FollowBlock
{
    public partial class App : PrismApplication
    {

        public App()
        {
            InitializeComponent();
        }



        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<AboutPage>();
        }

        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync("AboutPage");
        }
    }
}
