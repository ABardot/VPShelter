using System;

namespace VPShelter
{
    
        public abstract class Employee // Base
        {
            public int EmployeeType { get; set; }
            public string Feed { get; set; }
            public string Thirst { get; set; }
            public string Play { get; set; }
            public string Exit { get; set; }
            public string Adopt { get; set; }
            public string PayBills { get; set; }
            public string HugPet { get; set; }

            public Employee()
            {
                // Default
            }

            public Employee(int employeeType)
            {
                EmployeeType = employeeType;
            }

            public Employee(string feed, string thirst, string play, string exit, string adopt, string paybills, string hugPet)
            {
                Feed = feed;
                Thirst = thirst;
                Play = play;
                Exit = exit;
                Adopt = adopt;
                PayBills = paybills;
                HugPet = hugPet;
            }

            // 2 Abstract Methods
            public void FeedPet()
            {
                Console.WriteLine("Feed the pet");
            }

            public void ThirstPet()
            {
                Console.WriteLine("The pet is not thirsty");
            }

            public void ExitNow()
            {
                Console.WriteLine("Thank you for visiting the Cleveland Pet Shelter");
            }

            public virtual void PetPlay() // Virtual
            {

            }

            public virtual void AdoptPet() // Virtual
            {
                Console.WriteLine("The pet has been adopted");
            }

            public virtual void BillPay() // Virtual
            {
                Console.WriteLine("The bills have been paid");
            }

            public virtual void PetHug()
            {
                Console.WriteLine("The pet is loved");
            }
        }
    
}