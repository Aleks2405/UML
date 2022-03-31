using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace building_a_house
{
   public interface IPart
    {
        string Name { get; }

        public virtual string ToString()
        {
            return $"{Name}";
        }


    }
}
