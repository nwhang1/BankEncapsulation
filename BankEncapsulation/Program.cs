namespace BankEncapsulation
{

    public class BankAccount
    {
        private double balance = 0;
        public void Deposit(double amount)
        {
            balance += amount;
        }
        public double GetBalance()
        {
            return balance;
        }
    }
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
