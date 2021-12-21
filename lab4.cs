using System;

    public class MyClassA
    {
        private int a;
        private int b;

		public MyClassA(int a, int b)
		{
			this.a = a;
			this.b = b;
		}	
		
		public int A 
		{
			get { return a; }
		}
			
		public int B
		{
			get { return b; }
		}
			
        public int C0
        {
            get { a *= b; return a; }
       }
       
       public int C1
       {
           get { return ++a; }
       }
       
       public int C2
       {
           get { return a/b; }
       }
 }


	public class MyClassB: MyClassA
	{
		int d;
		float[] array;
		int[] array2 = new int[] {2, 4, 6, 8, 10};
		
		public MyClassB(int a, int b, int d): base(a,b)
		{
			this.d = d;
		}
		
		public MyClassB(): this(3, 4, 16)
		{
			this.d = 16;
		}
		
		public MyClassB(int a): this(a, 2, -8)
		{
		this.d = -7;
		array = new float[A];
		for(int i = 0; i < A; i++)
		{
			array[i] = C3 * i;
		}
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
		
		public float[] Array
		{
			get { return array; }
		}
		
		public int[] Array2
		{
			get { return array2; }
		}
		
		public int this[int index]
		{
	   		get => array2[index];
	    	set => array2[index] = value;
		}
	}
    

	public class MyClassC<T>
	{
		public static string message = "This is static";
		private T[] arr = new T[5];
		public T this[int index]
		{
	    	get => arr[index];
	    	set => arr[index] = value;
		}
	}


    public class Program
    {
        
        public static void Main()
        {
			MyClassB ObjectB = new MyClassB(8);
			MyClassC<string> obj_str = new MyClassC<string>();
			MyClassC<int> obj_int = new MyClassC<int>();
				
			for (int i=0; i < ObjectB.Array2.Length; i++)
			{
				Console.WriteLine(ObjectB[i]);
			}
			
			for (int i=0; i<3; i++)
		{
		    obj_str[i] = Convert.ToString(i) + " number";
		}
		for (int i=0; i<3; i++)
		{
		    obj_int[i] = i;
		}
		Console.WriteLine(MyClassC<int>.message);
		Console.WriteLine("Массив строк");
		for (int i=0; i<3; i++)
		{
		    Console.WriteLine(obj_str[i]);
		}
		Console.WriteLine("Массив чисел");
		for (int i=0; i<3; i++)
		{
		    Console.WriteLine(obj_int[i]);
			}
		}
    }