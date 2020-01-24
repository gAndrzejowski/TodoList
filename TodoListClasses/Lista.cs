﻿using System;
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
            todos.Add(new Todo("Zadanie dodatkowe", DateTime.Today.AddDays(140), 1, "Bardzo ważne zadanie\nAż do przesady"));
        }
        public List<Todo> Todos
        {
            get => todos;
        }

        public List<Todo> ZmodyfikujLubDodajTodo(Todo todo)
        {
            int pozycja = todos.FindIndex(element => element.Id == todo.Id);
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
