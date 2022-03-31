using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace building_a_house
{
    class Part :IPart
    {
        public string Name { get; } = "Part";

        public override string ToString()
        {
            return $"{Name}";
        }
        public void Stage(ICondition con)
        {
            con.condirion();
        }

    }
}
