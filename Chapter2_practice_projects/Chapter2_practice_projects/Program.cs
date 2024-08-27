namespace Chapter2_practice_projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----STUDENT REGISTRATION FORM-----

            // print "Student Registration Form
            Console.WriteLine("Student Registration Form");
            Console.WriteLine("");//blank line

            // capture info and declare variables
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter year of birth: ");
            string birthYear = Console.ReadLine();
            Console.WriteLine("");//blank line

            //complete the registration
            Console.WriteLine("Welcome " + firstName + " " + lastName);
            Console.WriteLine("Your registration is complete.");
            Console.WriteLine("Your temporary password is: " + firstName + "*" + birthYear);

            //space between
            Console.WriteLine("");//blank line
            Console.WriteLine("");//blank line
            Console.WriteLine("");//blank line



            //-----STUDENT REGISTRATION FORM-----

                //print welcome message
            Console.WriteLine("Welcome to the Letter Grade Converter");


                //declare while loop variable and begin while loop
            string choice = "y";
            while (choice.ToLower() == "y")
            {
                    //gather number grade
                Console.WriteLine("Enter numerical grade: ");
                int grade = int.Parse(Console.ReadLine());

                    //grade converter 'program'
                if (grade >= 88)
                {
                    Console.WriteLine("Letter grade: A");
                }
                else if (grade >= 80)
                {
                    Console.WriteLine("Letter grade: B");
                }
                else if (grade >= 68)
                {
                    Console.WriteLine("Letter grade: C");
                }
                else if (grade >= 60)
                {
                    Console.WriteLine("Letter grade: D");
                }
                else
                {
                    Console.WriteLine("Letter grade: F");
                }
                Console.WriteLine("");//blank line

                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine();
            }
                //space between
            Console.WriteLine("");//blank line
            Console.WriteLine("");//blank line
            Console.WriteLine("");//blank line



            //-----RECTANGLE CALCULATOR-----
            //print welcome message
            Console.WriteLine("Welcome to the Area and Perimeter Calculator");
            Console.WriteLine("");//blank line

            string choice = "y";
            while (choice.ToLower() == "y")
            {
                Console.Write("Enter length: ");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Enter width: ");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine("Area: " + length * width);
                Console.WriteLine("");//blank line
                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine();
                Console.WriteLine("");//blank line
            }

        }
    }
}