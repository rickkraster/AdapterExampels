﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPaternBook
{
    class TurkeyAdapter : IDuck
    {
        ITurkey turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }

        public void Fly()
        {
            for(int i = 0; i< 5; i++)
            {
                turkey.Fly();
            }
            
        }

        public void Quack()
        {
            turkey.Gobble();
        }
    }
}
