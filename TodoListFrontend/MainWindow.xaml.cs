﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TodoListClasses;

namespace TodoListFrontend
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            Todos.ItemsSource = new Lista().Todos;
        }

        public void TodoClick(object target, SelectionChangedEventArgs e)
        {
            Todo todo = (Todo)(target as ListBox).SelectedItem;
            this.Content = todo;
        }
        
    }
}
