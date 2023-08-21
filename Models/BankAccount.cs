public class BankAccount
{
    public string Number { get; } =string.Empty;
    public string? Owner { get; set; }
    public decimal Balance { get; }

    public BankAccount(string name,decimal initialBalance) 
    {
        this.Owner = name;
        this.Balance = initialBalance;
    }

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
    }



    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
    }
}