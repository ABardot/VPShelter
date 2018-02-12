namespace VPShelter
{
    public class Pet : VirtualPet
    {
        public string DroidType { get; set; }

        public string FoodType { get; set; }

        public int HydraulicType { get; set; }

        public int BatteryType { get; set; }

        public Pet()
        {
            // Default
        }

        public Pet(string foodType, string droidType, string droidName, string droidDescription, int batteryLevel, int hydraulicPressure) : base(droidName, droidDescription, batteryLevel, hydraulicPressure)
        {
            FoodType = foodType;
            DroidType = droidType;
        }
    }
}