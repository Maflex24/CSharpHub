using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHub.OverrideAndHidden
{
    public class BaseClass
    {
        public virtual void VirtualMethod()
        {
            Console.WriteLine("It's virtual method from base");
        }

        public void NonVirtualMethod()
        {
            Console.WriteLine("It's non virtual method from base class");
        }
    }
}
