using System;
using System.Collections.Generic;
using System.Text;

namespace demo2
{
    public class ConcreteHouse : HouseTemplate
    {
        protected override void BuildWall()
        {
            Console.WriteLine("Building Concrete wall");
        }
        protected override void BuildDoor()
        {
            Console.WriteLine("Building iron door");
        }
        protected override void BuildWindows()
        {
            Console.WriteLine("Building glass windows");
        }
        protected override void BuildRoof()
        {
            Console.WriteLine("Building iron roof ");
        }
    }
}
