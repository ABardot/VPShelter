namespace VPShelter
{
    public class Pets : VirtualPets
    {
        //Properties
        public string Dog { get; set; }
        public string Cat { get; set; }
        public string Rabbit { get; set; }
        public string DogChow { get; set; }
        public string CatChow { get; set; }
        public string RabbitChow { get; set; }
        public string Name { get; set; }
        public string TypeOfPet { get; set; }

        //Constructor
        public Pets()
        {
            //Default
        }

        public Pets(string name, string typeOfPet)
        {
            this.Name = name;
            this.TypeOfPet = typeOfPet;
        }

        public Pets(string dog, string cat, string rabbit, string dogChow, string catChow, string rabbitChow)
        {
            this.Dog = dog;
            this.Cat = cat;
            this.Rabbit = rabbit;
            this.DogChow = dogChow;
            this.CatChow = catChow;
            this.RabbitChow = rabbitChow;
        }

        //Method
        //public string viewAnimalList()
        //{
        //    foreach (string animal in P)
        //    {

        //    }
        //}
    }
}