namespace VPShelter
{
    public class Pet : VirtualPet
    {

        public string DroidType { get; set; }

        public string FoodType { get; set; }

        public Pet(string foodType, string droidType) : base()
        {
            FoodType = foodType;
            DroidType = droidType;
        }
        
   
    }

    

}