using System;
namespace Open_Closed_Principle.ClassesandInterfaces
{
	public class Thor: ISuperHero
	{
		public Thor()
		{
		}

        void ISuperHero.attack()
        {
            Console.WriteLine("Thor is attacking...");
        }
    }
}

