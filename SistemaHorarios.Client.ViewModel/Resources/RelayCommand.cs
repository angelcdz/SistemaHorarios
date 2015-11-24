using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SistemaHorarios.Client.ViewModel
{
    public class RelayCommand : ICommand
    {
        public RelayCommand()
        {

        }
        public RelayCommand(Predicate<object> canExecuteFunc, Action<object> executeFunc)
        {
            this.CanExecuteFunc = canExecuteFunc;
            this.ExecuteFunc = executeFunc;
        }

        public Predicate<object> CanExecuteFunc { get; set; }
        public Action<object> ExecuteFunc { get; set; }

        public bool CanExecute(object parameter) { return CanExecuteFunc(parameter); }
        public void Execute(object parameter) { ExecuteFunc(parameter); }

        public event EventHandler CanExecuteChanged;

    }
}
