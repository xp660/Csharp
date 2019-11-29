   class Program
    {               
        static void Main(string[] args)
        {

            var e = new EventTest(5);
            e.SetValue(100);
            e.ChangeNum += new EventTest.NumManipulationHandler(EventTest.EventFired); //透過方法傳給委託然後綁定到event上面
            e.SetValue(200);
            

            I i = new MyClass();
            i.MyEvent += new MyDelegate(f);
            i.FireAway();

            
        }

        private static void f()
       
    }
------------------------------------------------------------------------------------
------------------------------------------------------------------------------------
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