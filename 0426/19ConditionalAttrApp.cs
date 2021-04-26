using System;
using System.Linq;
using System.Diagnostics;





namespace Shape
{

	class ConditionalAttr
	{
		[Conditional("CSHARP")]
		public static void CsharpMethod()
		{
			Console.WriteLine("In the CSharp Method ...");
		}
		[Conditional("JAVA")]
		public static void JavaMethod()
		{
			Console.WriteLine("In the Java Method ...");
		}
	}
	class Program
	{
		public static void Main()
		{
			ConditionalAttr.CsharpMethod();
			ConditionalAttr.JavaMethod();
		}
	}
}