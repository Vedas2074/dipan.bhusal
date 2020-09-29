using System;

class SelectionStatement
{
    public void LearnIfElse()
    {

        byte age;
        Console.WriteLine("Enter your age: ");
        string ageString = Console.ReadLine();
        age = byte.Parse(ageString);
        if (age > 60)
        {
            Console.WriteLine("You are eligible for pension");
        }
        else if (age > 50)
        {
            Console.WriteLine("You are about to be eligible for pension.");
        }
        else
        {
            Console.WriteLine("You are not eligible for pension.");
        }
    }


    public void LearnSwitchCase()
    {
        string hobby;
        Console.Write("Enter yoyr hobby: ");
        hobby = Console.ReadLine();
        switch (hobby)
        {
            case "books":
                Console.WriteLine("You are book lover!!");
                break;
            case "batminton":
                Console.WriteLine("You are batminton lover!!");
                break;

            case "hiking":
                Console.WriteLine("You are hiking lover!!");
                break;
            default:
                Console.WriteLine("Hobby not found.");
                break;

        }
    }
}