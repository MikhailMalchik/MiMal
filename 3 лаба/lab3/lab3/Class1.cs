using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    

    public class NewClass : System.Object
    {
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            return base.Equals(obj);
        }

       
    }


}
