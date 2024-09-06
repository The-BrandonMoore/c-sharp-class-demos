namespace People
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");









        }

        static void PrintLabel(Employee p) 
        {
            Console.WriteLine($"{p.FirstName} {p.LastName}\n{p.Street} \n{p.City}, {p.State} {p.ZIP}");
        }
    }
}
