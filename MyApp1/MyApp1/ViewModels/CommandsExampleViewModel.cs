using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyApp1.ViewModels
{
    public class CommandsExampleViewModel : INotifyPropertyChanged
    {
        public CommandsExampleViewModel()
        {
            IncreaseCommand = new Command(IncreaseCount);
        }


        public ICommand IncreaseCommand { get; }

        int count = 0;


        void IncreaseCount()
        {
            count++;
            OnPropertyChanged(nameof(DisplayCount));
        }

        public string DisplayCount => $"You Clicked {count} time(s).";



        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
