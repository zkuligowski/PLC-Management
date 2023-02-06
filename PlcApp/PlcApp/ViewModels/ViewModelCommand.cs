

namespace PlcApp.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Printing;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Input;

    public class ViewModelCommand : ICommand
    {
        // Fields
        private readonly Action<object> _execute_Action;
        private readonly Predicate<object> _canExecuteAction;

        // Constructors
        public ViewModelCommand(Action<object> execute_Action)
        {
            this._execute_Action = execute_Action;
            this._canExecuteAction = null;
        }

        public ViewModelCommand(Action<object> execute_Action, Predicate<object> canExecuteAction)
        {
            this._execute_Action = execute_Action;
            this._canExecuteAction = canExecuteAction;
        }

        // Events
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        // Methods
        public bool CanExecute(object parameter)
        {
            return this._canExecuteAction == null ? true : this._canExecuteAction(parameter);
        }

        public void Execute(object parameter)
        {
            this._execute_Action(parameter);
        }
    }
}
