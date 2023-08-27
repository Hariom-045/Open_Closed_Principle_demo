using System;
namespace Open_Closed_Principle.Violation
{
	public class Attacker
	{
		public Attacker()
		{
		}
		public void attack(List<int> list)
		{
			ClassesandInterfaces.SuperHero superHero = new ClassesandInterfaces.SuperHero();
			for(int i=0;i<list.Capacity-1;i++)
			{
				if (list[i]==1)
				{
					superHero.attackWithCaptain();

				}
				else if (list[i]==2)
				{
					superHero.attackWithIronMan();

				}
				else if (list[i]==3)
				{
					superHero.attackWithThor();
				}
			}

		}

		

	}
}

