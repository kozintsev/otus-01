using System;

namespace TestBank2
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

    public interface IBank<in T> where T : Account
    {
        void DoOperation(T account);
    }

    public class Bank<T> : IBank<T> where T : Account
    {
        public void DoOperation(T account)
        {
            account.DoTransfer();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var account = new Account();
            IBank<Account> ordinaryBank = new Bank<Account>();
            ordinaryBank.DoOperation(account);

            var depositAcc = new DepositAccount();
            IBank<DepositAccount> depositBank = ordinaryBank;
            depositBank.DoOperation(depositAcc);

            Console.ReadLine();
        }
    }
}
