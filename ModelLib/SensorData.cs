using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib
{
    public class SensorData
    {
        private int _id;
        private string _name;
        private double _temp;
        private int _co2;

        public SensorData()
        {

        }

        public SensorData(int id, string name, double temp, int co2)
        {
            Id = id;
            Name = name;
            Temp = temp;
            Co2 = co2;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name;}
            set { _name = value; }
        }

        public double Temp
        {
            get { return _temp; }
            set { _temp = value; }
        }

        public int Co2
        {
            get { return _co2; }
            set { _co2 = value; }
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Temp)}: {Temp}, {nameof(Co2)}: {Co2}";
        }
    }
}
