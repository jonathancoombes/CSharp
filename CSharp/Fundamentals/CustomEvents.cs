using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Fundamentals
{
    class CustomEvents
    {

        // Console App Sample Code
        // - Start
        // Instantiating Instance of each Class

        //EventPub EP = new EventPub();
        //EventSub ES = new EventSub();

        // Registering the event to the event handler

        //EP.valueReceivedHandler += ES.OnValueReceivedEventHandler;
            
        // Calling function that triggers event

        //EP.ValueReceived("The result is: ", 100);

        //Console.ReadLine();

        // - END


            public class EventPub
            {
                public EventHandler<CustomEventArgs> valueReceivedHandler;

                public void ValueReceived(string mess, int val)
                {
                    valueReceivedHandler(this, new CustomEventArgs(mess, val));
                }
            }

            public class EventSub
            {

                public void OnValueReceivedEventHandler(object sender, CustomEventArgs e)
                {
                    Console.WriteLine(e.ResultMessage + e.Value);
                }

            }

            public class CustomEventArgs : EventArgs
            {
                public string ResultMessage { get; set; }
                public int Value { get; set; }

                public CustomEventArgs(string finalMessage, int finalValue)
                {
                    ResultMessage = finalMessage;
                    Value = finalValue;
                }


            }

    }
}
