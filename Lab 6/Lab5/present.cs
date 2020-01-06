using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class present 
    {
        
        public Goods[] bb= new Goods[5];
        int Count = 0;
        public void Add(Goods el)
        {
            bb[Count++] = el;
        }
    }
}
