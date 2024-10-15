namespace Problem3
{
    internal class Problem3
    {

        enum enOddOrEven { Odd, Even }

        static int ReadNumber(string Message)
        {

            int Num;
            Console.WriteLine(Message);
            Num = int.Parse(Console.ReadLine());
            return Num;

        }

        static enOddOrEven CheckOddOrEven(int Num)
        {

            if (Num % 2 == 0)
            {
                return enOddOrEven.Even;
            }
            else
            {
                return enOddOrEven.Odd;
            }
        
        }

        static void PrintResult(enOddOrEven Result)
        {

            Console.WriteLine("Number is: "+Result);

        }

        static void Main(string[] args)
        {

            PrintResult(CheckOddOrEven(ReadNumber("Enter The Number ?")));

        }
    }
}
