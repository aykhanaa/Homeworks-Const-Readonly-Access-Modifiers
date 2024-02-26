using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks_Const_Readonly_Access_Modifiers.Models
{
    internal class Car
    {
        private string name;
        public string color;
        protected int speed=900;

        private Car()
        {
            Console.WriteLine("Resad bey  bu da sizin ucun private contructor");
        }
        public Car(int a) : this() 
        {
            
        }
    }
}
