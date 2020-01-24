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
    /// Logika interakcji dla klasy Edycja.xaml
    /// </summary>
    public partial class Edycja : Page
    {
        private Todo initialTodo;
        private App aplikacja;
        public Todo CurrentTodo { get; set; }
        public Edycja()
        {
            InitializeComponent();
            aplikacja = ((App)Application.Current);
            initialTodo = new Todo();
            Reset();
            this.DataContext = CurrentTodo;
        }

        private void Reset()
        {
            CurrentTodo = new Todo(initialTodo.Nazwa, initialTodo.Deadline, initialTodo.Priorytet, initialTodo.Opis);
            this.DataContext = CurrentTodo;
        }

        public void Reset(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        public Edycja(Todo _todo)
        {
            InitializeComponent();
            initialTodo = _todo;
            Reset();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            aplikacja.ZmodyfikujLubDodajTodo(CurrentTodo);
            this.NavigationService.Navigate(new MainPage());
        }
        
    }
}
