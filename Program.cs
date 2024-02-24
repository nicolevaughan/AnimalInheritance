namespace AnimalInheritance
{
    // base Class 
    class Animal
    {
        private string name; // only accessible within this class
        protected string type; //accessible from derived classes
        public string color;  // accessible from any class

        public void setName(string name)
        {
            this.name = name;
        }
        public virtual string getName()
        {
            return this.name;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public virtual string getType()
        {
            return this.type;
        }
    }

    //derived class
    class Pets : Animal 
    {
        public string type; //accessible from any class
        protected string favFood; //accessible from derived classes

        public void setfavFood(string favFood)
        {
            this.favFood = favFood;
        }
        public virtual string getfavFood()
        {
            return favFood;
        }

        // access name through base because it is private
        public override string getName()
        {
            return base.getName();
        }

        // access type directly because it is protected and this is a derived class
        public override string getType()
        {
            return type;
        }

       

    }
    class Program
    {
        static void Main(string[] args)
        {
            //object of base class Animal
            Animal critter = new Animal();
            critter.setName("MTR");
            critter.setType("opossum");
            //color is a public field and can be accessed anywhere
            critter.color = "greyish white";

            Console.WriteLine("Animal Information!");
            Console.WriteLine($"My name is {critter.getName()}.");
            Console.WriteLine($"I am a {critter.getType()}.");
            Console.WriteLine($"I am a lovely {critter.color} color.");
            Console.WriteLine();

            //object of derived class Pets
            Pets friend = new Pets();
            friend.setName("Hammy");
            //type is now public because it is derived from Pets?
            friend.type = "hamster";
            //color is a public field and can be accessed anywhere
            friend.color = "tan";
            //favFood is a protected field
            friend.setfavFood("carrots");

            Console.WriteLine("Pet Information!");
            Console.WriteLine($"My name is {friend.getName()}.");
            Console.WriteLine($"I am a {friend.getType()}.");
            Console.WriteLine($"I am a beautiful {friend.color} color.");
            Console.WriteLine($"My favorite food is {friend.getfavFood()}.");

            Console.ReadLine(); //pauses end of program display
        }
    }
}