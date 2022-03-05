using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public class Student
    
    {
    
    public	string name="Anjali";
    public	string Class="Sybca";
    }
    class exam:Student
    {
    	public void disp()
    	{
    		Console.WriteLine("Student information is==>"+name+" "+Class);
    	}
    
        public static void Main(string[] args)
        {
			exam n=new exam();
			n.disp();
        }
    }
}
