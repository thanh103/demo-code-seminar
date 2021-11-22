using System;
using System.Collections.Generic;
using System.Text;

namespace demo2
{
    public class WoodenHouse : HouseTemplate
    {
        protected override void BuildWall()
        {
            Console.WriteLine("Building wood wall");
        }
        protected override void BuildDoor()
        {
            Console.WriteLine("Building wood door");
        }
        protected override void BuildWindows()
        {
            Console.WriteLine("Building Wood Windows");
        }
        protected override void BuildRoof()
        {
            Console.WriteLine("Building Wood Roof");
        }
    }
}
