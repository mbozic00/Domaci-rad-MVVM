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
    /// Interaction logic for UserAddView.xaml
    /// </summary>
    public partial class UserAddView : Window
    {
        public UserCollectionViewModel userCVM;

        public UserAddView(UserCollectionViewModel userCollectionViewModel)
        {
            this.DataContext = userCollectionViewModel;
            this.userCVM = userCollectionViewModel;

            InitializeComponent();

            this.ButtonAdd.Click += new RoutedEventHandler(ButtonAdd_Click);

        }

        void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            this.userCVM.NewUser = new Model.User(this.NameField.Text, 1, this.PathField.Text);
            this.userCVM.isset = true;
            this.Close();
        }
    }
}
