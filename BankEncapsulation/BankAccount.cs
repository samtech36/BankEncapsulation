namespace BankEncapsulation;

public class BankAccount
{
    //properties
    public string Name { get; set; }
    public string Age { get; set; }


    private double balance = 0;
    
    
    //methods for the bank account class

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public double getBalance()
    {
        return balance;

    }
}