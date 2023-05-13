using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class CustomFile : IComponent
    {
        private readonly int _value;

        public string Name { get; set; }

        public int Copy()
        {
            return _value;
        }

        public CustomFile(int value, string name)
        {
            Name = name;
            _value = value;
        }
    }
}
