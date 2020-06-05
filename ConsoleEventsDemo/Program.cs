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

            eventsDemo.OnDemoeventsfordelegatewrapper();
            // Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        private static void EventsDemo_evntWrapperforDelegate(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
