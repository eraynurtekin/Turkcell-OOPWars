using System;
using System.Collections.Generic;
using System.Linq;

namespace CivilizationOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            showAndSelectYourNationality();

            getSoldierProperties();

            chooseAttackType();
     
        }

        public static void showAndSelectYourNationality()
        {
            Console.WriteLine("Please Choose Your Nationality");
            Console.WriteLine("Turkey = 1, India = 2, China = 3, Ancient_Greece = 4, Aztecs = 5, German = 6");
            int button = Convert.ToInt32(Console.ReadLine());
            switch (button)
            {
                case 1:
                    var country1 = Countries.Turkey;
                    Console.WriteLine($"You chosen {country1}");
                    break;
                case 2:
                    var country2 = Countries.India;
                    Console.WriteLine($"You chosen {country2}");
                    break;
                case 3:
                    var country3 = Countries.China;
                    Console.WriteLine($"You chosen {country3}");
                    break;
                case 4:
                    var country4 = Countries.Ancient_Greece;
                    Console.WriteLine($"You chosen {country4}");
                    break;
                case 5:
                    var country5 = Countries.Aztecs;
                    Console.WriteLine($"You chosen {country5}");
                    break;
                case 6:
                    var country6 = Countries.German;
                    Console.WriteLine($"You chosen {country6}");
                    break;
                default:
                    break;
            }


        }
        private static void chooseAttackType()
        {
            Console.WriteLine("Please choose your attack type.");
            Console.WriteLine("Type (1): Warrior (vs) Archer + Horseman");
            Console.WriteLine("Type (2): Warrior + Archer (vs) Horseman");
            Console.WriteLine("Type (3): 2 Warrior + Archer (vs) Archer + Horseman");

            int type=Convert.ToInt32(Console.ReadLine());
          
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
        private static void attackType1()
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
        private static void attackType2()
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
        private static void attackType3()
        {
            Warrior warrior = new Warrior();

            Archer archer = new Archer();

            Horseman horseman = new Horseman();


            if (2*warrior.TotalPower() + archer.TotalPower() > archer.TotalPower() + horseman.TotalPower())
            {
                Console.WriteLine("2 Warriors and Archer won");
            }
            else
            {
                Console.WriteLine("Horseman and Archer won.");
            }
        }

        public static void getSoldierProperties()
        {
            
                Console.WriteLine("Do you want to see your soldiers properties ? (YES=1) / (NO=2)");
                int button = Convert.ToInt32(Console.ReadLine());
                switch (button)
                {
                    case 1:
                        selectChooseSoldier();
                        break;
                    case 2:
                        Console.WriteLine("You signed out!");
                        break;
                    default:
                        break;
                } 
            

        }

        private static void selectChooseSoldier()
        {
            Console.WriteLine("Choose Your Type of Soldier ((Warrior=1),(Archer=2),(Horseman=3)");
            int button = Convert.ToInt32(Console.ReadLine());

            switch (button)
            {
                case 1:
                    getWarriorSoldierProperty();
                    break;
                case 2:
                    getArcherSoldierProperty();
                    break;
                case 3:
                    getHorsemanSoldierProperty();
                    break;
                default:
                    break;
            }
        }

        public static void getWarriorSoldierProperty()
        {
            Player player = new Player();

            player.Soldiers = new Warrior();

            player.Soldiers.Hit();
            player.Soldiers.MotionCapability();
            player.Soldiers.TotalPower();
        }
        public static void getArcherSoldierProperty()
        {
            Player player = new Player();

            player.Soldiers = new Archer();

            player.Soldiers.Hit();
            player.Soldiers.MotionCapability();
            player.Soldiers.TotalPower();
        }
        public static void getHorsemanSoldierProperty()
        {
            Player player = new Player();

            player.Soldiers = new Horseman();

            player.Soldiers.Hit();
            player.Soldiers.MotionCapability();
            player.Soldiers.TotalPower();
        }

    }
}
