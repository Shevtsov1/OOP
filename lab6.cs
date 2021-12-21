using System;
using System.Collections.Generic;

public class Human
{
    private string lname;
    private int birth_year;
    private string status;
    
    public Human(string lname, int birth_year, string status)
    {
        this.lname = lname;
        this.birth_year = birth_year;
        this.status = status;
    }
    
    public Human(): this("unknown",0,"unknown")
    {
        this.lname = "unknown";
        this.birth_year = 0;
        this.status = "unknown";
    }
    
    public string Lname
    {
        get {return lname;}
        set {lname = value;}
    }
    
    public int Birth_year
    {
        get {return birth_year;}
        set {birth_year = value;}
    }
    
    public string Status
    {
        get {return status;}
        set {status = value;}
    }
    
    public void Person()
    {
        Console.WriteLine("Person:\n");
        Console.WriteLine("Фамилия: {0}\n", lname);
        Console.WriteLine("Год рождения: {0}\n", birth_year);
        Info();
        Console.WriteLine("Статус: {0}\n", status);
    }
    
    public virtual void Info()
    {
        DateTime d = DateTime.Now;
        Console.WriteLine("Возраст: {0}", (Convert.ToInt32(d.Year)-Birth_year));
    }
    
     public void About()
    {
        Console.WriteLine("Фамилия: {0}", Lname);
        Console.WriteLine("Год рождения: {0}", Birth_year);
        Info();
        Console.WriteLine("Статус: {0}", Status);
    }
}

public class Student: Human
{
    private int math_grade;
    private int phys_grade;
    private int hist_grade;
    
    public Student(string lname, int birth_year, string status, int math_grade, int phys_grade, int hist_grade)
    {
        this.math_grade = math_grade;
        this.phys_grade = phys_grade;
        this.hist_grade = hist_grade;
    }
    
    public int Math_grade
    {
        get {return math_grade;}
        set {math_grade = value;}
    }
    
    public int Phys_grade
    {
        get {return phys_grade;}
        set {phys_grade = value;}
    }
    
    public int Hist_grade
    {
        get {return hist_grade;}
        set {hist_grade = value;}
    }
    
    public float AvgGrade()
    {
        float sum = math_grade +
        phys_grade + hist_grade;
        float avg = sum/3;
        return avg;
    }
    
    public override void Info()
    {
        int[] grades = new int[] {math_grade, phys_grade, hist_grade}; 
        int max_grade = 0;
        for(int i =0; i<2; i++)
        {
          if(grades[i]>grades[i+1]) 
          max_grade = grades[i];
        }
        Console.WriteLine("Максимальная оценка: {0}", max_grade);
    }
}

class AgeSort: IComparer<Human>
{
    public int Compare(Human x, Human y)
    {
        if(x.Birth_year > y.Birth_year)
        {
            return 1; 
        }
        else if(x.Birth_year < y.Birth_year){
            return -1;
        }
        else return 0;
    }
}

class LnameSort: IComparer<Human>
{
    public int Compare(Human x, Human y)
    {
        if (Convert.ToInt32(x.Lname[0]) > Convert.ToInt32(y.Lname[0])) 
        {
            return 1;
        }
        else if (Convert.ToInt32(x.Lname[0]) < Convert.ToInt32(y.Lname[0]))
        {
            return -1;
        }
        else return 0;
    }
}

public class Program
{
	public static void Main()
	{
	     Human p1 = new Human("Атрощенко", 2004, "Студент");
	     Human p2 = new Human("Марченко", 2002, "Студент");
	     Human p3 = new Human("Соколов", 1990, "Преподаватель");
	     Human p4 = new Human("Шевцов", 2003, "Студент");
	     Human p5 = new Human("Белоус", 2001, "Студент");
	     Human[] people = new Human[] {p1, p2, p3, p4, p5};
	     
	     Array.Sort(people, new AgeSort());
	     foreach(Human p in people)
	     {
	         Console.WriteLine("{0} - {1}", p.Lname, p.Birth_year);
	     }
	     
	     Array.Sort(people, new LnameSort());
	     foreach(Human p in people)
	     {
	        Console.WriteLine("{0} - {1}", p.Lname, p.Birth_year);
	     }
	     foreach(Human p in people)
	     {
	        p.About();
	     }
	}
}