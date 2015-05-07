﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;


namespace PZW_4.ViewModel.Commands
{
    public class DeletePostCommand : ICommand
    {
        public DeletePostCommand(PostCollectionViewModel postCollectionViewModel)
        {
            this.Owner = postCollectionViewModel;
        }

        public PostCollectionViewModel Owner { get; private set; }

        public bool CanExecute(object parameter) { return true; }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (parameter is PostViewModel)
            {
                this.Owner.ExecuteDeleteCommand(parameter as PostViewModel);
            }
        }
    }
}
