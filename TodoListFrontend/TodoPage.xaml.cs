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
        public TodoPage(Todo todo)
        {
            InitializeComponent();
            this.DataContext = todo;
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
