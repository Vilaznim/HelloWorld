public class BankAccount {
    private decimal _balance;
    public decimal Balance => _balance;

    public BankAccount(decimal initialBalance) {
        if (initialBalance < 0)
            throw new ArgumentException("Cannot start with negative balance");
        _balance = initialBalance;
    }

    public void Deposit(decimal amount) {
        if (amount < 0)
            throw new ArgumentException("Deposit amount must be positive");
        _balance += amount;
    }

    public void Withdraw(decimal amount) {
        if (amount <= 0)
            throw new ArgumentException("Withdraw amount must be positive");
        if (amount > _balance)
            throw new ArgumentException("Insufficient funds");
        _balance -= amount;
    }
static void Main() {
    var acct = new BankAccount(100m);
    acct.Deposit(50m);
    acct.Withdraw(30m);
    Console.WriteLine(acct.Balance);  // What’s the expected output?
    acct.Withdraw(121m);
    Console.WriteLine("trying to withdraw more than account has");
    
}

}