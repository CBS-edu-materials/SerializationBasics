using System.Collections.Generic;
using System.Drawing;
using System.Xml.Serialization;

namespace XML
{
    // XmlRoot - ��������������� �������� ����.
    [XmlRoot("MyButton")]
    public class MyClass
    {
        private string id = "button";
        private int size = 10;
        private Point position = new Point(20, 30);
        private string password = "1234567890_password";
        private List<string> items = new List<string>();

        // XML ������� ��������������� � ������ ���������.
        [XmlAttribute("SerialID")]
        public string ID
        {
            get => id;
            set => id = value;
        }

        //XML �������.
        [XmlAttribute("Length")]
        public int Size
        {
            get => size;
            set => size = value;
        }

        //XML �������.
        [XmlElement("Pos")]
        public Point Position
        {
            get => position;
            set => position = value;
        }

        // ��������� �������� �� �������� ������������/��������������.
        [XmlIgnore]
        public string Password
        {
            get => password;
            set => password = value;
        }

        // �������������� �������.
        [XmlArray("List")]
        // �������������� ������� �������� �������.
        [XmlArrayItem("Element")]
        public List<string> Items
        {
            get => items;
            set => items = value;
        }
    }
}