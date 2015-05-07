using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PZW_4.Model;
using PZW_4.View;
using PZW_4.ViewModel.Commands;

namespace PZW_4.ViewModel
{
    public class UserCollectionViewModel : ViewModelBase
    {
        public UserCollectionViewModel()
        {
            var users = new List<User>()
            {
                new User("Penny", 2, "/Resources/Images/Penny.jpg"),
                new User("Leonard", 3, "/Resources/Images/Leonard.jpg"),
                new User("Amy", 4, "/Resources/Images/Amy.jpg")
            };

            var users1 = new List<User>()
            {
                new User("Sheldon", 1, "/Resources/Images/Sheldon.jpg"),
            };

            this.UserViewModels = new ObservableCollection<UserViewModel>
            (
                users.Select(user => new UserViewModel(user))
            );

            this.CurrentUserViewModels = new ObservableCollection<UserViewModel>
            (
                users1.Select(user => new UserViewModel(user))
            );

            this.AddCommand = new AddUserCommand(this);
            this.DeleteCommand = new DeleteUserCommand(this);
        }

         

        public ObservableCollection<UserViewModel> UserViewModels { get; set; }
        public ObservableCollection<UserViewModel> CurrentUserViewModels { get; set; }


        public DeleteUserCommand DeleteCommand { get; private set; }
        public AddUserCommand AddCommand { get; private set; }

        public User NewUser = new User ("0", 0, "0");
        public bool isset = false;

        public void ExecuteDeleteCommand(UserViewModel viewModelToDelete)
        {
            this.UserViewModels.Remove(viewModelToDelete);
        }

        public void ExecuteAddCommand()
        {
            var window = new UserAddView(this);
            window.ShowDialog();
            if (isset == true)
            {
                NewUser.Id = this.UserViewModels.Last().User.Id + 1;
                this.UserViewModels.Add(new UserViewModel(NewUser));
            }
            isset = false;
        }
    }
}
