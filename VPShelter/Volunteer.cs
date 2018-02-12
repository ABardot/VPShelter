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

            Console.WriteLine("The {0} has a battery level of {1}", pet.BatteryLevel, pet.DroidType);
        }

        public override void FixHydraulicPressure(Pet pet)
        {
            Console.WriteLine("The {0} has injected {1}", pet.DroidType, pet.HydraulicPressureFixed);
        }

        public void GiveOil(List<Pet> pets)
        {
            foreach (var pet in pets)
            {
                Console.WriteLine("The {0} was given oil", pet.FoodType, pet.DroidType);
            }
        }

        public void GiveFood(List<Pet> pets)
        {
            foreach (var pet in pets)
            {
                Console.WriteLine("The {0} has been given {1}.", pet.FoodType, pet.DroidType);
            }
        }
    }
}