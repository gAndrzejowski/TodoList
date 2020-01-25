using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TodoListClasses;

namespace TodoListFrontend
{
    /// <summary>
    /// Logika interakcji dla klasy App.xaml
    /// </summary>
    public partial class App : Application
    {
        public Lista AktualnaLista = new Lista();

        public void ZmodyfikujLubDodajTodo(Todo zmienione)
        {
            AktualnaLista.ZmodyfikujLubDodajTodo(zmienione);
        }

        public void UsunTodo(Todo doUsuniecia)
        {
            AktualnaLista.UsunTodo(doUsuniecia);
        }
    }
}
