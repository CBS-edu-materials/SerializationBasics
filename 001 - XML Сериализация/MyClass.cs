using System.Collections.Generic;
using System.Drawing;
using System.Xml.Serialization;

namespace XML
{
    // XmlRoot - Переименовывает корневой узел.
    [XmlRoot("MyButton")]
    public class MyClass
    {
        private string id = "button";
        private int size = 10;
        private Point position = new Point(20, 30);
        private string password = "1234567890_password";
        private List<string> items = new List<string>();

        // XML атрибут переименовываем и делаем атрибутом.
        [XmlAttribute("SerialID")]
        public string ID
        {
            get => id;
            set => id = value;
        }

        //XML атрибут.
        [XmlAttribute("Length")]
        public int Size
        {
            get => size;
            set => size = value;
        }

        //XML элемент.
        [XmlElement("Pos")]
        public Point Position
        {
            get => position;
            set => position = value;
        }

        // Исключаем свойство из процесса сериализации/десериализации.
        [XmlIgnore]
        public string Password
        {
            get => password;
            set => password = value;
        }

        // Характеристика массива.
        [XmlArray("List")]
        // Характеристика каждого элемента массива.
        [XmlArrayItem("Element")]
        public List<string> Items
        {
            get => items;
            set => items = value;
        }
    }
}