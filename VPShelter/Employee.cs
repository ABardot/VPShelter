using System;

namespace VPShelter
{
    public abstract class Employee // Base
    {
        //public string Volunteer { get; set; }
        //public string Manager { get; set; }

        public Employee()
        {
            // Default
        }

        public Employee(string volunteer, string manager)
        {
            Volunteer = volunteer;
            Manager = manager;
        }

       

        // 2 Abstract Methods

        public abstract void AdoptPet(); // Virtual  Only Manager

        public abstract void BillPay(); // Virtual set as VOID!!!!!!!!!!!!!!!!!!!!!!!!!! Only Manager

        
    }
}