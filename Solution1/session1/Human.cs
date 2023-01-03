using System;
namespace Solution1.session1
{
	public class Human
	{
		public Human(){ }
		public string name;
		public int age;
		public int height;
		public int weight;

		public void Eat()
		{
			Console.WriteLine("Eating " + name);
		}

		public void Drink()
		{
			Console.WriteLine(this.name + " is a " + age + " years old");
		}
	}
}

