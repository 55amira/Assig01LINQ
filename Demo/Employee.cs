﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee
    {
        public int Id{ get; set; }
        public string Name{ get; set; }
        public dynamic Slaray{ get; set; }

        public override string ToString()
        {
            return $" id : {Id}, Name:{Name}, Slaray:{Slaray}";
        }
    }
}
