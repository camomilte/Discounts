namespace DiscountCalculator
{
    internal class Program
    {
        static void Main()
        {
            int total = 100;
            
            if (GetDiscount(total))
            {
                Console.WriteLine("Yay rabatt :D");
            }
            else
            {
                Console.WriteLine("Ingen rabatt >:(");
            }
                
        }

        static bool GetDiscount(int total)
        {
            return total >= 1000;
        }
    }
}
