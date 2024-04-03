namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            Console.WriteLine("Enter Deposit Amount");
            double amount = Convert.ToDouble(Console.ReadLine());
            account.Deposit(amount);

            Console.WriteLine($"Balance : {account.GetBalance()}");
        }
    }
}
