namespace Problem2
{
    internal class Problem2
    {

        static string ReadName(string Message)
        {
            string Name;
            Console.WriteLine(Message);
            Name = Console.ReadLine();
            return Name;

        }

        static void PrintName(string Name)
        {
            Console.WriteLine("Your Name is: " + Name);
        }

        static void Main(string[] args)
        {

            PrintName(ReadName("Enter Your Name ?"));

        }
    }
}
