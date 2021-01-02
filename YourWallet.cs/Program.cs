using System;
using System.Threading.Tasks;

namespace YourWallet.cs
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool useSecure = false;
            while (true)
            {
                Console.WriteLine("Use secure mode ? (y/n)");
                var modeInput = Console.ReadLine();
                if(modeInput.Trim().ToLower() == "y")
                {
                    useSecure = true;
                    break;
                }else if (modeInput.Trim().ToLower() == "n")
                {
                    useSecure = false;
                    break;
                }
            }

            if (useSecure)
            {
                var wallet = new Wallet_s();
                while (true)
                {
                    Console.WriteLine($"You have {wallet.Money.ToPrimitive()} JPY");
                    Console.WriteLine($"-- You will pay 10 JPY. Press any key --");
                    Console.ReadKey();
                    wallet.Money = wallet.Money -= 10;
                }
            }
            else
            {
                var wallet = new Wallet();
                while (true)
                {
                    Console.WriteLine($"You have {wallet.Money} JPY");
                    Console.WriteLine($"-- You will pay 10 JPY. Press any key --");
                    Console.ReadKey();
                    wallet.Money = wallet.Money -= 10;
                }
            }
        }
    }
}
