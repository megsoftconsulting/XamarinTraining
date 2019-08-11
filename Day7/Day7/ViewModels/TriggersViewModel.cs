using Xamarin.Forms;

namespace Day7.ViewModels
{
    public class TriggersViewModel : BindableObject
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public TriggersViewModel()
        {
            // We need to set an initial value to trigger the default state of the control
            Name = "";
        }
    }
}
