﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal interface IComponent
    {
        public string Name { get; set; }

        public int Copy();

    }
}
