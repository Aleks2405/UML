using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace building_a_house
{
    interface ICondition
    {
        void condirion();
    }
    class Condition : ICondition // НАЧИНАЕМ СТРОЙКУ
    {
        public void condirion()
        {
            Console.WriteLine("постороили этап");
        }
    }
}
