using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestComponent1
{
    public class MyShape
    {
        public string Name { get; private set; }

        public MyShape(string name)
        {
            Name = name;
        }

        public bool ChangeName(string newName)
        {
            if (newName == Name)
                return false;

            Name = newName;
            return true;
        }
    }
}
