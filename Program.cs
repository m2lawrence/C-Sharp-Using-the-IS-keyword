// Using the is Keyword with Classes — Class Conversions.

// C# has the is keyword, it's used to do a comparison to see whether an object is of a certain type.
//(expression is type)
//Here, expression evaluates to a reference type and "type" is a valid "type". Generally, type will be a class type.

//If expression is compatible with type, this returns true. If expression is not compatible with type, false is returned.
using System;

namespace isList
{
	class Person
	{
		protected string Name;
		
		public Person() {}
		
		public Person(string n)
		{
			Name = n;
		}
		
		public virtual void displayFullName()
		{
			Console.WriteLine("Name: {0}", Name);
		}
	}
	
	//class derives from base class, means: Employee class derives from Person class.
	class Employee : Person
	{
		public Employee() : base() {}
		
		public Employee(string n) : base(n) {}
		
		public override void displayFullName()
		{
			Console.WriteLine("Employee: {0}", Name);
		}
	}
	
	class IsApp
	{
		public static void Main()
		{
			//Three variables are declared below.
			Person pers = new Person();
			Object emp = new Employee();
			string str = "String";
			
			// The first, pers, is a Person that is assigned a Person. The second, emp, is of type Object and is assigned an Employee type. 
			// As you LISTING 10.9 continued OUTPUT ANALYSIS learned earlier, you can assign a type to any of its base types. 
			// This means that an Employee can be assigned to an Object type, a Person type, or an Employee type. Then a string is declared.
			
			if (pers is Person) 
				Console.WriteLine("pers is a Person");
			else
				Console.WriteLine("pers is NOT a Person");
			
			if (pers is Object) 
				Console.WriteLine("pers is an Object");
			else
				Console.WriteLine("pers is NOT an Object");
			
			if (pers is Employee) 
				Console.WriteLine("pers is an Employee");
			else
				Console.WriteLine("pers is NOT an Employee");
			
			if (emp is Person) 
				Console.WriteLine("emp is a Person");
			else
				Console.WriteLine("emp is NOT a Person");
			
			if (str is Person) 
				Console.WriteLine("str is a Person");
			else
				Console.WriteLine("str is NOT a Person");
			
			Console.ReadKey(true); //pause.
		}
	}
}
// The pers variable is an Object and a Person. The emp variable is an Employee, a Person, and an Object. 