using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace CustomAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            func1();
            MyClass cls = new MyClass();
            cls.func2();

        }
        //function - method
        [Custom(CustomMetaInfo ="This is my function - func1")]
        static void func1()
        {
            
        }
    }
    //Class
    //[System.Serializable]
    class MyClass
    {
        //Properties
        [Custom(CustomMetaInfo ="Here goes my prop")]
        public int MyProperty { get; set; }
        [Obsolete("This is old..",false)]
        public void func2()
        {

        }
    }

    //Interface
    
    interface IInterface
    {

    }

}
