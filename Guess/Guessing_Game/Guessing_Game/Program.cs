class X
{
    public static void Main(string[] args)
    {
        Random rn = new Random();
        int winNum = rn.Next(0, 100);
        bool win = false;

        do
        {
            Console.Write("Enter a number between 0 and 10 : ");
            string s = Console.ReadLine();  
            int i = int.Parse(s);

            if (i > winNum)
            {
                Console.WriteLine("Number is too high");
            }
            else if (i < winNum)
            {
                Console.WriteLine("Number is too low");
            }
            else if (i == winNum)
            {
                Console.WriteLine("You Win");
                win = true;
            }
            Console.WriteLine();

        } while (win == false);

        Console.WriteLine("Thank you for playing the game");
        Console.WriteLine("Enter any key to exit");
        Console.ReadKey(true);

    }
}