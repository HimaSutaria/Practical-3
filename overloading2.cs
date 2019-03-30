using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Overloading
{
public class Student
{
string name,enrollment,branch;

public Student(string name)
{
this.name=name;
Console.WriteLine(“First Constructor”);
}

public Student(string name,string enrollment)
{
this.name=name;
this.enrollment=enrollment;
Console.WriteLine(“Second Constructor”);
}

public Student(string name,string enrollment,string branch)
{
this.name=name;
this.enrollment=enrollment;
this.branch=branch;
Console.WriteLine(“Third Constructor”);
}

public static void Main(String[] args)
{
Student s1=new Student("ALEXA");
Student s2=new Student("ALEXA","BE16ce011");
Student s3=new Student("ALEXA","BE16ce011","COMPUTER");
}
}
}
