using System.Collections.Generic;

namespace VPShelter
{
    public class VirtualPetShelter
    {   //Prop
        public List<Employee> EmployeeList { get; set; }
        public Manager Manager { get { return (Manager)EmployeeList[1]; } }
        public Volunteer Volunteer { get { return (Volunteer)EmployeeList[0]; } }
        public Pet Pet { get { return (Pet)Pets[1]; } }

        public List<Pet> Pets { get; set; }

        //Constructors
        public VirtualPetShelter()
        {
            Manager manager = new Manager(9);
            Volunteer volunteer = new Volunteer(3);
            EmployeeList = new List<Employee>();
            EmployeeList.Add(volunteer);
            EmployeeList.Add(manager);

            Pets = new List<Pet>(); // Created as new List of pet
            Pet petOne = new Pet("BB", "89", "50", "Bolt");
            Pet petTwo = new Pet("R2", "89", "50", "Bolt");
            Pet petThree = new Pet("CP", "89", "50", "Bolt");
            Pets.Add(petOne);
            Pets.Add(petTwo);
            Pets.Add(petThree);
        }
    }
}