using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{

    //public delegate void ChangedEventHandler(object sender, EventArgs e); 

    class Program
    {               
        static void Main(string[] args)
        {

            var e = new EventTest(5);
            e.SetValue(100);
            e.ChangeNum += new EventTest.NumManipulationHandler(EventTest.EventFired); //透過方法傳給委託然後綁定到event上面
            e.SetValue(200);
            e.SetValue(100);
            e.SetValue(200);
            e.SetValue(100);

            I i = new MyClass();
            i.MyEvent += new MyDelegate(f);
            i.FireAway();

            Console.ReadLine();
        }

        private static void f()
        {
            Console.WriteLine("this is called where the event fired");
        }

    }

    class EventTest
    {
        private int value;
        public delegate void NumManipulationHandler();
        public event NumManipulationHandler ChangeNum;

        public EventTest(int n) //構造函數 設定初始值
        {
            SetValue(n);
        }

        public static void EventFired()
        {
            Console.WriteLine("Binded Event fired");
        }

        protected virtual void OnNumChanged() //當數字變動時 調用此方法
        {
            if (ChangeNum != null) //event首先會去delegate查找是否有委託綁定上去
            {
                ChangeNum();
            }
            else
            {
                Console.WriteLine("Event fired");
            }
        }

        public void SetValue(int n)
        {
            if (value != n)
            {
                value = n;
                OnNumChanged();
            }

        }



    }


    public delegate void MyDelegate();
    public interface I
    {
        event MyDelegate MyEvent;
      //event EventHandler MyGuidineEvent;
        void FireAway();
    }

    public class MyClass:I
    {
        public event MyDelegate MyEvent;

        public void FireAway()
        {
            if(MyEvent != null)
            {
                MyEvent();
            }
        }
    }
}
