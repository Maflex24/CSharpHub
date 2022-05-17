using CSharpHub.Encapsulation;
using CSharpHub.OverrideAndHidden;

BankAccount mainBankAccount = new BankAccount("gabriel", "1234", "Main Account");
BankAccount savingAccount = new AutomaticSavingAccount("gabriel", "1234", "Automatic Saving Account");

mainBankAccount.LogIn("gabriel", "1234");
mainBankAccount.Deposit(6000);
mainBankAccount.GetSaldo();
mainBankAccount.Transfer("161819", 2000);
mainBankAccount.GetSaldo();
mainBankAccount.Withdraw(2000);
mainBankAccount.GetSaldo();

Console.WriteLine();
savingAccount.LogIn("gabriel", "1234");
savingAccount.Deposit(6000);
savingAccount.GetSaldo();
savingAccount.Transfer("161819", 2000);
savingAccount.GetSaldo();
savingAccount.Withdraw(2000);
savingAccount.GetSaldo();

Console.WriteLine();
BaseClass baseInheritClass = new InheritClass();
baseInheritClass.VirtualMethod();
baseInheritClass.NonVirtualMethod();