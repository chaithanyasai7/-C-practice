using System;

class BankAccount
{
    private decimal balance;

    public void Deposit(decimal amount)
    {
        balance += amount;
    }
    public decimal GetBalance()
    {
        return balance;
    }
}
