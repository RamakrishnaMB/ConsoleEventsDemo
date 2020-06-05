using System;

namespace ConsoleEventsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            EventsDemo eventsDemo = new EventsDemo();
            //step 3 : consume event -- Subscriber
            eventsDemo.evntWrapperforDelegate += EventsDemo_evntWrapperforDelegate;
            eventsDemo.evntEventHandler += EventsDemo_evntEventHandler;
            eventsDemo.evntEventFromArguments += EventsDemo_evntEventFromArguments;


            eventsDemo.OnDemoeventsfordelegatewrapper();
            eventsDemo.OnDemoEventwithEventHandler();
            eventsDemo.OnShowoffWithArguments();
            // Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        private static void EventsDemo_evntEventFromArguments(object sender, Arguments e)
        {
            Console.WriteLine($"values inside the arguments are {e.Argument1} and {e.Argument2}");
        }

        private static void EventsDemo_evntEventHandler(object sender, string e)
        {
            Console.WriteLine(e);
        }

        private static void EventsDemo_evntWrapperforDelegate(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
