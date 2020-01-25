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

        [TestMethod]
        public void UsunTodoUsuwaZnalezioneNaLiscieTodo()
        {
            Lista testowa = new Lista();
            Todo doUsuniecia = new Todo("To todo jest na liście", new DateTime(2012, 12, 3), 3, "Więc zostanie usunięte", "70j357n4l15c13");
            testowa.Todos.Add(doUsuniecia);
            testowa.UsunTodo(doUsuniecia);
            Assert.AreEqual(-1, testowa.Todos.FindIndex(todo => todo.Id == doUsuniecia.Id));
        }

        public void UsunTodoNieZmieniaListyJesliTodoNieZostanieZnalezione()
        {
            Lista testowa = new Lista();
            Todo nieobecneNaLiscie = new Todo("Tego nie ma na liście", new DateTime(2012, 12, 3), 3, "Więc nic się nie zmieni", "73go70d0n13m4");
            int dlugoscListyPrzedUsun = testowa.Todos.Count;
            testowa.UsunTodo(nieobecneNaLiscie);
            Assert.AreEqual(dlugoscListyPrzedUsun, testowa.Todos.Count);
        }
    }
}
