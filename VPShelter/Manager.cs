using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Manager : Employee
    {
        public int MangerSalary { get; set; }

        public Manager()
        {
            // default
        }

        public Manager(int managerSalary, string adopt)
        {
            MangerSalary = managerSalary;
            Adopt = "Manger adopt pets";
        }

        //public Manager(string feed, string thirst, string adopt, string paybills, int managerSalary, string exit)
        //{
        //}

        public override void AdoptPet()
        {
            base.AdoptPet();
        }


        //Method overide void Methods here
        //Method feed CW
        //public virtual void FeedPet()
        //{
        //    Console.WriteLine("I have been feed");
        //}
        //// Method for water CW
        //public virtual void Thirst()
        //{
        //    Console.WriteLine("The pet has is not thirsty");
        //}

        //// Method for adopt CW
        //public override void Adopt()
        //{
        //    Console.WriteLine("The pet has been adopted");
        //}

        ////Method to pay bills CW
        //public override void PayBills()
        //{
        //    Console.WriteLine("The Bills have been paid");
        //}

        //// Method for quit CW
        //public override void Exit()
        //{
        //    Console.WriteLine("Have a great day!");
        //}
    }
}
