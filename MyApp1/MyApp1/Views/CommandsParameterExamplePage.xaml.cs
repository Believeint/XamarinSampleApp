using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp1.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CommandsParameterExamplePage : ContentPage
    {
        public CommandParametersExampleViewModel VM => ((CommandParametersExampleViewModel)BindingContext);
        public CommandsParameterExamplePage()
        {
            InitializeComponent();

            VM.IncreaseCommand.Execute("10");
        }
    }
}