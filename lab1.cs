using System;

    public class A
    {
        private float a = 3.4F;
        private float b = 4.3F;

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
    
    public class Program
    {
        
        public static void Main()
        {
            A Object = new A();
            Console.WriteLine(String.Format("C0: {0}\nC1: {1}\nC2: {2}\n", Object.C0, Object.C1, Object.C2));
        }
    }