using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Volunteer : Employee
    {
        public int VolunteerPay { get; set; }

        public Volunteer()
        {
            // default
        }
        public Volunteer(int volunteerPay)
        {
            VolunteerPay = volunteerPay;
        }

        public Volunteer(string feed, string thirst, string play, string hugPet, string exit)
        {
            Feed = feed;
            Thirst = thirst;
            Play = play;
            HugPet = hugPet;
            Exit = exit;
        }



        // Method overide void Methods here
        // Method feed CW
        //public virtual void Feed()
        //{
        //    Console.WriteLine("I have been feed");
        //}
        //// Method for water CW
        //public virtual void Water()
        //{
        //    Console.WriteLine("The pet has is not thirsty");
        //}

        //// Method for play CW
        //public virtual void Play()
        //{
        //    Console.WriteLine("The Pet is not bored");
        //}

        //// Method for play CW
        //public virtual void Hug()
        //{
        //    Console.WriteLine("The Pet is not bored");
        //}

        //// Method for quit CW
        //public virtual void Exit()
        //{
        //    Console.WriteLine("Thank you for your volunteer time at the shelter!");
        //}

    }
}
