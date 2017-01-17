using System;
using System.Windows.Input;

namespace BandBindingNavigator
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object> _relayedMethod;
        private readonly Func<object, bool> _relayedCanExecute;

        public RelayCommand(Action<object> relayedMethod)
        {
            _relayedMethod = relayedMethod;
        }

        public RelayCommand(Action<object> relayedMethod, Func<object, bool> relayedCanExecute)
            : this(relayedMethod)
        {
            _relayedCanExecute = relayedCanExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (_relayedMethod == null)
            {
                return false;
            }

            if (_relayedCanExecute != null)
            {
                return _relayedCanExecute.Invoke(parameter);
            }

            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }

        public void Execute(object parameter)
        {
            _relayedMethod?.Invoke(parameter);
        }
    }
}
