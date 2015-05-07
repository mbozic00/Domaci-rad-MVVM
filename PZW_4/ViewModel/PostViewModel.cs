using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PZW_4.Model;
using PZW_4.View;
using PZW_4.ViewModel.Commands;

namespace PZW_4.ViewModel
{
    public class PostViewModel : ViewModelBase
    {
        public PostViewModel(Post post)
        {
            this.Post = post;

            this.EditCommand = new EditPostCommand(this);
        }

        public EditPostCommand EditCommand { get; private set; }

        private Post post;
        public Post Post
        {
            get { return this.post; }
            set
            {
                this.post = value;
                this.RaisePropertyChanged("Post");
            }
        }

        public void ExecuteEditCommand()
        {
            var window = new PostEditView(this);
            window.ShowDialog();
        }
    }
}

