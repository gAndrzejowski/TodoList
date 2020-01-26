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
using Microsoft.Win32;
using TodoListClasses;

namespace TodoListFrontend
{
    /// <summary>
    /// Logika interakcji dla klasy MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        App aplikacja;
        private string xmlSpec = "XML Files (*.xml) | *.xml";
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

        private void NoweTodoClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Edycja());
        }

        private void ZapisDoPlikuClick(object sender, RoutedEventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = xmlSpec;
            fileDialog.Title = "Wybierz plik do eksportu listy";
            if (fileDialog.ShowDialog() == true)
            {
                SerializacjaDeserializacjaXML.Zapis(fileDialog.FileName, aplikacja.AktualnaLista);
            }
        }

        private void OdczytZPlikuClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = xmlSpec;
            fileDialog.Title = "Wybierz plik do zaimportowania listy";
            if (fileDialog.ShowDialog() == true)
            {
                Lista odczytano = SerializacjaDeserializacjaXML.Odczyt(fileDialog.FileName);
                aplikacja.AktualnaLista = odczytano;
                Todos.ItemsSource = odczytano.Todos;
            }
        }
    }
}
