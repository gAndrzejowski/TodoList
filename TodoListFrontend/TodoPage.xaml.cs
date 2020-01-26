using System;
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
    /// Logika interakcji dla klasy TodoPage.xaml
    /// </summary>
    public partial class TodoPage : Page
    {
        public Todo CurrentTodo;
        public TodoPage(Todo todo)
        {
            InitializeComponent();
            CurrentTodo = todo;
            this.DataContext = CurrentTodo;
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainPage());
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            App aplikacja = ((App)Application.Current);
            aplikacja.UsunTodo(CurrentTodo);
            this.NavigationService.Navigate(new MainPage());
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Edycja(CurrentTodo));
        }

    }
}
