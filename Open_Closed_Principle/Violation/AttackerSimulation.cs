using System;
namespace Open_Closed_Principle.Violation
{
	public class AttackerSimulation
	{
		public AttackerSimulation()
		{
		}


		public void attack(List<ClassesandInterfaces.ISuperHero> superHeroes)
		{
			for(int i=0;i<superHeroes.Count;i++)
			{
				superHeroes[i].attack();
			}
			
		}

	}
}

