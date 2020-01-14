using System;
using System.Collections.Generic;
using System.Text;

namespace TodoListClasses
{
    public class Todo
    {
        private string nazwa;
        public string Nazwa
        {
            get => nazwa;
        }
        public Todo(string _nazwa)
        {
            nazwa = _nazwa;
        }
   
        public override string ToString()
        {
            return Nazwa;
        }
    }
}
