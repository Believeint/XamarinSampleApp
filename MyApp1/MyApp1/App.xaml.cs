using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyApp1.Views;

[assembly:XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new BindingExamplePage();
            //MainPage = new CommandsExamplePage();
            //MainPage = new CommandsParameterExamplePage();
            MainPage = new BindingInViewPage();
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
    }
}
