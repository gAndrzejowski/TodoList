using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace TodoListClasses
{
    public class Todo
    {
        private class Data
        {
            private DateTime data;

            public Data(DateTime _data) { data = _data; }

            public Data(int year, int month, int day)
            {
                data = new DateTime(year, month, day);
            }

            public int GetDay() => data.Day;
            public int GetMOnth() => data.Month;
            public int GetYear() => data.Year;

            public DateTime CloneDate() => new DateTime(data.Year, data.Month, data.Day);
            

            public override string ToString()
            {
                return data.ToString("dd MMMM yyyy", null);
            }
        }
        private string nazwa;
        private short priorytet;
        private Data deadline;
        private string opis;
        private string id;
        
        public string Nazwa { get => nazwa; set => nazwa = value; }
        public short Priorytet { get => priorytet; set => priorytet = value; }
        public DateTime Deadline { get => deadline.CloneDate(); set => deadline = new Data(value); }
        public string DeadlineSformatowane { get => deadline.ToString(); }
        public string Opis { get => opis; set => opis = value; }

        public string Id { get => id; }
        public Todo(string _nazwa, DateTime _deadline, short _priorytet = 3, string _opis = "", string _id = null)
        {
            nazwa = _nazwa;
            priorytet = _priorytet;
            if (_id == null )
            {
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                byte[] idTable = new byte[8];
                rng.GetBytes(idTable);
                id = string.Join("", idTable);
                rng.Dispose();
            }
            else
            {
                id = _id;
            }
            deadline = new Data(_deadline);
            opis = _opis;
        }
        public Todo(string _nazwa) : this(_nazwa, DateTime.Today.AddDays(1)) {}

        public Todo() : this("Zadanie bez nazwy") {}

        public override string ToString()
        {
            return $"{Nazwa}\n\n{deadline.ToString()}\nP{Priorytet}";
        }
    }
}
