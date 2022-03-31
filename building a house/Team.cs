using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace building_a_house
{
    class Team    
    {
       
        public Team()
        {
            Stages stages = new Stages();
            

            Basement basement = new Basement();   // то что должны постороить
            Condition stroika = new Condition();  // начинаем стройку
            basement.Stage(stroika);        // построили этап
            Console.WriteLine(basement.ToString());
            Finish finish = new Finish();   //закончили этап
            ICondition con = new Finish_Adapter(finish); // применяем адаптер (структурные паттерны)
            stages.Shot();  // делаем этап
           /* basement.Stage(con);*/ // продолжаем строить 

            
            Stage_Caretaker stage_Caretaker = new Stage_Caretaker(); /*реализация паттера хранитель*/
            stage_Caretaker.History.Push(stages.Save());    // запоминаем результат
            stages.RestoreState(stage_Caretaker.History.Pop());
            stage_Caretaker.History.Push(stages.Save());


            Console.WriteLine();
            
            
            Walls walls = new Walls();
            walls.Stage(stroika);               // аналогично чтобы показать что паттер применяется
            Console.WriteLine(walls);
            stages.Shot();  // делаем этап
            walls.Stage(con);
           

            Console.WriteLine();

            Walls walls1 = new Walls();
            walls1.Stage(stroika);               
            Console.WriteLine(walls1);
            stages.Shot();
            walls1.Stage(con);
            
           
            stage_Caretaker.History.Push(stages.Save());    // запоминаем результат
            stages.RestoreState(stage_Caretaker.History.Pop());
            stage_Caretaker.History.Push(stages.Save());

            Console.WriteLine();

            Walls walls2 = new Walls();
            walls2.Stage(stroika);
            Console.WriteLine(walls2);
            stages.Shot();
            walls2.Stage(con);
            

            Console.WriteLine();

            Walls walls3 = new Walls();
            walls3.Stage(stroika);
            Console.WriteLine(walls3);
            stages.Shot();
            walls3.Stage(con);
          

            stage_Caretaker.History.Push(stages.Save());    // запоминаем результат
            stages.RestoreState(stage_Caretaker.History.Pop());
            stage_Caretaker.History.Push(stages.Save());

            Console.WriteLine();
            Door door = new Door();
            door.Stage(stroika);
            Console.WriteLine(door);
            stages.Shot();
            door.Stage(con);
           

            Console.WriteLine();
            Window window = new Window();
            window.Stage(stroika);
            Console.WriteLine(window);
            stages.Shot();
            window.Stage(con);
           

            stage_Caretaker.History.Push(stages.Save());    // запоминаем результат
            stages.RestoreState(stage_Caretaker.History.Pop());
            stage_Caretaker.History.Push(stages.Save());
            Console.WriteLine();

            Window window1 = new Window();        
            window1.Stage(stroika);           
            Console.WriteLine(window1);
            stages.Shot();
            window1.Stage(con);

            Console.WriteLine();
            Window window2 = new Window();
            window2.Stage(stroika);
            Console.WriteLine(window2);
            stages.Shot();
            window2.Stage(con);

            Console.WriteLine();
            Window window3 = new Window();
            window3.Stage(stroika);
            Console.WriteLine(window3);
            stages.Shot();
            window3.Stage(con);
            stage_Caretaker.History.Push(stages.Save());    // запоминаем результат
            stages.RestoreState(stage_Caretaker.History.Pop());
            stage_Caretaker.History.Push(stages.Save());

            Console.WriteLine();

            Part part = new Part();
            part.Stage(stroika);
            Console.WriteLine(part);
            stages.Shot();
           
            

          
            Delevoper people1 = new Worke_Delevoper("Бригадир");
            People sostavil = people1.Create();                             //реализация порождающего паттера (фабричный метод)
                                                                   
            people1 = new Team_Delevoper("Тимлид");
            People sostavi2 = people1.Create();


        }
    }
}
