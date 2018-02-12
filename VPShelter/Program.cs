using System;
using System.Collections.Generic;

namespace VPShelter
{
    internal class Program
    {
        private static void Main()
        {
            int userChoice = 0;
           
            VirtualPetShelter virtualPet = new VirtualPetShelter();
            Pet pet = new Pet();

            Console.WriteLine("Welcome to the Astromech Droid Shelter!");
            Console.WriteLine("Please enter your Employee Type.");
            Console.WriteLine("1) Manager \n2) Volunteer");
            userChoice = int.Parse(Console.ReadLine());

            List<Pet> pets = new List<Pet>();
            Pet droidOne = new Pet("BB", "89", "50", "Bolt", 10, 89);
            Pet droidTwo = new Pet("R2", "89", "50", "Nut", 45, 12);
            Pet droidThree = new Pet("CP", "89", "50", "Screw", 18, 75);
            pets.Add(droidOne);
            pets.Add(droidTwo);
            pets.Add(droidThree);
           
            if (userChoice == 1)
            {
                
               
            }
            else
            {
               
            }
        }
    }  //} while (userChoice != 4);
}

//Console.WriteLine(" Status of the droid: ");
//    Console.WriteLine("\n");
//    Console.WriteLine(" Droid | Description | Hydraulic Level | Battery Level |  Food  ");
//    Console.WriteLine(" ------|-------------|-----------------|---------------|--------");
//    //Console.WriteLine("   {0}       {1}          {2}              {3}         {4}  ", vp.DroidOne, vp.DroidDescriptionOne, vp.HydrolicPressure, vp.BatteryLevel, vp.BatteryFixed);
//    //Console.WriteLine("   {0}       {1}          {2}              {3}         {4}  ", vp.DroidTwo, vp.DroidDescriptionTwo, vp.HydrolicPressure, vp.BatteryLevel, vp.BatteryLevel);
//    //Console.WriteLine("   {0}       {1}          {2}              {3}         {4}  ", vp.DroidThree, vp.DroidDescriptionOne, vp.HydrolicPressure, vp.BatteryLevel, vp.HydrolicPressure);