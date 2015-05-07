using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PZW_4.Model;
using PZW_4.View;
using PZW_4.ViewModel.Commands;

namespace PZW_4.ViewModel
{
    public class UserViewModel : ViewModelBase
    {
        public UserViewModel(User user)
        {
            this.User = user;

            this.EditCommand = new EditUserCommand(this);
        }

        public EditUserCommand EditCommand { get; private set; }

        private User user;
        public User User
        {
            get { return this.user; }
            set
            {
                this.user = value;
                this.RaisePropertyChanged("User");
            }
        }

        public void ExecuteEditCommand()
        {
            var window = new UserEditView(this);
            window.ShowDialog();
        }
    }
}
