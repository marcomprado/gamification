

using System.ComponentModel;

namespace gamification.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private string _title = "Bem-vindo à Gamificação!";
        public string Title
        {
            get => _title;
            set
            {
                if (_title != value)
                {
                    _title = value;
                    OnPropertyChanged(nameof(Title));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}