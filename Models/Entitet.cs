﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Entitet
    {
        public Entitet()
        {

        }

        public virtual string EntitetTyp()
        {
            return "Entitet";
        }
    }
}
