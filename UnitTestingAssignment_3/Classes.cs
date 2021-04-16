using System;
using System.Collections.Generic;

namespace UnitTestingAssignment_3
{
    public class Wheel
    {
        private string brand;
        private string name;
        private int radius;
        private int width;

        public Wheel(string brand, string name, int radius, int width)
        {
            this.brand = brand;
            this.name = name;
            this.radius = radius;
            this.width = width;
        }

        public string GetBrand()
        {
            return brand;
        }
        public void SetBrand(string brand)
        {
            this.brand = brand;
        }

        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetRadius()
        {
            return radius;
        }
        public void SetRadius(int radius)
        {
            this.radius = radius;
        }

        public int GetWidth()
        {
            return width;
        }
        public void SetWidth(int width)
        {
            this.width = width;
        }
    }

    public class Frame
    {
        private string brand;
        private string name;
        private string material;

        public Frame(string brand, string name, string material)
        {
            this.brand = brand;
            this.name = name;
            this.material = material;
        }

        public string GetBrand()
        {
            return brand;
        }
        public void SetBrand(string brand)
        {
            this.brand = brand;
        }

        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetMaterial()
        {
            return material;
        }
        public void SetMaterial(string material)
        {
            this.material = material;
        }

    }

    public class Bicycle
    {
        private Wheel[] wheels;
        private Frame frame;
        private bool electric;
        private double price;

        public Bicycle(Wheel[] wheels, Frame frame, bool electric, double price)
        {
            this.wheels = wheels;
            this.frame = frame;
            this.electric = electric;
            this.price = price;
        }

        public Wheel[] GetWheels()
        {
            return wheels;
        }
        public Frame GetFrame()
        {
            return frame;
        }
        public bool GetElectric()
        {
            return electric;
        }
        public double GetPrice()
        {
            return price;
        }

        public void SetWheels(Wheel[] wheels)
        {
            this.wheels = wheels;
        }
        public void SetFrame(Frame frame)
        {
            this.frame = frame;
        }
        public void SetElectric(bool electric)
        {
            this.electric = electric;
        }
        public void SetPrice(double price)
        {
            this.price = price;
        }
    }

    public class Inventory
    {
        private List<Bicycle> bicycles;

        public Inventory(List<Bicycle> bicycles)
        {
            this.bicycles = bicycles;
        }

        public List<Bicycle> GetBicycles()
        {
            return bicycles;
        }
        public void AddBicycle(Bicycle bicycle)
        {
            this.bicycles.Add(bicycle);
        }

        public void SetBicycle(int index, Bicycle bicycle)
        {
            this.bicycles[index] = bicycle;
        }
        public void DelBicycle(Bicycle bicycle)
        {
            this.bicycles.Remove(bicycle);
        }
    }
}
