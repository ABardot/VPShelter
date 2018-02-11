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
            throw new NotImplementedException(); 
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
    }
}