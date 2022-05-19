using CSharpHub;
using CSharpHub.Encapsulation;
using CSharpHub.OverrideAndHidden;

BankAccount mainBankAccount = new BankAccount("gabriel", "1234", "Main Account");
BankAccount savingAccount = new AutomaticSavingAccount("gabriel", "1234", "Automatic Saving Account");
List<BankAccount> bankAccounts = new List<BankAccount>();
bankAccounts.Add(mainBankAccount);
bankAccounts.Add(savingAccount);

foreach (var bankAccount in bankAccounts)
{
    bankAccount.LogIn("gabriel", "1234");
    bankAccount.Deposit(6000);
    bankAccount.GetSaldo();
    bankAccount.Transfer("618146", 2000);
    bankAccount.GetSaldo();
    bankAccount.Withdraw(2000);
    bankAccount.GetSaldo();
    Console.WriteLine();
}


Console.WriteLine();
BaseClass baseInheritClass = new InheritClass();
baseInheritClass.VirtualMethod();
baseInheritClass.NonVirtualMethod();
