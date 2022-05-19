using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHub.Encapsulation
{
    public class AutomaticSavingAccount : BankAccount
    {
        private decimal _savingPercent = 5;
        private decimal _savedSaldo = 0;

        public AutomaticSavingAccount(string login, string pin, string accountName) : base(login, pin, accountName) { }

        public override void Withdraw(decimal withdraw)
        {
            base.Withdraw(withdraw);
            saveMoney(withdraw);
        }

        public override void Transfer(string toAccount, decimal money)
        {
            base.Transfer(toAccount, money);
            saveMoney(money);
        }

        private void saveMoney(decimal transferValue)
        {
            decimal savingValue = transferValue * (_savingPercent * (decimal)0.01);
            if (savingValue <= _saldo)
            {
                _saldo -= savingValue;
                _savedSaldo += savingValue;
                Console.WriteLine($"{_savingPercent}% ({savingValue}) was moved to savings");
            }
        }

        public override void GetSaldo()
        {
            base.GetSaldo();
            Console.WriteLine($"On savings: {_savedSaldo}");
        }
    }
}
