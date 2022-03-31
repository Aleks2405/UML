using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace building_a_house
{
    interface IFinish
    {
        void Print();
    }

    class Finish : IFinish
    {
        public void Print()
        {
            Console.WriteLine("Стройка еще не завершена продолжаем");
        }
    }

    class Finish_Adapter : ICondition
    {
        Finish finish;

        public Finish_Adapter(Finish c)
        {
            finish = c;
        }

        public void condirion()
        {
            finish.Print();
        }
    }
   
}
