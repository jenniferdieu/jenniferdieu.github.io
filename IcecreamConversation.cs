class Program

{

    static void Main(string[] args)
    {

        Console.WriteLine("What type of icecream do you like?");
        String type = Console.ReadLine();

        switch (type)
        {
            case "strawberry":
                Console.WriteLine("Nice flavour!");
                break;
            case "vanilla":
                Console.WriteLine("Basic!");
                break;
            case "chocolate":
                Console.WriteLine("yummy");
                break;
            case "coffee":
                Console.WriteLine("very delicious!");
                break;
            default:
                Console.WriteLine("That's weird...");
                break;

        }



            Console.ReadKey();

    }


}

