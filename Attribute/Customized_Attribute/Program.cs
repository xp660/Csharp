
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customized_Attribute
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            HelpAttribute helpAttribute;

            foreach(var attr in typeof(AnyClass).GetCustomAttributes(true))
            {
                helpAttribute = attr as HelpAttribute;
                if(helpAttribute != null)
                {
                    Console.WriteLine("AnyClass Description: {0}", helpAttribute.Description);
                }
            }
            Console.ReadLine();
        }
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple =false ,Inherited =false)]
    public class HelpAttribute:Attribute
    {
        protected string description;

            public HelpAttribute(string description_in)
            {
                 this.description = description_in;
            }
            
            public string Description  //property
            {
                 get
                 {
                    return description;
                 }
            }

            public string Name
            {
                get;
                set;
            }
    }

    //value type, System.Type, object, enum
    [Help("this is a do-nothing class", Name ="cft6yHNJMK")]
    public class AnyClass
    {
        
    }

}
