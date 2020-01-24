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

        [TestMethod]
        public void ZmodyfikujLubDodajTodoDodajeTodoDoListyDlaRoznychId()
        {
            Todo pierwsze = new Todo("Testowe1", DateTime.Now, 2, "", "To todo jest inne niż drugie");
            Todo drugie = new Todo("Testowe1", DateTime.Now, 2, "", "Bo są takie same ale mają inne Id");

            Lista testowa = new Lista();
            testowa.Todos.Add(pierwsze);
            testowa.ZmodyfikujLubDodajTodo(drugie);
            
            Assert.IsTrue(testowa.Todos.Contains(pierwsze));
            Assert.IsTrue(testowa.Todos.Contains(drugie));

        }

        [TestMethod]
        public void ZmodyfikujLubDodajTodoPodmieniaTodoOTymSamymIdWLiscie()
        {
            Todo pierwsze = new Todo("Testowe1", DateTime.Now, 2, "To jest to samo todo co drugie", "foo");
            Todo drugie = new Todo("Testowe2", DateTime.Now, 2, "Bo są różne, ale Id mają to samo", "foo");
            
            Lista testowa = new Lista();
            testowa.Todos.Add(pierwsze);
            testowa.Todos.Add(new Todo());
            testowa.Todos.Add(new Todo());
            
            int pozycjaPierwszego = testowa.Todos.FindIndex(todo => todo == pierwsze);
            testowa.ZmodyfikujLubDodajTodo(drugie);
            
            Assert.IsFalse(testowa.Todos.Contains(pierwsze));
            Assert.IsTrue(testowa.Todos.Contains(drugie));

            int pozycjaDrugiego = testowa.Todos.FindIndex(todo => todo == drugie);
            Assert.AreEqual(pozycjaDrugiego, pozycjaPierwszego);
        }
    }
}
