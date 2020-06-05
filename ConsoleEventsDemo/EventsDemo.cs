using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEventsDemo
{
    public class EventsDemo
    {
        public delegate void delEventWrapper(string msg);

        //step 1 : Create event
        public event delEventWrapper evntWrapperforDelegate;
        public event EventHandler<string> evntEventHandler;

        public void OnDemoeventsfordelegatewrapper()
        {
            //step 2 : invoking event -- Publisher
            evntWrapperforDelegate?.Invoke("This message from event argument which is using delegate as wrapper.");
        }
    }
}
