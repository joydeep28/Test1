﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   interface Interface1
    {
        int test4();
        //int test1();

    }

    interface Interface2: Interface1
    {
       int test4();
       
    }

}
