using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.session4
{


    public class DemoEvent
    {
        public object DemoDelegate { get; }

        public event StringToVoid Print;
        public event StringToVoid Action;
        public event StringToVoid Touch;
        public event StringToVoid Swipe;

        public DemoEvent()
        {
            Print += DemoDegegate.SayHello;
            Print += new DemoDegegate().ShowInfo;
        }

        public void Invoke()
        {
            Print("Hello world!");
        }
    }
}
/*		        public DemoEvent()
		{
			Print += DemoDelegate.SayHello;
			Print += new DemoDelegate().ShowInfo;
		}