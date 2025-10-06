namespace topic_5_part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int people = 20;
            int cats = 20;
            int dogs = 15;
            Console.WriteLine("People: " + people + " Dogs: " + dogs + " Cats: " + cats);
            if (people < cats)
            {
                Console.WriteLine("Too many cats! The world is doomed!");
            }
            if (people > cats)
            {
                Console.WriteLine("Not many cats! The world is saved!");
            }
            if (people < dogs)
            {
                Console.WriteLine("The world is drooled on!");
            }
            if (people > dogs)
            {
                Console.WriteLine("The world is dry!");
            }
            Console.WriteLine("Press ENTER to continue. ");
            Console.ReadLine();
            Console.Clear();
            dogs += 5; // Add 5 to dogs. What does dogs equal now?
            Console.WriteLine("People: " + people + " Dogs: " + dogs + " Cats: " + cats);
            if (people >= dogs)
            {
                Console.WriteLine("People are greater than or equal to dogs.");
            }
            if (people <= dogs)
            {
                Console.WriteLine("People are less than or equal to dogs.");
            }
            if (people == dogs)
            {
                Console.WriteLine("People are dogs.");
            }









            //Ashlyn Wright
            //part 1 topic 5
            //part 1

            //      double weight = 128;

            //      string planets;
            //      double gravity;

            //      double pounds;

            //      string venus;
            //      string mars;
            //      double jupiter = 2.65;
            //      double saturn = 1.17;
            //      double uranus = 1.05;
            //      double neptune = 1.23;
            //      double pounds;










            //Console.WriteLine("Please enter your current earth weight:");
            //      double Weight = Convert.ToDouble(Console.ReadLine());  
            //      Console.WriteLine("I have information for the following planets:");
            //      Console.WriteLine("1. Venus 2. Mars 3. Jupiter. ");
            //      Console.WriteLine("4 Saturn 5. Uranus 6. Neptune");
            //      Console.WriteLine("Which planet are you visiting?");
            //      double p = Convert.ToInt32(Console.ReadLine());
            //      Console.WriteLine("your weight would be:" +  weight * pounds);
            //      Console.ReadLine();












        }
    }
}
