using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFDriversAndResults.ViewModels;

namespace WPFDriversAndResults.Comands
{
    public class DeleteCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return parameter != null && parameter is DCResultViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            //StudentList находится во viewmodel 
        }
    }
}
