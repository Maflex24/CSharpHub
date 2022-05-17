using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHub.OverrideAndHidden
{
    public class InheritClass : BaseClass
    {
        public override void VirtualMethod()
        {
            Console.WriteLine("It's virtual method in inherit class, by override");
        }
        public new void NonVirtualMethod()
        {
            Console.WriteLine("It's non virtual method from inherit class, it's hided");
        }
    }
}
