using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilizationOOP
{
    public abstract class Soldiers
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Health { get; set; } = 100;
        public abstract void MotionCapability();
        public abstract void Hit();
        public abstract int TotalPower();
        
    }

    public class Warrior : Soldiers,ISoldierProperties
    {

        int totalPower = 0;

        public int StrikePower { get; } = 4;
        public int Motion { get; } = 2;
     
        public override void Hit()
        {
            
            Console.WriteLine($"Warrior Strike Power: {StrikePower}");
        }

        public override void MotionCapability()
        {
            Console.WriteLine($"Warrior Motion Capability: {Motion}");
        }
        public override int TotalPower()
        {
            totalPower = ((StrikePower * Motion) * Health) / 2;
            Console.WriteLine($"Warrior Total Power: {totalPower}");
            return totalPower;
           
        }
    }
    public class Archer : Soldiers,ISoldierProperties
    {
        
        int totalPower = 0;
        public int StrikePower { get; } = 2;
        public int Motion { get; } = 3;
        public override void Hit()
        {
            
            Console.WriteLine($"Archer Strike Power: {StrikePower}");
        }

        public override void MotionCapability()
        {
            Console.WriteLine($"Archer Motion Capability: {Motion}");
        }
        public override int TotalPower()
        {
            totalPower = ((StrikePower * Motion) * Health) / 2;
            Console.WriteLine($"Archer Total Power: {totalPower}");
            return totalPower;
        }
    }
    public class Horseman : Soldiers, ISoldierProperties
    {
        int totalPower = 0;
        public int StrikePower { get; } = 5;
        public int Motion { get; } = 4;
        public override void Hit()
        {

            Console.WriteLine($"Horseman Strike Power: {StrikePower}");
        }

        public override void MotionCapability()
        {
            Console.WriteLine($"Horseman Motion Capability: {Motion}");
        }
        public override int TotalPower()
        {
            totalPower = ((StrikePower * Motion) * Health) / 2;
            Console.WriteLine($"Horseman Total Power: {totalPower}");
            return totalPower;

        }
    }

}
