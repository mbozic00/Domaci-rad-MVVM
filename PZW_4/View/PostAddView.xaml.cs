using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PZW_4.ViewModel;


namespace PZW_4.View
{
    /// <summary>
    /// Interaction logic for PostAddView.xaml
    /// </summary>
    public partial class PostAddView : Window
    {
        public PostCollectionViewModel postCVM;

        public PostAddView(PostCollectionViewModel postCollectionViewModel)
        {
            this.DataContext = postCollectionViewModel;
            this.postCVM = postCollectionViewModel;

            InitializeComponent();

            this.ButtonAdd.Click += new RoutedEventHandler(ButtonAdd_Click);

        }

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyy-MM-dd HH:mm");
        }

        void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            this.postCVM.NewPost = new Model.Post(this.NameField.Text, this.PathField.Text, GetTimestamp(DateTime.Now), this.TextField.Text);
            this.postCVM.isset = true;
            this.Close();
        }
    }
}
