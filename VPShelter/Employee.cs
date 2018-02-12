namespace VPShelter
{
    public abstract class Employee // Base Abstract Method
    {
        public int EmployeeId { get; set; }

        public Employee(int id)
        {
            EmployeeId = id;
        }
        // My 2 abstract method
        public abstract void FixBattery(Pet pet);
       
        public abstract void FixHydraulicPressure(Pet pet); 

    }
}