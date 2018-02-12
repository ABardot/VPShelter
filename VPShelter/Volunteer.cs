using System;
using System.Collections.Generic;

namespace VPShelter
{
    public class Volunteer : Employee
    {
        public int VolunteerBadgeID { get; set; }

        public Volunteer(int id) : base(id)
        {
            VolunteerBadgeID = id;
        }

        public override void FixBattery(Pet pet)
        {
            pet.FixBattery();
            Console.WriteLine("The {0} has a battery level of {1}", pet.DroidType, pet.BatteryLevel);
        }

        public override void FixHydraulicPressure(Pet pet)
        {
            Console.WriteLine("The droid feels better now!");
        }

        public void GiveOil(List<Pet> pets)
        {
            foreach (var pet in pets)
            {
                Console.WriteLine("The {0} was given oil", pet.DroidType);
            }
        }

        public void GiveFood(List<Pet>pets)
        {
            foreach (var pet in pets)
            {
                Console.WriteLine("The {0} has been given {1}.", pet.DroidType, pet.FoodType ); 
            }
        }

        internal void FixHydraulicPressure()
        {
            Console.WriteLine("Beep Beep the droid makes a sound");
        }

        internal void FixBattery()
        {
            Console.WriteLine("The droid is feeling a lot better");
        }

        internal void GiveFood()
        {
            Console.WriteLine("The droid was given oil and it is not thirsty");
        }
    }
}