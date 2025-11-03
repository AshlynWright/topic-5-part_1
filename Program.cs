namespace topic_5_part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ashlyn Wright
            //part 1 topic 5
            //part 1

            double earthweight = 128;

            string planets;
            double gravity;

            double pounds;

            double venus = 0.78;
            double mars = 0.39;
            double jupiter = 2.65;
            double saturn = 1.17;
            double uranus = 1.05;
            double neptune = 1.23;


            Console.WriteLine("Please enter your current earth weight:");
            double earthWeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("I have information for the following planets:");
            Console.WriteLine("1. Venus 2. Mars 3. Jupiter. ");
            Console.WriteLine("4 Saturn 5. Uranus 6. Neptune");
            Console.WriteLine("Which planet are you visiting?");
            double planet = Convert.ToDouble(Console.ReadLine());

            if (planet == 1)
            {
                planet = venus;
            }
            else if (planet == 2)
            {
                planet = mars;
            }
            else if (planet == 3)
            {
                planet = jupiter;
            }
            else if (planet == 4)
            {
                planet = saturn;
            }
            else if (planet == 5)
            {
                planet = uranus;
            }
            else if (planet == 6)
            {
                planet = neptune;
            }


            Console.WriteLine("Your weight would be " + earthweight * planet);

            












        }
    }
}
