using System;

namespace SerializableWork
{
    // ����� Car ����� �������� ��� ������������.
    [Serializable]
    public class Car
    {
        protected int speed;
        protected string name;       
        protected Radio radio;
                
        public Car(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
            radio = new Radio();
        }

        // ����� ���������/���������� �����.
        public void TurnOnRadio(bool state)
        {
            this.radio.OnOff(state);
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Speed
        {
            get => speed;
            set => speed = value;
        }
    }
}
