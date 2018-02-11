using System;
namespace VPShelter
{
    public class Manager : Employee
    {
        public int CheckBookAmount { get; set; }

        public Manager(int checkBook) : base(5)
        {
            CheckBookAmount = checkBook;
        }

        public override void FixBattery(Pet pet)
        {
            throw new System.NotImplementedException();
        }


        public override void FixHydraulicPressure(Pet pet)
        {
            pet.FixHydraulicPressure();
            Console.WriteLine("The {0} has a hydraulic pressure level of {1}", pet.DroidType, pet.HydrolicPressure );
        }

        public void AdoptDroid(Pet pet)
        {
            Console.WriteLine("The {0} was adopted.", pet.DroidType);
        }

    }
}