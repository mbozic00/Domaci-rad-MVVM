﻿using System;
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
    /// Interaction logic for UserEditView.xaml
    /// </summary>
    public partial class UserEditView : Window
    {
        public UserEditView(UserViewModel userViewModel)
        {
            this.DataContext = userViewModel;

            InitializeComponent();

            this.ButtonSave.Click += new RoutedEventHandler(ButtonSave_Click);
        }

        void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            var bindingExpression = this.NameField.GetBindingExpression(TextBox.TextProperty);

            bindingExpression.UpdateSource();

            this.Close();
        }
    }
}
