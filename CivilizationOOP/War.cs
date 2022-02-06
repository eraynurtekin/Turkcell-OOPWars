using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilizationOOP
{
    public class War
    {
        public string Name { get; set; }

        public static void chooseAttackType()
        {
            Console.WriteLine("Please choose your attack type.");
            Console.WriteLine("Type (1): Warrior (vs) Archer + Horseman");
            Console.WriteLine("Type (2): Warrior + Archer (vs) Horseman");
            Console.WriteLine("Type (3): 2 Warrior + Archer (vs) Archer + Horseman");

            int type = Convert.ToInt32(Console.ReadLine());

            switch (type)
            {
                case 1:
                    attackType1();
                    break;
                case 2:
                    attackType2();
                    break;
                case 3:
                    attackType3();
                    break;
            }


        }
        public static void attackType1()
        {

            Warrior warrior = new Warrior();

            Archer archer = new Archer();

            Horseman horseman = new Horseman();


            if (warrior.TotalPower() > archer.TotalPower() + horseman.TotalPower())
            {
                Console.WriteLine("Warrior Won.");
            }
            else
            {
                Console.WriteLine("Archer and Horseman won.");
            }

        }
        public static void attackType2()
        {
            Warrior warrior = new Warrior();

            Archer archer = new Archer();

            Horseman horseman = new Horseman();


            if (warrior.TotalPower() + archer.TotalPower() > horseman.TotalPower())
            {
                Console.WriteLine("Warrior and Archer Won.");
            }
            else
            {
                Console.WriteLine("Horseman won.");
            }
        }
        public static void attackType3()
        {
            Warrior warrior = new Warrior();

            Archer archer = new Archer();

            Horseman horseman = new Horseman();


            if (2 * warrior.TotalPower() + archer.TotalPower() > archer.TotalPower() + horseman.TotalPower())
            {
                Console.WriteLine("2 Warriors and Archer won");
            }
            else
            {
                Console.WriteLine("Horseman and Archer won.");
            }
        }

    }
}
