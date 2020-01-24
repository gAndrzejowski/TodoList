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
    /// Logika interakcji dla klasy MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        App aplikacja;
        public MainPage()
        {
            InitializeComponent();
            aplikacja = ((App)Application.Current);
            this.Todos.ItemsSource = aplikacja.AktualnaLista.Todos;
        }
        public void TodoClick(object target, SelectionChangedEventArgs e)
        {
            Todo todo = (Todo)(target as ListBox).SelectedItem;
            this.NavigationService.Navigate(new TodoPage(todo));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Edycja());
        }
    }
}
