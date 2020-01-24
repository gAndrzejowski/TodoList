using System;
using System.Globalization;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoListClasses;

namespace TodoListTests
{
    [TestClass]
    public class TodoTest
    {
        private readonly string testowaNazwa = "Testowe todo";
        private readonly short testowyPriorytet = 1;
        private readonly DateTime testowyDeadline = new DateTime(2020, 10, 15);
        private readonly DateTime domyslnyDeadline = DateTime.Today.AddDays(1);
        private readonly string testowyOpis = "Zrobić coś czego szczegóły podajemy tutaj";
        private readonly string domyslnyOpis = "";
        private readonly short domyslnyPriorytet = 3;
        private readonly string domyslnaNazwa = "Zadanie bez nazwy";
        
        [TestMethod]
        public void KonstruktorZKompletemParametrow()
        {
            Todo zKompletemParametrow = new Todo(testowaNazwa, testowyDeadline, testowyPriorytet, testowyOpis);
            Assert.AreEqual(zKompletemParametrow.Nazwa, testowaNazwa);
            Assert.AreEqual(zKompletemParametrow.Deadline.ToString(), testowyDeadline.ToString());
            Assert.AreEqual(zKompletemParametrow.Priorytet, testowyPriorytet);
            Assert.AreEqual(zKompletemParametrow.Opis, testowyOpis);
        }

        [TestMethod]
        public void KonstruktorBezOpisu()
        {
            Todo bezOpisu = new Todo(testowaNazwa, testowyDeadline, testowyPriorytet);
            Assert.AreEqual(bezOpisu.Nazwa, testowaNazwa);
            Assert.AreEqual(bezOpisu.Deadline.ToString(), testowyDeadline.ToString());
            Assert.AreEqual(bezOpisu.Priorytet, testowyPriorytet);
            Assert.AreEqual(bezOpisu.Opis, domyslnyOpis);

        }

        [TestMethod]
        public void KonstruktorBezpisuIPriorytetu()
        {
            Todo bezOpisuIPriorytetu = new Todo(testowaNazwa, testowyDeadline);
            Assert.AreEqual(bezOpisuIPriorytetu.Nazwa, testowaNazwa);
            Assert.AreEqual(bezOpisuIPriorytetu.Deadline.ToString(), testowyDeadline.ToString());
            Assert.AreEqual(bezOpisuIPriorytetu.Priorytet, domyslnyPriorytet);
            Assert.AreEqual(bezOpisuIPriorytetu.Opis, domyslnyOpis);

        }

        [TestMethod]
        public void KonstruktorZSamaNazwa()
        {
            Todo tylkoNazwa = new Todo(testowaNazwa);
            Assert.AreEqual(tylkoNazwa.Nazwa, testowaNazwa);
            Assert.AreEqual(tylkoNazwa.Deadline.ToString(), domyslnyDeadline.ToString());
            Assert.AreEqual(tylkoNazwa.Priorytet, domyslnyPriorytet);
            Assert.AreEqual(tylkoNazwa.Opis, domyslnyOpis);
        }

        [TestMethod]
        public void KonstruktorBezParametrow()
        {
            Todo bezParametrow = new Todo();
            Assert.AreEqual(bezParametrow.Nazwa, domyslnaNazwa);
            Assert.AreEqual(bezParametrow.Deadline.ToString(), domyslnyDeadline.ToString());
            Assert.AreEqual(bezParametrow.Priorytet, domyslnyPriorytet);
            Assert.AreEqual(bezParametrow.Opis, domyslnyOpis);
        }

        [TestMethod]

        public void KonwersjaDoStringa()
        {
            string expected = "Przetestować ToString()\n\n24 października 2021\nP1";
            Todo todo = new Todo("Przetestować ToString()", new DateTime(2021, 10, 24), 1);
            Assert.AreEqual(expected, todo.ToString());
        }

        [TestMethod]

        public void AutomatycznaGeneracjaUnikalnychIdentyfikatorow()
        {
            HashSet<string> stworzoneId = new HashSet<string>();
            List<string> wszystkie = new List<string>();
            // Na potrzeby tego zastosowania 1000 to aż nadto
            for (int i = 1; i<=1000; i++) 
            {
                Todo nowe = new Todo();
                stworzoneId.Add(nowe.Id);
                wszystkie.Add(nowe.Id);
            };
            Assert.AreEqual(1000, stworzoneId.Count);
            
        }
    }
}
