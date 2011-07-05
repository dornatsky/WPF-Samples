
using System.Windows.Input;
using System.ComponentModel;
namespace XAMLDataBinding
{
    public class Context : INotifyPropertyChanged
    {
        private string _text = "SomeText";
        private ICommand _updateText;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Text
        {
            get { return _text; }
            set
            {
                if (_text == value)
                    return;

                _text = value;
                NotifyPropertyChanged("Text");
            }
        }

        public ICommand UpdateTextCommand { get { return _updateText ?? (_updateText = new DelegateCommand((obj) => UpdateText(), (obj) => true)); } }

        private void UpdateText()
        {
            this.Text = _text + " updated";
        }

        public void NotifyPropertyChanged(string propertyName)
        {
            var pChanged = this.PropertyChanged;
            if (pChanged != null)
                pChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
