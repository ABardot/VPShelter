namespace VPShelter
{
    public class Manager : Employee
    {
        public string Feed { get; set; }
        public string Thirst { get; set; }
        public string Exit { get; set; }
        public string Adopt { get; set; }
        public string PayBills { get; set; }
       

        public Manager()
        {
            // default
        }

        public Manager(string feed, string thirst, string adopt, string paybills, string exit)
        {
            Feed = feed;
            Thirst = thirst;
            Adopt = adopt;
            PayBills = paybills;
            Exit = exit;
            
        }

        public void FeedPet()
        {
            System.Console.WriteLine("The pet has been feed");
        }

        public void DrinkPet()
        {
            System.Console.WriteLine("The pet is not thirsty");
        }

        public void ExitOut()
        {
            System.Console.WriteLine("Thank you for visiting the Cleveland Pet Shelter");
        }

        public override void AdoptPet()
        {
            System.Console.WriteLine("The Pets has been adopted");
        }

        public override void BillPay()
        {
            System.Console.WriteLine("The Bills have been paid");
        }

       
    }
}