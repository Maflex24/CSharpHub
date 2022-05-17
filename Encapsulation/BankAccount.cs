using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHub.Encapsulation
{
    public class BankAccount
    {
        protected decimal _saldo = 0;
        protected string _login;
        protected string _accountName;
        protected string _pin; // I know it's not correct solution. It's just for test and keep simple
        protected bool _isLogged = false;

        public BankAccount(string login, string pin, string accountName)
        {
            _login = login;
            _pin = pin;
            _accountName = accountName;
        }

        public void LogIn(string login, string pin)
        {
            if (login == _login && pin == _pin)
            {
                Console.WriteLine($"You were succesfully logged into {_accountName}");
                _isLogged = true;
            }
        }

        public void Deposit(decimal deposit)
        {
            if (_isLogged)
            {
                _saldo += deposit;
                Console.WriteLine($"You deposited {deposit} to {_accountName}");
            }
        }

        public virtual void Withdraw(decimal withdraw)
        {
            if (_isLogged && withdraw <= _saldo)
            {
                _saldo -= withdraw;
                Console.WriteLine($"You withdrawn {withdraw}");
            }
        }

        public virtual void Transfer(string toAccount, decimal money)
        {
            if (money <= _saldo && _isLogged)
            {
                _saldo -= money;
                Console.WriteLine($"{money} transfered to account {toAccount} from {_accountName}");
            }
            else
                Console.WriteLine($"Not enough money to transfer from {_accountName} to {toAccount}");
        }

        public virtual void GetSaldo()
        {
            if (_isLogged)
                Console.WriteLine($"Your saldo on {_accountName} is: {_saldo}");
        }
    }
}
