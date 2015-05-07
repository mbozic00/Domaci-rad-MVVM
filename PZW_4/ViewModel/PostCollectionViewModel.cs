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
    public class PostCollectionViewModel : ViewModelBase
    {
        public PostCollectionViewModel()
        {
            var posts = new List<Post>()
            {
                new Post("Penny", "/Resources/Images/Penny.jpg", "2007-09-09 13:34", "I'm not an \"actress\". I'm – an actress!"),
                new Post("Leonard", "/Resources/Images/Leonard.jpg", "2011-11-18 18:30", "I'm going to the movies with Penny.")
            };

            this.PostViewModels = new ObservableCollection<PostViewModel>
            (
                posts.Select(post => new PostViewModel(post))
            );

            this.AddCommand = new AddPostCommand(this);
            this.DeleteCommand = new DeletePostCommand(this);
        }



        public ObservableCollection<PostViewModel> PostViewModels { get; set; }


        public DeletePostCommand DeleteCommand { get; private set; }
        public AddPostCommand AddCommand { get; private set; }

        public Post NewPost = new Post("0", "0", "0", "0");
        public bool isset = false;

        public void ExecuteDeleteCommand(PostViewModel viewModelToDelete)
        {
            this.PostViewModels.Remove(viewModelToDelete);
        }

        public void ExecuteAddCommand()
        {
            var window = new PostAddView(this);
            window.ShowDialog();
            if (isset == true)
            {
                this.PostViewModels.Add(new PostViewModel(NewPost)); 
            }
            isset = false;
        }
    }
}
