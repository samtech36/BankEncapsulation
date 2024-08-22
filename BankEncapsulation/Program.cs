using System.IO.Pipes;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine("How much money would you like to deposit?");
            var depositAmount = double.Parse(Console.ReadLine());
            
            account.Deposit(depositAmount);
            
            Console.WriteLine($"Thank you. Now you're balance is {account.getBalance()}");
        }
    }
}
