using System;
using System.Collections.Generic;
using System.Text;

namespace demo2
{
    public abstract class HouseTemplate
    {
        // Template method defines the sequence for building a house
        public void BuildHouse()
        {
            BuildWall();
            BuildDoor();
            BuildWindows();
            BuildRoof();
            Console.WriteLine("House is built");
        }
        // Methods to be implemented by subclasses
        protected abstract void BuildWall();
        protected abstract void BuildDoor();
        protected abstract void BuildWindows();
        protected abstract void BuildRoof();
    }
}
