using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities
{
    public abstract class Bird
    {
        public string Name { get; private set; }
        public string Color { get; private set; }

        public Bird(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public abstract void Speak();
       
        public virtual void Fly()
        {
            Console.WriteLine("Hi there! I can fly.");
        }
    }

}
