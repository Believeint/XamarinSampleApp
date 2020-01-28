using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyApp1.ViewModels
{
    public class BindingInViewViewModel : INotifyPropertyChanged
    {
        public BindingInViewViewModel()
        {
            IncreaseCommand = new Command<string>(IncreaseCount);
        }

        private void IncreaseCount(string obj)
        {
            if(int.TryParse(obj, out int result))
            {
                count += result;
                OnPropertyChanged(nameof(DisplayCount));
            }

        }

        public Command<string> IncreaseCommand { get; } 

        int count = 0;

        public string DisplayCount => $"Clicked {count} time(s).";




        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
