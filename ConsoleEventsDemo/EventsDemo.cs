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
        public event EventHandler<Arguments> evntEventFromArguments;

        public void OnDemoeventsfordelegatewrapper()
        {
            //step 2 : invoking event -- Publisher
            evntWrapperforDelegate?.Invoke("This message from event argument which is using delegate as wrapper.");
        }

      
        public void OnDemoEventwithEventHandler()
        {
            //step 2 : invoking event -- Publisher
            evntEventHandler?.Invoke(this, "string argument from OnDemoEventwithEventHandler");
        }

        public void OnShowoffWithArguments()
        {
            var arguments = new Arguments { Argument1 = "arg1 demo", Argument2 = "arg2 demo" };
            //step 2 : invoking event -- Publisher
            evntEventFromArguments?.Invoke(this, arguments);
        }
    }
}
