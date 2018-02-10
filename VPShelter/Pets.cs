namespace VPShelter
{
    class Pets
    {
        public string Dog { get; set; }
        public string Cat { get; set; }
        public string Rabbit { get; set; }
        public string DogChow { get; set; }
        public string CatChow { get; set; }
        public string Rabbitfood { get; set; }

        public Pets()
        {
            //Default
        }

        public Pets(string dog, string cat, string rabbit)
        {
            Dog = dog;
            Cat = cat;
            Rabbit = rabbit;
        }
    }

}