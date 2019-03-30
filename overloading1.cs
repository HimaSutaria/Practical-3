using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Overloading
{
public class Summation
{
public int add(int a,int b){
return a+b;
}
public static Vectoradd(Vector v1,Vector v2)
{
Vector v = new Vector();
v.a = v1.a+v2.a;
v.b = v1.b+v2.b;
return v;
}
public static int[,]add(int[,] a, int[,] b)
{
int[,] s = new int[2,2];

for(int i=0;i<2;i++)
  {
	for(int j=0;j<2;j++)
	{
		s[i,j]=a[i,j]+b[i,j];
	}
 }
return s;
}
public static void Main(String[] args){
int n,n1,n2;
Vector v=new Vector();

Console.WriteLine("Enter Number 1:");
n1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Number 2:");
n2=Convert.ToInt32(Console.ReadLine());

n=n1+n2;

Console.WriteLine("Addition is:{0}",n);


Console.WriteLine("Enter Vector 1:");
n1=Convert.ToInt32(Console.ReadLine()); 
n2=Convert.ToInt32(Console.ReadLine());
Vector v1=new Vector(n1,n2);


Console.WriteLine("EnterVector2:"); 
n1=Convert.ToInt32(Console.ReadLine()); 
n2=Convert.ToInt32(Console.ReadLine());
Vector v2=new Vector(n1,n2);

v=add(v1,v2);

Console.WriteLine("Addition of vector:x={0},y={1}",v.a,v.b);

int[,] a=new int[,]{{11,22},{33,44}};
int[,] b=new int[,]{{55,66},{77,88}};

int[,] c=add(a,b);
Console.WriteLine("Addition of two matrics:"); 
for(int z=0;z<2;z++){
	for(int m=0;m<2;m++){
		Console.WriteLine("Addition:"+c[z,m]);	
	}
            }
Console.ReadKey();
}
}
public class Vector{
public int a,b;
public Vector(){}
public Vector(int a, int b)
{
this.a=a;
this.b=b;
}
}
}

