using System;

namespace VPShelter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int userChoice = 0;
            VirtualPetShelter virtualPet = new VirtualPetShelter();

            do
            {
                Employee userEmployee;

                Console.WriteLine("Hello Welcome to the AstroMech Droid Shelter!");
                Console.WriteLine("1) Manager \n2) Volunteer");
                userChoice = int.Parse(Console.ReadLine());
                if (userChoice == 1)
                {
                    userEmployee = virtualPet.Manager;
                    
                }
                else
                {
                    userEmployee = virtualPet.Volunteer;
                }









            } while (userChoice != 6);
        }
    }
}