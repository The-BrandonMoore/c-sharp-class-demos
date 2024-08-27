namespace CH05Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

                     //Main Method for Ch5 demos:

                {
                    Console.WriteLine("Welcome to the Chapter 5 demos!");
                // p. 139 Relational Operators (==, !=, >, etc.)

                //    string choice = "y";
                //    while (choice == "y")
                //{
                //    Console.WriteLine("In while loop . . . ");
                //}

                //int a = 10;
                //Console.WriteLine($"a != 10? {a != 10}");
                //Console.WriteLine($"a < 10? {a < 10}");
                //Console.WriteLine($"a >= 10? {a >= 10}");

                //// p. 141 Logical Operators

                //string lightColor = "Green";
                //Boolean pedestrianInCrosswalk = true;

                //if (lightColor == "Green" & !pedestrianInCrosswalk)
                //{
                //    Console.WriteLine("GO!");
                //}
                //else
                //{
                //    Console.WriteLine("Stop!");
                //}

                //// Two things make Sean happy: ice cream, payday
                //Boolean iceCream = false;
                //Boolean payday = true;

                //if (iceCream & payday)
                //{
                //    Console.WriteLine("double win!");

                //}
                //else if (iceCream || payday)
                //        {
                //    Console.WriteLine("1 out of 2, not bad!");
                //}

                //// p. 143 If-Else Statements
                //// traffic light
                //// - color: red - stop, yellow - slow, green - go
                ////- distanceToLight: > 30 slow, < 30 speed up, 

                //lightColor = "Green";
                //int distanceToLight = 28;

                //if(lightColor == "red")
                //{
                //    Console.WriteLine("Light is Red - Stop");
                //}
                //else if (lightColor == "yellow")
                //{
                //    Console.WriteLine("Light is Yellow . . .");
                //    if (distanceToLight >= 30)
                //    {
                //        Console.WriteLine("More than 30 yards away - Stop");

                //    }
                //    else
                //    {
                //        Console.WriteLine("More than 30 yards away - Speed Up!");
                //    }
                //}
                //else
                //{
                //    Console.WriteLine("Light is Green - Go!");
                //}






                // p. 145 Switch Statements
                ///------------------------------------FUN GAME-----------------------------------------------------
                //Console.WriteLine("Scary Adventure Game Options!");
                //Console.WriteLine("You are at the end of a long corridor.");
                //Console.WriteLine("There are three doors. Which one will you choose?!");
                //Console.WriteLine("1 - To the right is a red door with a skull and croosbones!");
                //Console.WriteLine("2 - To the left is a blue door with a snake and rock!");
                //Console.WriteLine("3 - Straight ahead is a purple door with daisies on it!");
                //Console.Write("Which Door (1/2/3)? ");
                //int door = Int32.Parse(Console.ReadLine());
                //switch (door)
                //{
                //    case 1:
                //        Console.WriteLine("Red door - immenent death . . . you are consumed in flames!");
                //        break;
                //    case 2:
                //        Console.WriteLine("Blue door - super dead . . . you are attacked by snakes falling from the ceiling!!");
                //        break;
                //    case 3:
                //        Console.WriteLine("Purple door - got lucky . . . nothing attacks from this door!");
                //        break;
                //}

                // p. 151 Conditional / ternary Operator
                string shippingStatus = "2-day";
                double charge = 0;

                if (shippingStatus == "2-day")
                    charge = 5;
                else
                    charge = 2;
                Console.WriteLine($"charge = {charge}");

                //below just simplifies the above. "?" makes the phrase be evaluated.
                charge = shippingStatus == "2-day" ? 5 : 2;
                Console.WriteLine($"Charge = {charge}");

                // p. 155 While vs Do-While Loops

                // p. 157 For Loops
                for (int i =0; i <= 10; i++)
                {
                    Console.WriteLine($"i is {i}");
                }

                Console.WriteLine("2 to 20 by 2's. . . ");
                for (int i = 2; i <=20; i += 2) {
                    Console.WriteLine($"i is {i}");
                }





                // p. 159 Continue/Break in While / Foor Loops


                while (true)
                {
                    // do stuff
                    Console.WriteLine("In an infinite loop!");
                    Console.Write("Are you bored yet (y/n)? ");
                    string answer = Console.ReadLine();
                    if (answer.ToLower() == "y")
                    {
                        break;
                    }
                }







                // p. 161 Integrated Debugger

                Console.WriteLine("bye");
                }






        }
    }
}