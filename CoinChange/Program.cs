using System;
using System.Text;


namespace CoinChange
{
    class Program
    {
        static void Makechange(double total_amount, double remainAmount,int[] coins)
        {
         

            if ((total_amount % 2)< total_amount)
            {
                coins[0] = (int)(total_amount / 2);
                remainAmount = total_amount % 2;
                total_amount = remainAmount;
            }
            if ((total_amount % 1) < total_amount)
            {
                coins[1] = (int)(total_amount / 1);
                remainAmount = total_amount % 1;
                total_amount = remainAmount;
            }
            if ((total_amount % 0.50) < total_amount)
            {
                coins[2] = (int)(total_amount / 0.50);
                remainAmount = total_amount % 0.50;
                total_amount = remainAmount;
            }
            if ((total_amount % 0.20) < total_amount)
            {
                coins[3] = (int)(total_amount / 0.20);
                remainAmount = total_amount % 0.20;
                total_amount = remainAmount;
            }
            if ((total_amount % 0.10) < total_amount)
            {
                coins[4] = (int)(total_amount / 0.10);
                remainAmount = total_amount % 0.10;
                total_amount = remainAmount;
            }
            if ((total_amount % 0.05) < total_amount)
            {
                coins[5] = (int)(total_amount / 0.05);
                remainAmount = total_amount % 0.05;
                total_amount = remainAmount;
            }
            if ((total_amount % 0.02) < total_amount)
            {
                coins[6] = (int)(total_amount / 0.02);
                remainAmount = total_amount % 0.02;
                total_amount = remainAmount;
            }
            if ((total_amount % 0.01) < total_amount)
            {
                coins[7] = (int)(total_amount / 0.01);
                remainAmount = total_amount % 0.01;
                
            }
           
        }
        static void Showchange(int[] arr)
        {
            if (arr[0]>0)
            
                Console.WriteLine("Number of 2$: " + arr[0]);
            
            if (arr[1] > 0)
            
                Console.WriteLine("Number of 1$: " + arr[1]);
            
            if (arr[2] > 0)
            
                Console.WriteLine("Number of 50P: " + arr[2]);
            
            if (arr[3] > 0)
            
                Console.WriteLine("Number of 20P: " + arr[3]);
            
            if (arr[4] > 0)
            
                Console.WriteLine("Number of 10P: " + arr[4]);
            
            if (arr[5] > 0)
            
                Console.WriteLine("Number of 5P: " + arr[5]);
            
            if (arr[6] > 0)
            
                Console.WriteLine("Number of 2P: " + arr[6]);

            if (arr[7] > 0)

                Console.WriteLine("Number of 1P: " + arr[7]);
        }
        static void Main()
        {
            Console.WriteLine("Enter the cost");
            double cost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the tender");
            double tender = Convert.ToDouble(Console.ReadLine());

            double total_amount = tender - cost; 
            double toChange = total_amount;
            double remainAmount = 0.0;
            int[] coins = new int[8];
            Makechange(total_amount, remainAmount, coins);

            Console.WriteLine("The best way to change " +
            toChange + " pound is: ");
            Showchange(coins);
            Console.ReadLine();
        }
    }
}

