using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace building_a_house
{
    abstract class Delevoper
    {
        public string Name { get; set; }

        public Delevoper(string a)
        {
            Name = a;
        }
        //Фабричный метод
        abstract public People Create();
    }


    class Worke_Delevoper : Delevoper
    {
        public Worke_Delevoper (string a) : base(a) { }

        public override People Create()
        {
            return new People_worke();
        }
       
    }
    class Team_Delevoper : Delevoper
    {
        public Team_Delevoper(string a) : base(a) { }

        public override People Create()
        {
            return new People_Team();
        }
    }

    abstract class People
    { }

    class People_worke : People { 
       
        public People_worke()
        {
            Console.WriteLine("Бригадир делает отчет");
        }
    }


    class People_Team : People
    {
        public People_Team()
        {
            Console.WriteLine("Тимлид делает отчет и сообщает заказчику");
        }
    }

}
