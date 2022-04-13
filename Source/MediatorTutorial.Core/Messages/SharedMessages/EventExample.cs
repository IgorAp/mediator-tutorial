using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTutorial.Core.Messages.SharedMessages
{
    public class EventExample : Event
    {
        public string MyProperty { get; private set; }

        public EventExample(string myProperty)
        {
            MyProperty = myProperty;
        }
    }
}
