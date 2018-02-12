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

            do
            {
                Console.WriteLine("Welcome to the Astromech Droid Shelter!");
                Console.WriteLine("Please enter your Employee Type.");
                Console.WriteLine("1) Manager \n2) Volunteer");
                userChoice = int.Parse(Console.ReadLine());

                List<Pet> pets = new List<Pet>();
                Pet droidOne = new Pet("BB", "BB", "BB", "Bolt", 10, 89);
                Pet droidTwo = new Pet("R2", "R2", "R2", "Nut", 45, 12);
                Pet droidThree = new Pet("CP", "CP", "CP", "Screw", 18, 75);
                pets.Add(droidOne);
                pets.Add(droidTwo);
                pets.Add(droidThree);

                if (userChoice == 1)
                {
                    userChoice = DoManagerWork(pets);
                }
                else
                {
                    userChoice = DoVolunteerWork(pets);
                }
            } while (userChoice != 4);
        }

        private static int DoManagerWork(List<Pet> pets)
        {
            DisplayPetsStatus(pets);
            Console.WriteLine("What would you like to next?");
            Console.WriteLine("\n");
            Console.WriteLine("1) Add hydraulic fluid");
            Console.WriteLine("2) Pay Bill");
            Console.WriteLine("3) Adopt a Droid"); //Adopt set as override
            Console.WriteLine("4) Quit");
            int managerUser = int.Parse(Console.ReadLine());
            Manager man = new Manager(150);
            switch (managerUser)
            {
                case 1:
                    man.FixHydraulicPressure(pets[1]);

                    break;

                case 2:
                    man.PayBill();
                    break;

                case 3:
                    man.AdoptDroid();
                    break;

                default:
                    break;
            }
            return managerUser;
        }

        private static int DoVolunteerWork(List<Pet> pets)
        {
            DisplayPetsStatus(pets);
            Console.WriteLine("What would you like to next?");
            Console.WriteLine("\n");
            Console.WriteLine("1) Add hydraulic fulid");
            Console.WriteLine("2) Give Oil");  // Hydro override methods
            Console.WriteLine("3) Give food"); // Battery override methods
            Console.WriteLine("4) Quit");
            int volunteerUser = int.Parse(Console.ReadLine());
            Volunteer vol = new Volunteer(150);
            switch (volunteerUser)
            {
                case 1:
                    vol.FixBattery(pets[1]);
                    break;

                case 2:
                    vol.GiveOil(pets);
                    break;

                case 3:
                    vol.GiveFood(pets);
                    break;

                default:
                    break;
            }

            return volunteerUser;
        }

        private static void DisplayPetsStatus(List<Pet> pets)
        {
            foreach (var pet in pets)
            {
                Console.WriteLine("Name: {0} | Description: {1} | Type: {2} | Food type: {3} | Battery level: {4} | Hydraulic pressure: {5}", pet.DroidName, pet.DroidDescription, pet.DroidType, pet.FoodType, pet.BatteryLevel, pet.HydraulicPressure);
            }
        }
    }
}

