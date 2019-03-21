using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEvent
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            EventClass eventClass = new EventClass();
            eventClass.ThaiEvent += EventClass_ThaiEvent;

            while (Console.ReadKey(true).KeyChar == 'a')
            eventClass.ThaiMethod();
            Console.ReadLine();
        }

        private static void EventClass_ThaiEvent(object sender, ThaiEventArg e)
        {
            Console.WriteLine(e.Name + "    " + e.Number);
        }
    }

    class EventClass
    {
        public event EventHandler<ThaiEventArg> ThaiEvent;
        public void ThaiMethod()
        {
            EventClass eventClass = new EventClass();
            ThaiEventArg thaiEventArg = new ThaiEventArg();
            thaiEventArg.Name = "Thai";
            thaiEventArg.Number = 10;
            ThaiEvent(eventClass, thaiEventArg);
        }
    }

    class ThaiEventArg : EventArgs
    {
        public string Name { get; set; }
        public int Number { get; set; }
    }
}
