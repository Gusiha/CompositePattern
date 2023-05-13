using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class Client
    {
        public CustomDirectory directory;

        public Client(CustomDirectory directory)
        {
            this.directory = directory;
        }

        public void Add(IComponent component)
        {
            directory.Add(component);
        } 

        public void Remove(IComponent component)
        {
            directory.Remove(component);
        }

        public void GetValue()
        {
            Console.WriteLine(directory.Copy()); 
        }

    }
}
