using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.IO;

namespace TodoListClasses
{
    public abstract class SerializacjaDeserializacjaXML
    {
        public static Lista Odczyt(string plik)
        {
            StreamReader handle = new StreamReader(plik);
            XmlSerializer serializer = new XmlSerializer(typeof(Lista));
            Lista odczytanaLista = (Lista)serializer.Deserialize(handle);
            handle.Close();
            return odczytanaLista;
        }

        public static void Zapis(string plik, Lista doZapisu)
        {
            StreamWriter handle = new StreamWriter(plik, false);
            XmlSerializer serializer = new XmlSerializer(typeof(Lista));
            serializer.Serialize(handle, doZapisu);
            handle.Close();
        }
    }
}
