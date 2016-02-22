using System;
using System.ComponentModel;

namespace MVVM_WPF_HelloWorld.ViewModel
{
    public abstract class ViewModelBase : INotifyPropertyChanged, IDisposable
    {
        protected ViewModelBase()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        public void Dispose()
        {
            this.OnDispose();
        }

        protected virtual void OnDispose()
        {
        }

        protected virtual void OnPropertyChaged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            } 
        }
        
    }
}
