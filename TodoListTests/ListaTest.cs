using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TodoListClasses;

namespace TodoListTests
{
    [TestClass]
    public class TestLista
    {
        [TestMethod]
        public void ListTworzyNiepustaListeTodos()
        {
            Lista listaTestowa = new Lista();
            Assert.AreNotEqual(listaTestowa.Todos.Count, 0);
        }
    }
}
