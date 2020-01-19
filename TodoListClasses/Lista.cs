using System;
using System.Collections.Generic;

namespace TodoListClasses
{
    public class Lista
    {
        private List<Todo> todos;
        public Lista()
        {
            todos = new List<Todo>();
            todos.Add(new Todo("Zadanie pierwsze"));
            todos.Add(new Todo("Zadanie drugie"));
            todos.Add(new Todo("Zadanie które pominęło trzecie"));
            todos.Add(new Todo("Zadanie piąte"));
            todos.Add(new Todo("Zadanie dodatkowe", DateTime.Today.AddDays(140), 1, "Bardzo ważne zadanie\nAż do przesady"));
        }
        public List<Todo> Todos
        {
            get => todos;
        }
    }
}
