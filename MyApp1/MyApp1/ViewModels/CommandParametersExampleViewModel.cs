using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyApp1.ViewModels
{
    public class CommandParametersExampleViewModel : INotifyPropertyChanged
    {
        public CommandParametersExampleViewModel()
        {
            IncreaseCommand = new Command<string>(IncreaseCount);
        }

        public Command<string> IncreaseCommand { get; }

        int count = 0;

        void IncreaseCount(string i)
        {
            if(int.TryParse(i, out int result))
            {
                count += result;
                OnPropertyChanged(nameof(DisplayCount));
            }
        }

        public string DisplayCount => $"Cliked {count} time(s).";


        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
