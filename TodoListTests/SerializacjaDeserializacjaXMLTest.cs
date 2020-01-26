using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoListClasses;
using System.IO;

namespace TodoListTests
{
    [TestClass]
    public class SerializacjaDeserializacjaXMLTest
    {
        string xml = @"<?xml version=""1.0"" encoding=""utf-8""?>
<Lista xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <Todos>
    <Todo>
      <Nazwa>Test</Nazwa>
      <Priorytet>2</Priorytet>
      <Deadline>2012-08-05T00:00:00</Deadline>
      <Opis>Zadanie zostanie zserializowane</Opis>
    </Todo>
  </Todos>
</Lista>";

        [TestMethod]
        public void SerializacjaListy()
        {
            
            Lista lista = new Lista();
            lista.ZmodyfikujLubDodajTodo(new Todo(
                "Test", 
                new DateTime(2012, 8, 5), 
                2, 
                "Zadanie zostanie zserializowane"
            ));
            SerializacjaDeserializacjaXML.Zapis("test.xml", lista);

            StreamReader testXml = new StreamReader("test.xml");
            string zserializowane = testXml.ReadToEnd();
            testXml.Close();
            File.Delete("test.xml");
            Assert.AreEqual(xml, zserializowane);
        }

        [TestMethod]
        public void OdczytZserializowanejListy()
        {
            StreamWriter testXml = new StreamWriter("test.xml", false);
            testXml.Write(xml);
            testXml.Close();
            Lista odczytana = SerializacjaDeserializacjaXML.Odczyt("test.xml");
            File.Delete("test.xml");

            Assert.AreEqual(1, odczytana.Todos.Count);
            Assert.AreEqual("Test", odczytana.Todos[0].Nazwa);
            Assert.AreEqual(2, odczytana.Todos[0].Priorytet);
            Assert.AreEqual(new DateTime(2012, 8, 5), odczytana.Todos[0].Deadline);
            Assert.AreEqual("Zadanie zostanie zserializowane", odczytana.Todos[0].Opis);


        }
    }
}
