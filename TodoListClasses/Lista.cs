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
        }
        public List<Todo> Todos
        {
            get => todos;
        }

        private int znajdzTodo(Todo todo)
        {
            return todos.FindIndex(element => element.Id == todo.Id);
        }

        public List<Todo> UsunTodo(Todo todo)
        {
            int pozycja = znajdzTodo(todo);

            if (pozycja != -1)
            {
                todos.RemoveAt(pozycja);
            }
            return Todos;
        }

        public List<Todo> ZmodyfikujLubDodajTodo(Todo todo)
        {
            int pozycja = znajdzTodo(todo);

            if (pozycja == -1)
            {
                todos.Add(todo);
            }
            else
            {
                todos.RemoveAt(pozycja);
                todos.Insert(pozycja, todo);
            }
            return Todos;
        }
    }
}
