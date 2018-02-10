using System;
namespace VPShelter
{   // Base
    // Base Class
    class VirtualPet
    {

        public string PetName { get; set; }
        public bool Thirst { get; set; }
        public bool Hunger { get; set; }
        public bool Bored { get; set; }



        public VirtualPet()
        {
            // Default
        }

        public VirtualPet(string petName)
        {
            PetName = petName;

        }

        public VirtualPet(bool thirst, bool hunger, bool bored)
        {
            Thirst = thirst;
            Hunger = hunger;
            Bored = bored;
        }



    }
}