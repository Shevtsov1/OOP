using System;

    public class MyClassA
    {
        private float a;
        private float b;

		public MyClassA(float a, float b)
		{
			this.a = a;
			this.b = b;
		}	
		
		public float A 
		{
			get { return a; }
		}
			
		public float B
		{
			get { return b; }
		}
			
        public float C0
        {
            get { a *= b; return a; }
       }
       
       public float C1
       {
           get { return ++a; }
       }
       
       public float C2
       {
           get { return a/b; }
       }
 }


	public class MyClassB: MyClassA
	{
		float d;
		public MyClassB(float a, float b, float d): base(a,b)
		{
			this.d = d;
		}
		
		public MyClassB(): this(3.14F, 4.24F, 16.42F)
		{
			this.d = 16.42F;
		}
		
		public float D
		{
			get { return d; }
		}
		
		public float C3
		{
			get {
			for(int i=0; i<5; i++)
			{
				d += 1;
			}
			return d;
			}
		}
	}
    

    public class Program
    {
        
        public static void Main()
        {
            MyClassA ObjectA = new MyClassA(6.37F, 14.84F);
		
			MyClassB ObjectB1 = new MyClassB();
			MyClassB ObjectB2 = new MyClassB(3.5F, 5.7F, 1.2F);
            Console.WriteLine("ObjectB1: A: {0}\tB: {1}\tC: {2}\n", ObjectB1.A,ObjectB1.B, ObjectB1.D);
			Console.WriteLine("ObjectB2: A: {0}\tB: {1}\tC: {2}\n", ObjectB2.A,ObjectB2.B, ObjectB2.D);
			Console.WriteLine("ObjectA:\n C0: {0}\tC1: {1}\tC2: {2}\n", ObjectA.C0, ObjectA.C1, ObjectA.C2);
			Console.WriteLine("ObjectB1:\n C0: {0}\tC1: {1}\tC2: {2}\n", ObjectB1.C0, ObjectB1.C1, ObjectB1.C2);
			Console.WriteLine("ObjectB2:\n C0: {0}\tC1: {1}\tC2: {2}\n", ObjectB2.C0, ObjectB2.C1, ObjectB2.C2);
        }
    }