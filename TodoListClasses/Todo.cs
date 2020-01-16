using System;
using System.Collections.Generic;
using System.Text;

namespace TodoListClasses
{
    public class Todo
    {
        public class Data
        {
            private DateTime data;

            public Data(DateTime _data) { data = _data; }

            public override string ToString()
            {
                return data.ToString("dd MMMM yyyy", null);
            }
        }
        private string nazwa;
        private short priorytet;
        private Data utworzono;
        private Data deadline;
        private string opis;
        
        public string Nazwa { get => nazwa; }
        public short Priorytet { get => priorytet;}
        public Data Utworzono { get => utworzono; }
        public Data Deadline { get => deadline; }
        public string Opis;
        public Todo(string _nazwa, DateTime _deadline, short _priorytet = 3, string _opis = "")
        {
            nazwa = _nazwa;
            priorytet = _priorytet;
            utworzono = new Data(DateTime.Now);
            // Nie ma sprawdzenia czy deadline jest pozniej niz dzisiejsza data - zrobimy to przy tworzeniu zadania i wyświetlimy ew. ostrzeżenie
            deadline = new Data(_deadline);
            opis = _opis;
        }
        public Todo(string _nazwa) : this(_nazwa, DateTime.Today.AddDays(1)) {}

        public Todo() : this("Zadanie bez nazwy") {}

        public override string ToString()
        {
            return $"{Nazwa}\n\n{Deadline}\nP{Priorytet}";
        }
    }
}
