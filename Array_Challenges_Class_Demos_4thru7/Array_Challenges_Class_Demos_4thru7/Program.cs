namespace Array_Challenges_Class_Demos_4thru7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //challenge 4 First and Last 6
            //Console.WriteLine("Challenge 4: FirstLast6");
            //Console.WriteLine(FirstLast6([1, 2, 6]));
            //Console.WriteLine(FirstLast6([6, 1, 2, 3]));
            //Console.WriteLine(FirstLast6([13, 6, 1, 2, 3]));

            //Challenge 5 RotateLeft Arrays
            //RotateLeft3([1, 2, 3]);

            //challenge 6 Replace Characters in a string
            //ReplaceVowelsWithUnderscores();

            //challenge 7
            StringBits();





            Console.WriteLine("One does not simply walk into coding.");

        }
        static public Boolean FirstLast6(int[] nums)
        {
            bool result = true;
            Array arrayChecked = nums;
            int index0 = nums[0];
            int indexLast = nums[^1];

            if (index0 == 6)
            {
                result = true;
            }
            else if (indexLast == 6)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        static public int[] RotateLeft3(int[] nums)
        {
            int firstElement = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                nums[i - 1] = nums[i];
            }
            nums[^1] = firstElement;
            foreach (int i in nums)
            {
                Console.WriteLine(nums[i - 1]);
            }
            return nums;


        }

        static public void ReplaceVowelsWithUnderscores()
        {
            Console.Write("Please Enter a Sentence:  ");
            string userString = Console.ReadLine();
            Console.WriteLine(userString);

            for (int i = 0; i < userString.Length; i++)
            {
                if (userString[i] == 'a' || userString[i] == 'e' || userString[i] == 'i' ||
                    userString[i] == 'o' || userString[i] == 'u' || userString[i] == 'y' ||
                    userString[i] == 'A' || userString[i] == 'E' || userString[i] == 'I' ||
                    userString[i] == 'O' || userString[i] == 'U' || userString[i] == 'Y')
                {

                    userString = userString.Replace(userString[i], '_');
                }
            }
            Console.WriteLine(userString);
        }
        static public void StringBits()
        {
            Console.Write("Please Enter a Sentence:  ");
            string userString = Console.ReadLine();
            Console.WriteLine(userString);

            for (int i = 0; i < userString.Length; i++)
            {
                if (((i)+2)%2 == 0)
                {

                    userString = userString.Remove(userString[i]);
                }
            }
            Console.WriteLine(userString);
        }

    }
}
