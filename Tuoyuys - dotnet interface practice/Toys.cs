using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuoyuys___dotnet_interface_practice
{
    class Chest : IOpenable, IFillable
    {
        public int FillLevel = 1110;
        public bool Opened = true;
        private string _name = "Chest";

        public Chest() { }

        public Chest(Chest chest)
        {
            this.FillLevel = chest.FillLevel;
            this.Opened = chest.Opened;
            this._name = chest._name;
        }

        public string Name { get { return _name; } set { _name = value; } }

        public void ChangeFillLevel(int level)
        {
            FillLevel = level;
        }

        public int GetFillLevel()
        {   
            return FillLevel;
        }

        public bool GetOpen()
        {
            return Opened;
        }

        public void Open(bool opened)
        {
            Opened = opened;
        }
    }
    class Car : IOpenable, IAccelerable
    {
        public int Speed = 123;
        public bool Opened = false;
        private string _name = "Car";

        public Car() { }

        public Car(Car car)
        {
            this.Speed = car.Speed;
            this.Opened = car.Opened;
            this._name = car._name;
        }

        public string Name { get { return _name; } set { _name = value; } }

        public void ChangeSpeed(int speed)
        {
            Speed = speed;
        }

        public bool GetOpen()
        {
            return Opened;
        }

        public int GetSpeed()
        {
            return Speed;
        }

        public void Open(bool opened)
        {
            Opened = opened;
        }
    }
    class Wagon : IFillable, IAccelerable
    {
        public int FillLevel = 421;
        public int Speed = 412;
        private string _name = "Wagon";

        public Wagon() { }

        public Wagon(Wagon wagon)
        {
            this.FillLevel = wagon.FillLevel;
            this.Speed = wagon.Speed;
            this._name = wagon._name;
        }

        public string Name { get { return _name; } set { _name = value; } }

        public void ChangeFillLevel(int level)
        {
            FillLevel = level;
        }

        public void ChangeSpeed(int speed)
        {
            Speed = speed;
        }

        public int GetFillLevel()
        {
            return FillLevel;
        }

        public int GetSpeed()
        {
            return Speed;
        }
    }
    class Teddy : IToy
    {
        private string _name = "Teddy";

        public Teddy() { }

        public Teddy(Teddy teddy)
        {
            this._name = teddy._name;
        }

        public string Name { get { return _name; } set { _name = value; } }

    }
}
