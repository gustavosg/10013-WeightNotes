#region References

using System.ComponentModel;

#endregion

namespace ViewModelHelpers
{
    public class NotifyPropertyChanged : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;

            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}
