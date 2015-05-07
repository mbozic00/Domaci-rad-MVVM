using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;


namespace PZW_4.ViewModel.Commands
{
    public class EditUserCommand : ICommand
    {
        public EditUserCommand(UserViewModel userViewModel)
        {
            this.Owner = userViewModel;
        }

        public UserViewModel Owner { get; private set; }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.Owner.ExecuteEditCommand();
        }
    }
}
