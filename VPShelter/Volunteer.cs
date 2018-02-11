using System;
namespace VPShelter
{
    public class Volunteer : Employee
    {
        public string Feed { get; set; }
        public string Thirst { get; set; }
        public string Play { get; set; }
        public string HugPet { get; set; }
        public string Exit { get; set; }

        public Volunteer()
        {
            // default
        }

        public Volunteer(string feed, string thirst, string play, string hugPet, string exit)
        {
            Feed = feed;
            Thirst = thirst;
            Play = play;
            HugPet = hugPet;
            Exit = exit;
        }

        public void FeedPet()
        {
           Console.WriteLine("The pet has been feed");
        }

        public void DrinkPet()
        {
            Console.WriteLine("The pet is not thirsty");
        }

        public void ExitOut()
        {
            Console.WriteLine("Thank you for visiting the Cleveland Pet Shelter");
        }

        public void PlayPet()
        {
            Console.WriteLine("The pet is tired from playing");
        }

       public void PetHug()
        {
            Console.WriteLine("The pet is loved");
        }

        
    }
}