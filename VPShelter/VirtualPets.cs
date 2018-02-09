namespace VPShelter
{   // Base
    public class VirtualPets
    {
        // Fields
        // Properties
        private bool IsHunger { get; set; }
        private bool IsThirsty { get; set; }
        private bool IsBored { get; set; }
       
        // Constructors
        public VirtualPets()
        {
            //default
        }

       

        public VirtualPets(bool isHungry, bool isThirsty, bool isBored)
        {
            IsHunger = isHungry;
            IsThirsty = isThirsty;
            IsBored = isBored;
        }

       

        
    }
}