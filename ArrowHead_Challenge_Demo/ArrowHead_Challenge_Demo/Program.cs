namespace ArrowHead_Challenge_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ArrowHead();

            Console.WriteLine("Goodbye");
        }

        static public void ArrowHead()
        {
            Console.Write("Enter the number of lines:  ");  //Get user input
            int numberOfLines = int.Parse(Console.ReadLine());

            string arrowHeadString = "";

            if (numberOfLines % 2 == 0)   //checks for even number. If numberOfLines is even, adds 1.
            {
                numberOfLines = numberOfLines + 1;
            }
            for (int i = 0; i < numberOfLines; i++)  //prints one line for each cycle of "numberOfLines".
            {
                if ((numberOfLines / 2) >= i)  // number of lines divided by 2 = i; this covers the first half.   The "equal to" portion makes sure the middle line also adds ">"
                {
                    arrowHeadString += ">";  //adds ">" character to the string
                    Console.WriteLine(arrowHeadString);

                }
                else
                {
                    arrowHeadString = arrowHeadString.Remove(arrowHeadString.Length - 1);  //removes last character from the string
                    Console.WriteLine(arrowHeadString);
                }
            }

        }
    }
}
