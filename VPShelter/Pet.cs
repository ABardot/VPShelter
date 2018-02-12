namespace VPShelter
{
    public class Pet : VirtualPet
    {
        public string DroidType { get; set; }

        public string FoodType { get; set; }

        public Pet()
        {
            // Default
        }

        public Pet(string foodType, string droidType, string droidName, string droidDescription) : base(droidName, droidDescription)
        {
            FoodType = foodType;
            DroidType = droidType;
        }
    }
}