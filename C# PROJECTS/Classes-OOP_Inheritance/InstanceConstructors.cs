using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes_OOP_Inheritance
{
    public class InstanceConstructors
    {
        protected double x, y;

        // Each class will be able to inherit the "template" of the constructor, but will have to define it's own specific constructor
        public InstanceConstructors(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class InheritClass : InstanceConstructors
    {
        public InheritClass(double radius)
        : base(radius, 0)
        {  }
    }
}