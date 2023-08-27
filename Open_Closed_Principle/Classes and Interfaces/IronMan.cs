using System;
namespace Open_Closed_Principle.ClassesandInterfaces
{
	public class IronMan : ISuperHero
	{
		public IronMan()
		{
		}

        void ISuperHero.attack()
        {
            Console.WriteLine("Iron man is attacking...");
        }
    }
}

