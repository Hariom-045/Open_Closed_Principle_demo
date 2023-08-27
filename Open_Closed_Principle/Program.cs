// See https://aka.ms/new-console-template for more information

namespace Open_Closed_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            Violation.Attacker attacker = new Violation.Attacker();
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            //sattacker.attack(list);
            //Now if we add another superhero in superhero class then we have to modify the list
            //also we have to modify the attack function in attacker class.

            // To avoid this we can make a interface name superhero and only declare a attack
            //function there and make all superhero classes different from each other which will
            //implement the interface and override the method present in IF. So now dependency will
            //be reverted and our problem is solved.

            List<ClassesandInterfaces.ISuperHero> superHeroes = new List<ClassesandInterfaces.ISuperHero>();
            superHeroes.Add(new ClassesandInterfaces.IronMan());
            superHeroes.Add(new ClassesandInterfaces.CaptainAmerica());
            superHeroes.Add(new ClassesandInterfaces.Thor());


            Violation.AttackerSimulation attackerSimulation = new Violation.AttackerSimulation();
            attackerSimulation.attack(superHeroes);



        }
    }
}

