using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace building_a_house
{
    class Stages               /*реализация паттера хранитель*/
    {
        private int stages = 11;
        public void Shot()
        {
            if (stages > 1 && stages !=0)
            {
                stages--;
                Console.WriteLine("Этап сдан");
            } else
            {
                Console.WriteLine("Закончили стройку");
            }
        }
        public Stage_Memento Save()   
        {
            Console.WriteLine($"Остановились на данном этапе {stages} "); // сохранение состояния
            return new Stage_Memento(stages);
            
        }
        public void RestoreState(Stage_Memento stage_Memento) /*востановление состояния*/
        {
            this.stages = stage_Memento.Stag;

            Console.WriteLine($"Продолжаем с этапа {this.stages} ");

        }
    }
}
    class Stage_Memento
    {
        public int Stag { get; private set; }

        public Stage_Memento(int a)
    {
        this.Stag = a;
    }
    }

class Stage_Caretaker
{
    public Stack <Stage_Memento> History { get; private set; } 

    public Stage_Caretaker()
    {
        History = new Stack<Stage_Memento>();
    }
}

