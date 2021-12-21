using System;
	public class MyClassB
	{
		private int a;
		private int b;
		public MyClassB(int a, int b)
		{
		    this.a = a;
		    this.b = b;
		}
		
		public static bool operator true(MyClassB obj)
		{
		    return (obj.a<0 && obj.b>0);
		}
		
		public static bool operator false(MyClassB obj)
		{
		    return (obj.a>0 || obj.b>0);
		}
		
		public static bool operator !(MyClassB obj)
		{
		    if(obj)
		    {
		        return false;
		    }
		    else
		    {
		        return true;
		    }
		}
	}
    

    public class Program
    {
        public static void Main()
        {
            MyClassB testObj1 = new MyClassB(3,8);
            if(testObj1)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            if(!testObj1)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            
            MyClassB testObj2 = new MyClassB (3, -6);
            if(testObj2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            if(!testObj2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }