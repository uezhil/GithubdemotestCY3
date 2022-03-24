using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    class Program
    {
        private static int a = 5, b = 10, c = 20;
        static void Main(string[] args)
        {
            Type testType = typeof(MyClass);
            ConstructorInfo ctor = testType.GetConstructor(System.Type.EmptyTypes);
            if (ctor != null)
            {
                object instance = ctor.Invoke(null);
                MethodInfo methodInfo = testType.GetMethod("Add");
                Console.WriteLine(methodInfo.Invoke(instance, new object[] { 10 }));
            }
            Console.ReadKey();

            MyClass cl = new MyClass();
            cl.ActorId = 1;
            cl.ActorName = "Rajni";

            Type type = typeof(MyClass);

            foreach (PropertyInfo pr in type.GetProperties())
            {
                string name = pr.Name;
                
                // Get value on the target instance.
                object value = pr.GetValue(cl, null);

                // Test value type.is 
                if (value is int)
                {
                    Console.WriteLine("Int: {0} = {1}", name, value);
                }
                else if (value is string)
                {
                    Console.WriteLine("String: {0} = {1}", name, value);
                }
            }
        

            reftype();
            refcheck();
            refassembly();
           
        }

        static void reftype()
        {
            Console.WriteLine("a + b + c = " + (a + b + c));
            Console.WriteLine("Please enter the name of the variable that you wish to change:");
            string varName = Console.ReadLine();
            Type t = typeof(Program);
            FieldInfo fieldInfo = t.GetField(varName, BindingFlags.NonPublic | BindingFlags.Static);
            if (fieldInfo != null)
            {
                Console.WriteLine("The current value of " + fieldInfo.Name + " is " + fieldInfo.GetValue(null) + ". You may enter a new value now:");
                string newValue = Console.ReadLine();
                int newInt;
                if (int.TryParse(newValue, out newInt))
                {
                    fieldInfo.SetValue(null, newInt);
                    Console.WriteLine("a + b + c = " + (a + b + c));
                }
                Console.ReadKey();
            }

        }


        static void refcheck()
        {
            string test = "test";
            Console.WriteLine(test.GetType().FullName);
            Console.WriteLine(typeof(Int32).FullName);
            Console.ReadKey();
        }

        static void refassembly()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] assemblyTypes = assembly.GetTypes();
            foreach (Type t in assemblyTypes)
                Console.WriteLine(t.Name);
            Console.ReadKey();
        }
        
    }
    
    class MyClass
    {
        private int num1 = 42;
        private string _ActorName;

        public int Add(int num2)
        {
            return this.num1 + num2;
        }
        public int ActorId { get; set; }
        public string ActorName
        {
            get
            {
                return _ActorName;
            }


            set
            {
                _ActorName = value;

            }
        }


        
    }


    class MyClass2
    {

    }
}
