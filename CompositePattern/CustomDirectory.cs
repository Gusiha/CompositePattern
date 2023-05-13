using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class CustomDirectory : IComponent
    {
        private LinkedList<IComponent> children;

        public string Name { get;set; }

        public int Copy()
        {
            int value = 0;
            foreach (var item in children)
            {
                value += item.Copy();
            }
            return value;
        }

        public void Add(IComponent component)
        {
            children.AddLast(component);
        }

        public void Remove(IComponent component)
        {
            children.Remove(component);
        }

        public CustomDirectory(string name, params IComponent[] component)
        {
            children = new LinkedList<IComponent>();
            foreach (var item in children)
            {
                this.Add(item);
            }

            Name = name;
        }
    }
}
