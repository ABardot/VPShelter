using System;

namespace VPShelter
{
    internal class Program
    {
        private static void Main()
        {
            int userChoice = 0;
            int managerUser;
            int volunteerUser;
            VirtualPetShelter virtualPet = new VirtualPetShelter();
            Pet pet = new Pet();
            VirtualPet vp = new VirtualPet();

            

            Employee userEmployee; // Do not erase
            //do { 
            Console.WriteLine("Welcome to the Astromech Droid Shelter!");
            Console.WriteLine("Please enter your Employee Type");
            Console.WriteLine("1) Manager \n2) Volunteer");
            userChoice = int.Parse(Console.ReadLine());
            if (userChoice == 1)
            {
                Console.Clear();
                userEmployee = virtualPet.Manager;
                Console.WriteLine("What would you like to next?");
                Console.WriteLine("\n");
                Console.WriteLine("1) Add hydraulic fulid");
                Console.WriteLine("2) Give Oil");
                Console.WriteLine("3) Give food");
                Console.WriteLine("4) Quit");
                managerUser = int.Parse(Console.ReadLine());
                if (managerUser == 1)
                {
                    Console.Clear();

                    pet.FixHydraulicPressure();
                }
                else if (managerUser == 2)
                {
                    Console.Clear();
                    
                }
                else if (managerUser == 3)
                {
                    Console.Clear();
                   
                }
                   
            }
            
            {
                userEmployee = virtualPet.Volunteer;
                Console.WriteLine("What would you like to next?");
                Console.WriteLine("\n");
                Console.WriteLine("1) Add hydraulic fluid");
                Console.WriteLine("2) Give oil");
                Console.WriteLine("3) Give food");
                Console.WriteLine("4) Quit");
                if (userChoice == 1)
                {
                    pet.FixHydraulicPressure();
                }
                else if (userChoice == 2)
                {
                       
                }
            }
            Console.WriteLine(" Status of the droid: ");
            Console.WriteLine("\n");
            Console.WriteLine(" Droid | Description | Hydraulic Level | Battery Level |  Food  ");
            Console.WriteLine(" ------|-------------|-----------------|---------------|--------");
            //Console.WriteLine("   {0}       {1}          {2}              {3}         {4}  ", vp.DroidOne, vp.DroidDescriptionOne, vp.HydrolicPressure, vp.BatteryLevel, vp.BatteryFixed);
            //Console.WriteLine("   {0}       {1}          {2}              {3}         {4}  ", vp.DroidTwo, vp.DroidDescriptionTwo, vp.HydrolicPressure, vp.BatteryLevel, vp.BatteryLevel);
            //Console.WriteLine("   {0}       {1}          {2}              {3}         {4}  ", vp.DroidThree, vp.DroidDescriptionOne, vp.HydrolicPressure, vp.BatteryLevel, vp.HydrolicPressure);



            //} while (userChoice != 4);
        }
    }
}