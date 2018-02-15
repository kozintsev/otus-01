using System;

namespace TestBank
{
    public class Account
    {
        private static readonly Random Rnd = new Random();

        public void DoTransfer()
        {
            var sum = Rnd.Next(10, 120);
            Console.WriteLine("Клиент положил на счет {0} долларов", sum);
        }
    }

    public class DepositAccount : Account
    {
    }

    public interface IBank<out T> where T : Account
    {
        T DoOperation();
    }

    public class Bank : IBank<DepositAccount>
    {
        public DepositAccount DoOperation()
        {
            var acc = new DepositAccount();
            acc.DoTransfer();
            return acc;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            IBank<DepositAccount> depositBank = new Bank();
            depositBank.DoOperation();

            IBank<Account> ordinaryBank = depositBank;
            ordinaryBank.DoOperation();

            Console.ReadLine();
        }
    }
}
