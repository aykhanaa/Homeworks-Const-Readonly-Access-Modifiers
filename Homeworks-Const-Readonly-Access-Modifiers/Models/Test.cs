using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks_Const_Readonly_Access_Modifiers.Models
{
    internal class Test  : Car
    {
        public int bestSpeed;
        public Test():base(5)
        {
            bestSpeed = speed;
        }
    }
}
