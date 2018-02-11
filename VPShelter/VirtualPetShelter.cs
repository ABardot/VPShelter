using System.Collections.Generic;

namespace VPShelter
{
    public class VirtualPetShelter
    {   //Prop
        
        public string EmployeeList { get; set; }
        public List Pets { get; set; }
        
        //Constructors
        public VirtualPetShelter()
        {
            //Default
        }

        public VirtualPetShelter(string cage, string employeeList)
        {
            this.Cage = cage;
            this.EmployeeList = employeeList;
        }
    }
}

//List<string> pets = new List<string>();
//private Pets dog = new Pets();
//private Pets cat = new Pets();
//private Pets rabbit = new Pets();

//private List<Pets> allPets = new List<Pets>
//{
//    new Pets(){ Cat = "Sylvester", CatChow = "Tuna"},
//    new Pets(){ Dog = "Spike", DogChow = "Steak"},
//    new Pets(){ Rabbit = "Sasha", RabbitChow = "Carrots" }
//};






//        //Method
//        public void ViewPetList()
//        {
//            foreach (object Pets in allPets)
//            {
//                System.Console.WriteLine(Pets);
//            }
//        }
//    }
//}